namespace AromatMir.Formssss
{
    partial class AromMir
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
            dataGridView1 = new DataGridView();
            ProductArticleNumber = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            ProductDescription = new DataGridViewTextBoxColumn();
            ProductCategory = new DataGridViewTextBoxColumn();
            ProductPhoto = new DataGridViewTextBoxColumn();
            ProductManufacturer = new DataGridViewTextBoxColumn();
            ProductCost = new DataGridViewTextBoxColumn();
            ProductDiscountAmount = new DataGridViewTextBoxColumn();
            ProductQuantityInStock = new DataGridViewTextBoxColumn();
            ProductStatus = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ProductArticleNumber, ProductName, ProductDescription, ProductCategory, ProductPhoto, ProductManufacturer, ProductCost, ProductDiscountAmount, ProductQuantityInStock, ProductStatus });
            dataGridView1.Location = new Point(-3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1464, 455);
            dataGridView1.TabIndex = 0;
            // 
            // ProductArticleNumber
            // 
            ProductArticleNumber.DataPropertyName = "ProductArticleNumber";
            ProductArticleNumber.HeaderText = "АртикулТовара";
            ProductArticleNumber.Name = "ProductArticleNumber";
            ProductArticleNumber.ReadOnly = true;
            // 
            // ProductName
            // 
            ProductName.DataPropertyName = "ProductName";
            ProductName.HeaderText = "Имя продукта";
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            // 
            // ProductDescription
            // 
            ProductDescription.DataPropertyName = "ProductDescription";
            ProductDescription.HeaderText = "Описание продукта";
            ProductDescription.Name = "ProductDescription";
            ProductDescription.ReadOnly = true;
            // 
            // ProductCategory
            // 
            ProductCategory.DataPropertyName = "ProductCategory";
            ProductCategory.HeaderText = "Категория продукта";
            ProductCategory.Name = "ProductCategory";
            ProductCategory.ReadOnly = true;
            // 
            // ProductPhoto
            // 
            ProductPhoto.DataPropertyName = "ProductPhoto";
            ProductPhoto.HeaderText = "Фото продукта ";
            ProductPhoto.Name = "ProductPhoto";
            ProductPhoto.ReadOnly = true;
            // 
            // ProductManufacturer
            // 
            ProductManufacturer.DataPropertyName = "ProductManufacturer";
            ProductManufacturer.HeaderText = "Производитель продукта";
            ProductManufacturer.Name = "ProductManufacturer";
            ProductManufacturer.ReadOnly = true;
            // 
            // ProductCost
            // 
            ProductCost.DataPropertyName = "ProductCost";
            ProductCost.HeaderText = "Цена продукта";
            ProductCost.Name = "ProductCost";
            ProductCost.ReadOnly = true;
            // 
            // ProductDiscountAmount
            // 
            ProductDiscountAmount.DataPropertyName = "ProductDiscountAmount";
            ProductDiscountAmount.HeaderText = "Скидка на продукт";
            ProductDiscountAmount.Name = "ProductDiscountAmount";
            ProductDiscountAmount.ReadOnly = true;
            // 
            // ProductQuantityInStock
            // 
            ProductQuantityInStock.DataPropertyName = "ProductQuantityInStock";
            ProductQuantityInStock.HeaderText = "Количество продукта в наличии ";
            ProductQuantityInStock.Name = "ProductQuantityInStock";
            ProductQuantityInStock.ReadOnly = true;
            // 
            // ProductStatus
            // 
            ProductStatus.DataPropertyName = "ProductStatus";
            ProductStatus.HeaderText = "Статус продукта ";
            ProductStatus.Name = "ProductStatus";
            ProductStatus.ReadOnly = true;
            // 
            // AromMir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1460, 616);
            Controls.Add(dataGridView1);
            Name = "AromMir";
            Text = "Ароматный мир ";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ProductArticleNumber;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductDescription;
        private DataGridViewTextBoxColumn ProductCategory;
        private DataGridViewTextBoxColumn ProductPhoto;
        private DataGridViewTextBoxColumn ProductManufacturer;
        private DataGridViewTextBoxColumn ProductCost;
        private DataGridViewTextBoxColumn ProductDiscountAmount;
        private DataGridViewTextBoxColumn ProductQuantityInStock;
        private DataGridViewTextBoxColumn ProductStatus;
    }
}