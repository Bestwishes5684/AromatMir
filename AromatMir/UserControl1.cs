using AromatMir.DbContextT;
using AromatMir.Formssss;
using AromatMir.Model;
using System.Windows.Forms;

namespace AromatMir
{
    public partial class UserControl1 : UserControl
    {

        private readonly Product product1;
        private EventHandler<(Product, byte[])> onImageChanged;
        public event Action<Product, byte[]> OnImageChanged;

        public UserControl1(Product product)
        {
            InitializeComponent();
            this.product1 = product;
            InitOrder(product);
            DostupButn();
        }

        private void InitOrder(Product product)
        {
            NameLbl.Text = product.ProductName;
            DESC_lbl.Text = product.ProductDescription;
            Categ_LBL.Text = product.ProductCategory;
            MANUFlabel.Text = product.ProductManufacturer;
            PriceLBL.Text = $"{product.ProductCost:C2}";
            DISCLABL.Text = product.ProductDiscountAmount.ToString();
            Instock.Text = product.ProductCost.ToString();
            ProdusctStatus.Text = product.ProductStatus ? "Есть в наличии" : "Нет в наличии";

            if (product.ProductPhoto != null)
            {
                pictureBox1.Image = Image.FromStream(new MemoryStream(product.ProductPhoto));

            }
            else
            {
              
            }
          

        }

        private void DostupButn()
        {
            if (ATH.USER == null)
            {

            }
            else
            {
                if (ATH.USER.UserRole == 1)
                {
                    Addbutton.Enabled = true;

                }

                if (ATH.USER.UserRole == 2)
                {
                    Addbutton.Enabled = true;
                    Editbutton.Enabled = true;
                    Delbutton.Enabled = true;
                    AddPhoto.Enabled= true;
                }
            }




        }

     
       

      

        private void AddPhoto_Click_1(object sender, EventArgs e)
        {
          
                if (openFileDialog1.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                var image = File.ReadAllBytes(openFileDialog1.FileName);
                OnImageChanged?.Invoke(product1, image);
                pictureBox1.Image = Image.FromStream(new MemoryStream(image));
            
            
        }

        private void Editbutton_Click_1(object sender, EventArgs e)
        {
            using (var db = new TradeContext(DataBaseHelper.Option()))
            {
                var productDb = db.Product.FirstOrDefault(x => x.ProductArticleNumber == product1.ProductArticleNumber);
                var prodictEdit = new EDITADDProduct(productDb);
               var result= prodictEdit.ShowDialog();
                if (result == DialogResult.OK)
                {
                    db.SaveChanges();
                    InitOrder(productDb);
                }
            };
        }

        private void Delbutton_Click_1(object sender, EventArgs e)
        {
            using (TradeContext db = new TradeContext(DataBaseHelper.Option()))
            {

                Product product = db.Product.FirstOrDefault();
                if (product != null)
                {
                    db.Product.Remove(product);
                    db.SaveChanges();
                    this.Hide();
                }



            }
        }
    }
}
