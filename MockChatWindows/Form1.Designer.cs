namespace MockChatWindows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mockTextBox = new System.Windows.Forms.RichTextBox();
            this.textEntryBox = new System.Windows.Forms.RichTextBox();
            this.mockButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mockTextBox
            // 
            this.mockTextBox.Location = new System.Drawing.Point(12, 263);
            this.mockTextBox.Name = "mockTextBox";
            this.mockTextBox.ReadOnly = true;
            this.mockTextBox.Size = new System.Drawing.Size(860, 186);
            this.mockTextBox.TabIndex = 2;
            this.mockTextBox.Text = "";
            this.mockTextBox.Click += new System.EventHandler(this.MockTextBoxClicked);
            // 
            // textEntryBox
            // 
            this.textEntryBox.Location = new System.Drawing.Point(12, 12);
            this.textEntryBox.Name = "textEntryBox";
            this.textEntryBox.Size = new System.Drawing.Size(860, 186);
            this.textEntryBox.TabIndex = 3;
            this.textEntryBox.Text = "";
            // 
            // mockButton
            // 
            this.mockButton.Location = new System.Drawing.Point(12, 204);
            this.mockButton.Name = "mockButton";
            this.mockButton.Size = new System.Drawing.Size(301, 53);
            this.mockButton.TabIndex = 4;
            this.mockButton.Text = "Mock";
            this.mockButton.UseVisualStyleBackColor = true;
            this.mockButton.Click += new System.EventHandler(this.MockButtonClick);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(571, 204);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(301, 53);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.mockButton);
            this.Controls.Add(this.textEntryBox);
            this.Controls.Add(this.mockTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Mock Chat";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button mockButton;
        private System.Windows.Forms.Button clearButton;
        public System.Windows.Forms.RichTextBox textEntryBox;
        public System.Windows.Forms.RichTextBox mockTextBox;
    }
}

