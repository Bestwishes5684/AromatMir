namespace AromatMir.Formssss
{
    partial class Main
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
            Authorization_BTN = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // Authorization_BTN
            // 
            Authorization_BTN.Location = new Point(118, 77);
            Authorization_BTN.Name = "Authorization_BTN";
            Authorization_BTN.Size = new Size(114, 40);
            Authorization_BTN.TabIndex = 0;
            Authorization_BTN.Text = "Авторизоваться ";
            Authorization_BTN.UseVisualStyleBackColor = true;
            Authorization_BTN.Click += Authorization_BTN_Click;
            // 
            // button2
            // 
            button2.Location = new Point(118, 139);
            button2.Name = "button2";
            button2.Size = new Size(114, 39);
            button2.TabIndex = 1;
            button2.Text = "Зайти как гость";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(118, 208);
            button3.Name = "button3";
            button3.Size = new Size(114, 33);
            button3.TabIndex = 2;
            button3.Text = "Выход";
            button3.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Authorization_BTN);
            Name = "Main";
            Text = "Главное меню";
            ResumeLayout(false);
        }

        #endregion

        private Button Authorization_BTN;
        private Button button2;
        private Button button3;
    }
}