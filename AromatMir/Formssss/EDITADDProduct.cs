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
            nametextBox.Text = product.ProductName;

        }





        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }






        private void Adeditbnt_Click(object sender, EventArgs e)
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
