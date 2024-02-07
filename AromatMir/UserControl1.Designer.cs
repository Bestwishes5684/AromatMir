namespace AromatMir
{
    partial class UserControl1
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            AddPhoto = new Button();
            Editbutton = new Button();
            Delbutton = new Button();
            Addbutton = new Button();
            Instock = new Label();
            ProdusctStatus = new Label();
            PriceLBL = new Label();
            DISCLABL = new Label();
            MANUFlabel = new Label();
            Categ_LBL = new Label();
            DESC_lbl = new Label();
            NameLbl = new Label();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(AddPhoto);
            panel1.Controls.Add(Editbutton);
            panel1.Controls.Add(Delbutton);
            panel1.Controls.Add(Addbutton);
            panel1.Controls.Add(Instock);
            panel1.Controls.Add(ProdusctStatus);
            panel1.Controls.Add(PriceLBL);
            panel1.Controls.Add(DISCLABL);
            panel1.Controls.Add(MANUFlabel);
            panel1.Controls.Add(Categ_LBL);
            panel1.Controls.Add(DESC_lbl);
            panel1.Controls.Add(NameLbl);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(838, 196);
            panel1.TabIndex = 1;
            // 
            // AddPhoto
            // 
            AddPhoto.Location = new Point(708, 7);
            AddPhoto.Name = "AddPhoto";
            AddPhoto.Size = new Size(124, 44);
            AddPhoto.TabIndex = 13;
            AddPhoto.Text = "Добавить фотографию";
            AddPhoto.UseVisualStyleBackColor = true;
            AddPhoto.Click += AddPhoto_Click;
            // 
            // Editbutton
            // 
            Editbutton.Location = new Point(716, 132);
            Editbutton.Name = "Editbutton";
            Editbutton.Size = new Size(116, 44);
            Editbutton.TabIndex = 12;
            Editbutton.Text = "Изменить товар";
            Editbutton.UseVisualStyleBackColor = true;
            Editbutton.Click += Editbutton_Click;
            // 
            // Delbutton
            // 
            Delbutton.Location = new Point(594, 132);
            Delbutton.Name = "Delbutton";
            Delbutton.Size = new Size(116, 44);
            Delbutton.TabIndex = 11;
            Delbutton.Text = "Удалить товар";
            Delbutton.UseVisualStyleBackColor = true;
            Delbutton.Click += Delbutton_Click;
            // 
            // Addbutton
            // 
            Addbutton.Enabled = false;
            Addbutton.Location = new Point(464, 132);
            Addbutton.Name = "Addbutton";
            Addbutton.Size = new Size(124, 44);
            Addbutton.TabIndex = 10;
            Addbutton.Text = "Добавить в заказ";
            Addbutton.UseVisualStyleBackColor = true;
            Addbutton.Click += Addbutton_Click;
            // 
            // Instock
            // 
            Instock.AutoSize = true;
            Instock.Location = new Point(414, 78);
            Instock.Name = "Instock";
            Instock.Size = new Size(38, 15);
            Instock.TabIndex = 9;
            Instock.Text = "label4";
            // 
            // ProdusctStatus
            // 
            ProdusctStatus.AutoSize = true;
            ProdusctStatus.Location = new Point(283, 161);
            ProdusctStatus.Name = "ProdusctStatus";
            ProdusctStatus.Size = new Size(58, 15);
            ProdusctStatus.TabIndex = 8;
            ProdusctStatus.Text = "Актуален";
            // 
            // PriceLBL
            // 
            PriceLBL.AutoSize = true;
            PriceLBL.Location = new Point(283, 129);
            PriceLBL.Name = "PriceLBL";
            PriceLBL.Size = new Size(38, 15);
            PriceLBL.TabIndex = 7;
            PriceLBL.Text = "label4";
            // 
            // DISCLABL
            // 
            DISCLABL.AutoSize = true;
            DISCLABL.Location = new Point(414, 51);
            DISCLABL.Name = "DISCLABL";
            DISCLABL.Size = new Size(38, 15);
            DISCLABL.TabIndex = 6;
            DISCLABL.Text = "label4";
            // 
            // MANUFlabel
            // 
            MANUFlabel.AutoSize = true;
            MANUFlabel.Location = new Point(283, 104);
            MANUFlabel.Name = "MANUFlabel";
            MANUFlabel.Size = new Size(38, 15);
            MANUFlabel.TabIndex = 5;
            MANUFlabel.Text = "label4";
            // 
            // Categ_LBL
            // 
            Categ_LBL.AutoSize = true;
            Categ_LBL.Location = new Point(283, 78);
            Categ_LBL.Name = "Categ_LBL";
            Categ_LBL.Size = new Size(38, 15);
            Categ_LBL.TabIndex = 4;
            Categ_LBL.Text = "label3";
            // 
            // DESC_lbl
            // 
            DESC_lbl.AutoSize = true;
            DESC_lbl.Location = new Point(283, 51);
            DESC_lbl.Name = "DESC_lbl";
            DESC_lbl.Size = new Size(38, 15);
            DESC_lbl.TabIndex = 3;
            DESC_lbl.Text = "label2";
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.FlatStyle = FlatStyle.Flat;
            NameLbl.Location = new Point(283, 22);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new Size(38, 15);
            NameLbl.TabIndex = 2;
            NameLbl.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.D344Y7;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 190);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UserControl1";
            Size = new Size(841, 202);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label MANUFlabel;
        private Label Categ_LBL;
        private Label DESC_lbl;
        private Label NameLbl;
        private PictureBox pictureBox1;
        private Label Instock;
        private Label ProdusctStatus;
        private Label PriceLBL;
        private Label DISCLABL;
        private Button Editbutton;
        private Button Delbutton;
        private Button Addbutton;
        private Button AddPhoto;
        private OpenFileDialog openFileDialog1;
    }
}
