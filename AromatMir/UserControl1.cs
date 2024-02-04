using AromatMir.DbContextT;
using AromatMir.Formssss;
using AromatMir.Model;

namespace AromatMir
{
    public partial class UserControl1 : UserControl
    {
        private readonly Product product1;
        private EventHandler<(Product, byte[])> onImageChanged;
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
                }
            }




        }

        private void Delbutton_Click(object sender, EventArgs e)
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

        private void Editbutton_Click(object sender, EventArgs e)
        {
            EDITADDProduct eDITADDProduct = new EDITADDProduct();
            eDITADDProduct.ShowDialog();
        }

        public event EventHandler<(Product, byte[])> ImageChanged
        {
            add
            {
                onImageChanged += value;
            }
            remove
            {
                onImageChanged -= value;
            }
        }



    }
}
