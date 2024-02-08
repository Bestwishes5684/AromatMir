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
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddPhoto = new System.Windows.Forms.Button();
            this.Editbutton = new System.Windows.Forms.Button();
            this.Delbutton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Instock = new System.Windows.Forms.Label();
            this.ProdusctStatus = new System.Windows.Forms.Label();
            this.PriceLBL = new System.Windows.Forms.Label();
            this.DISCLABL = new System.Windows.Forms.Label();
            this.MANUFlabel = new System.Windows.Forms.Label();
            this.Categ_LBL = new System.Windows.Forms.Label();
            this.DESC_lbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddPhoto);
            this.panel1.Controls.Add(this.Editbutton);
            this.panel1.Controls.Add(this.Delbutton);
            this.panel1.Controls.Add(this.Addbutton);
            this.panel1.Controls.Add(this.Instock);
            this.panel1.Controls.Add(this.ProdusctStatus);
            this.panel1.Controls.Add(this.PriceLBL);
            this.panel1.Controls.Add(this.DISCLABL);
            this.panel1.Controls.Add(this.MANUFlabel);
            this.panel1.Controls.Add(this.Categ_LBL);
            this.panel1.Controls.Add(this.DESC_lbl);
            this.panel1.Controls.Add(this.NameLbl);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 196);
            this.panel1.TabIndex = 1;
            // 
            // AddPhoto
            // 
            this.AddPhoto.Enabled = false;
            this.AddPhoto.Location = new System.Drawing.Point(708, 7);
            this.AddPhoto.Name = "AddPhoto";
            this.AddPhoto.Size = new System.Drawing.Size(124, 44);
            this.AddPhoto.TabIndex = 13;
            this.AddPhoto.Text = "Добавить фотографию";
            this.AddPhoto.UseVisualStyleBackColor = true;
            this.AddPhoto.Click += new System.EventHandler(this.AddPhoto_Click_1);
            // 
            // Editbutton
            // 
            this.Editbutton.Enabled = false;
            this.Editbutton.Location = new System.Drawing.Point(716, 132);
            this.Editbutton.Name = "Editbutton";
            this.Editbutton.Size = new System.Drawing.Size(116, 44);
            this.Editbutton.TabIndex = 12;
            this.Editbutton.Text = "Изменить товар";
            this.Editbutton.UseVisualStyleBackColor = true;
            this.Editbutton.Click += new System.EventHandler(this.Editbutton_Click_1);
            // 
            // Delbutton
            // 
            this.Delbutton.Enabled = false;
            this.Delbutton.Location = new System.Drawing.Point(594, 132);
            this.Delbutton.Name = "Delbutton";
            this.Delbutton.Size = new System.Drawing.Size(116, 44);
            this.Delbutton.TabIndex = 11;
            this.Delbutton.Text = "Удалить товар";
            this.Delbutton.UseVisualStyleBackColor = true;
            this.Delbutton.Click += new System.EventHandler(this.Delbutton_Click_1);
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(464, 132);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(124, 44);
            this.Addbutton.TabIndex = 10;
            this.Addbutton.Text = "Добавить в заказ";
            this.Addbutton.UseVisualStyleBackColor = true;
            // 
            // Instock
            // 
            this.Instock.AutoSize = true;
            this.Instock.Location = new System.Drawing.Point(414, 78);
            this.Instock.Name = "Instock";
            this.Instock.Size = new System.Drawing.Size(38, 15);
            this.Instock.TabIndex = 9;
            this.Instock.Text = "label4";
            // 
            // ProdusctStatus
            // 
            this.ProdusctStatus.AutoSize = true;
            this.ProdusctStatus.Location = new System.Drawing.Point(283, 161);
            this.ProdusctStatus.Name = "ProdusctStatus";
            this.ProdusctStatus.Size = new System.Drawing.Size(58, 15);
            this.ProdusctStatus.TabIndex = 8;
            this.ProdusctStatus.Text = "Актуален";
            // 
            // PriceLBL
            // 
            this.PriceLBL.AutoSize = true;
            this.PriceLBL.Location = new System.Drawing.Point(283, 129);
            this.PriceLBL.Name = "PriceLBL";
            this.PriceLBL.Size = new System.Drawing.Size(38, 15);
            this.PriceLBL.TabIndex = 7;
            this.PriceLBL.Text = "label4";
            // 
            // DISCLABL
            // 
            this.DISCLABL.AutoSize = true;
            this.DISCLABL.Location = new System.Drawing.Point(414, 51);
            this.DISCLABL.Name = "DISCLABL";
            this.DISCLABL.Size = new System.Drawing.Size(38, 15);
            this.DISCLABL.TabIndex = 6;
            this.DISCLABL.Text = "label4";
            // 
            // MANUFlabel
            // 
            this.MANUFlabel.AutoSize = true;
            this.MANUFlabel.Location = new System.Drawing.Point(283, 104);
            this.MANUFlabel.Name = "MANUFlabel";
            this.MANUFlabel.Size = new System.Drawing.Size(38, 15);
            this.MANUFlabel.TabIndex = 5;
            this.MANUFlabel.Text = "label4";
            // 
            // Categ_LBL
            // 
            this.Categ_LBL.AutoSize = true;
            this.Categ_LBL.Location = new System.Drawing.Point(283, 78);
            this.Categ_LBL.Name = "Categ_LBL";
            this.Categ_LBL.Size = new System.Drawing.Size(38, 15);
            this.Categ_LBL.TabIndex = 4;
            this.Categ_LBL.Text = "label3";
            // 
            // DESC_lbl
            // 
            this.DESC_lbl.AutoSize = true;
            this.DESC_lbl.Location = new System.Drawing.Point(283, 51);
            this.DESC_lbl.Name = "DESC_lbl";
            this.DESC_lbl.Size = new System.Drawing.Size(38, 15);
            this.DESC_lbl.TabIndex = 3;
            this.DESC_lbl.Text = "label2";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NameLbl.Location = new System.Drawing.Point(283, 22);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(38, 15);
            this.NameLbl.TabIndex = 2;
            this.NameLbl.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AromatMir.Properties.Resources.V324R5;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(841, 202);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
