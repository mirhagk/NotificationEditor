namespace NotificationEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.VariableTextBox = new System.Windows.Forms.TextBox();
            this.NotificationPreview = new System.Windows.Forms.WebBrowser();
            this.NotificationTextBox = new System.Windows.Forms.TextBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.NotificationID = new System.Windows.Forms.TextBox();
            this.NotificationIDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VariableTextBox
            // 
            this.VariableTextBox.Location = new System.Drawing.Point(13, 13);
            this.VariableTextBox.Multiline = true;
            this.VariableTextBox.Name = "VariableTextBox";
            this.VariableTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.VariableTextBox.Size = new System.Drawing.Size(386, 515);
            this.VariableTextBox.TabIndex = 0;
            this.VariableTextBox.TextChanged += new System.EventHandler(this.VariableTextBox_TextChanged);
            // 
            // NotificationPreview
            // 
            this.NotificationPreview.Location = new System.Drawing.Point(797, 12);
            this.NotificationPreview.MinimumSize = new System.Drawing.Size(20, 20);
            this.NotificationPreview.Name = "NotificationPreview";
            this.NotificationPreview.Size = new System.Drawing.Size(430, 515);
            this.NotificationPreview.TabIndex = 1;
            // 
            // NotificationTextBox
            // 
            this.NotificationTextBox.Location = new System.Drawing.Point(405, 13);
            this.NotificationTextBox.Multiline = true;
            this.NotificationTextBox.Name = "NotificationTextBox";
            this.NotificationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NotificationTextBox.Size = new System.Drawing.Size(386, 515);
            this.NotificationTextBox.TabIndex = 2;
            this.NotificationTextBox.TextChanged += new System.EventHandler(this.NotificationTextBox_TextChanged);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(1233, 158);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(148, 23);
            this.LoadButton.TabIndex = 3;
            this.LoadButton.Text = "Load Template";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // NotificationID
            // 
            this.NotificationID.Location = new System.Drawing.Point(1233, 45);
            this.NotificationID.Name = "NotificationID";
            this.NotificationID.Size = new System.Drawing.Size(148, 22);
            this.NotificationID.TabIndex = 4;
            this.NotificationID.TextChanged += new System.EventHandler(this.NotificationID_TextChanged);
            // 
            // NotificationIDLabel
            // 
            this.NotificationIDLabel.AutoSize = true;
            this.NotificationIDLabel.Location = new System.Drawing.Point(1233, 12);
            this.NotificationIDLabel.Name = "NotificationIDLabel";
            this.NotificationIDLabel.Size = new System.Drawing.Size(84, 17);
            this.NotificationIDLabel.TabIndex = 5;
            this.NotificationIDLabel.Text = "NoticationID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 580);
            this.Controls.Add(this.NotificationIDLabel);
            this.Controls.Add(this.NotificationID);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.NotificationTextBox);
            this.Controls.Add(this.NotificationPreview);
            this.Controls.Add(this.VariableTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox VariableTextBox;
        private System.Windows.Forms.WebBrowser NotificationPreview;
        private System.Windows.Forms.TextBox NotificationTextBox;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.TextBox NotificationID;
        private System.Windows.Forms.Label NotificationIDLabel;
    }
}

