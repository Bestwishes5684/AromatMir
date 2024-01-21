using AromatMir.DbContextT;
using AromatMir.ModelResponce;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AromatMir.Formssss
{
    public partial class AromMir : Form
    {
        public AromMir()
        {
            InitializeComponent();
            InitDataGrid();
        }

        private void InitDataGrid()
        {
            using (var dbContext = new TradeContext(DataBaseHelper.Option()))
            {
                dataGridView1.DataSource = dbContext.Product.Select(x => new ProductResponce
                {
                    ProductArticleNumber = x.ProductArticleNumber,
                    ProductName = x.ProductName,
                    ProductDescription = x.ProductDescription,
                    ProductCategory = x.ProductCategory,
                    ProductPhoto = x.ProductPhoto,
                    ProductManufacturer = x.ProductManufacturer,
                    ProductCost = x.ProductCost,
                    ProductDiscountAmount = x.ProductDiscountAmount,
                    ProductQuantityInStock = x.ProductQuantityInStock,
                    ProductStatus = x.ProductStatus,

                }).ToList();
            }
        }
    }
}
