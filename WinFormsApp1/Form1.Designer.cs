namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_changeLabel = new Button();
            textBox_fiestName = new TextBox();
            textBox_lastName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button_changeLabel
            // 
            button_changeLabel.Location = new Point(188, 12);
            button_changeLabel.Name = "button_changeLabel";
            button_changeLabel.Size = new Size(65, 24);
            button_changeLabel.TabIndex = 0;
            button_changeLabel.Text = "change";
            button_changeLabel.UseVisualStyleBackColor = true;
            button_changeLabel.Click += button1_Click;
            button_changeLabel.KeyPress += button_changeLabel_KeyPress;
            button_changeLabel.MouseCaptureChanged += button1_Click;
            // 
            // textBox_fiestName
            // 
            textBox_fiestName.Location = new Point(188, 42);
            textBox_fiestName.Name = "textBox_fiestName";
            textBox_fiestName.Size = new Size(100, 23);
            textBox_fiestName.TabIndex = 1;
            // 
            // textBox_lastName
            // 
            textBox_lastName.CharacterCasing = CharacterCasing.Upper;
            textBox_lastName.Location = new Point(188, 71);
            textBox_lastName.Name = "textBox_lastName";
            textBox_lastName.PasswordChar = '*';
            textBox_lastName.Size = new Size(100, 23);
            textBox_lastName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 50);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 3;
            label1.Text = "First Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 79);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 4;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(215, 140);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 230);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_lastName);
            Controls.Add(textBox_fiestName);
            Controls.Add(button_changeLabel);
            Name = "Form1";
            Text = "Form1";
            MouseClick += Form1_MouseClick;
            MouseMove += Form1_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_changeLabel;
        private TextBox textBox_fiestName;
        private TextBox textBox_lastName;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
