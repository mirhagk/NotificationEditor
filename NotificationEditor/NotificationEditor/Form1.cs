using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotificationEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadDBVariables();
        }

        private void NotificationTextBox_TextChanged(object sender, EventArgs e)
        {
            NotificationPreview.DocumentText = CompileTemplate(NotificationTextBox.Text);
        }
        Dictionary<string, string> Variables = new Dictionary<string, string>();
        Dictionary<string, string> DBVariables = new Dictionary<string, string>();
        Dictionary<string, string> NotificationVariables = new Dictionary<string, string>();
        string NotificationFileName = null;
        private string CompileTemplate(string text)
        {
            string result = text;
            foreach (var pair in Variables)
                result = Regex.Replace(result, "%" + pair.Key + "%", pair.Value, RegexOptions.IgnoreCase);
            return result;
        }

        private void VariableTextBox_TextChanged(object sender, EventArgs e)
        {
            Variables = VariableTextBox.Text.Split('\n').ToDictionary(x => x.Split('=').First().Trim().ToUpperInvariant(), x => string.Join("=", x.Split('=').Skip(1)).Trim());
            foreach (var pair in NotificationVariables) if (!Variables.ContainsKey(pair.Key)) Variables.Add(pair.Key, pair.Value);
            foreach (var pair in DBVariables) if (!Variables.ContainsKey(pair.Key)) Variables.Add(pair.Key, pair.Value);
            NotificationTextBox_TextChanged(sender, e);
        }
        private void LoadDBVariables()
        {
            var connectionString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];
            var connection = new System.Data.SqlClient.SqlConnection(connectionString);
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = System.Configuration.ConfigurationManager.AppSettings["VariableQuery"];
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var key = reader.GetString(0);
                var value = reader.GetString(1);
                DBVariables.Add(key.ToUpperInvariant(), value);
            }
            reader.Close();
            connection.Close();
            VariableTextBox_TextChanged(null, null);
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.CheckFileExists = true;
            var result = dialog.ShowDialog();
            NotificationFileName = dialog.FileName;
            var reader = new StreamReader(dialog.OpenFile());
            NotificationTextBox.Text = reader.ReadToEnd();
            reader.Close();
        }

        private void NotificationID_TextChanged(object sender, EventArgs e)
        {
            var connectionString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];
            var connection = new System.Data.SqlClient.SqlConnection(connectionString);
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = System.Configuration.ConfigurationManager.AppSettings["NotificationQuery"].Replace("%NOTIFICATIONID%",NotificationID.Text);
            NotificationVariables = new Dictionary<string, string>();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var key = reader.GetString(0);
                //reader.GetString
                if (reader.IsDBNull(1))
                    continue;
                var value = reader.GetString(1);
                NotificationVariables.Add(key.ToUpperInvariant(), value);
            }
            reader.Close();
            connection.Close();
            VariableTextBox_TextChanged(null, null);
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveButton.Enabled = false;
            var writer = new StreamWriter(NotificationFileName);
            writer.Write(NotificationTextBox.Text);
            writer.Close();
            SaveButton.Enabled = true;
        }

        private void SaveAsButton_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.FileName = NotificationFileName;
            var result = dialog.ShowDialog();
            NotificationFileName = dialog.FileName;
            SaveButton_Click(sender, e);

        }
    }
}
