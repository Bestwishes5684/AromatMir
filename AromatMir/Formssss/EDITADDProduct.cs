using AromatMir.DbContextT;
using AromatMir.Model;
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
    public partial class EDITADDProduct : Form
    {
        private readonly Product product1;
        public Product  product => product1;
        public EDITADDProduct()
        {
            InitializeComponent();
            CategcomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Text = "Добавть продукт";
            Adeditbnt.Text = "Добавить продукт";
            this.product1 = new Product();


        }

        
        public EDITADDProduct(Product product) : this()
        {
            Text = "Изменить продукт";
            Adeditbnt.Text = "Изменить ";

            this.product1 = product;
            ArticultextBox.Text = product.ProductArticleNumber;
            nametextBox.Text = product.ProductName;
            DesctextBox4.Text= product.ProductDescription;
            CategcomboBox.Text=product.ProductCategory;
            ManutextBox.Text= product.ProductManufacturer;
            CosttextBox.Text= product.ProductCost.ToString();
            DisctextBox6.Text=product.ProductDiscountAmount.ToString();
            SocktextBox.Text=product.ProductQuantityInStock.ToString();
            checkBox1.Checked=product.ProductStatus;




            
        }


        private void Adeditbnt_Click(object sender, EventArgs e)
        {
           
        }

        private void ArticultextBox_TextChanged(object sender, EventArgs e)
        {
            product.ProductArticleNumber=ArticultextBox.Text;

        }

        private void nametextBox_TextChanged(object sender, EventArgs e)
        {   
            product.ProductName=nametextBox.Text;

        }

        private void DesctextBox4_TextChanged(object sender, EventArgs e)
        {
            product.ProductDescription=DesctextBox4.Text;

        }

        private void CategcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            product.ProductCategory = (string)CategcomboBox.SelectedItem;
        }

        private void ManutextBox_TextChanged(object sender, EventArgs e)
        {
            product.ProductManufacturer = ManutextBox.Text;
        }

        private void CosttextBox_TextChanged(object sender, EventArgs e)
        {
            product.ProductCost = Convert.ToInt32(CosttextBox.Text);
        }

        private void DisctextBox6_TextChanged(object sender, EventArgs e)
        {
            product.ProductDiscountAmount = Convert.ToDecimal(DisctextBox6.Text);
        }

        private void SocktextBox_TextChanged(object sender, EventArgs e)
        {
            product.ProductQuantityInStock = Convert.ToInt32(SocktextBox.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            product.ProductStatus = checkBox1.Checked;
        }

        private void Adeditbnt_Click_1(object sender, EventArgs e)
        {
            using (var db = new TradeContext(DataBaseHelper.Option()))
            {
                Product product = new Product
                {
                    ProductArticleNumber = ArticultextBox.Text,
                    ProductName = nametextBox.Text,
                    ProductDescription = DesctextBox4.Text,
                    ProductCategory = (string)CategcomboBox.SelectedItem,
                    ProductManufacturer = ManutextBox.Text,
                    ProductCost = Convert.ToInt32(CosttextBox.Text),
                    ProductDiscountAmount = Convert.ToDecimal(DisctextBox6.Text),
                    ProductQuantityInStock = Convert.ToInt32(SocktextBox.Text),
                    ProductStatus = checkBox1.Checked,



                };

                db.Product.Add(product);
                db.SaveChanges();
                this.Close();


            }
        }
    }
}
