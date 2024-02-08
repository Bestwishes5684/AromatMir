using AromatMir.DbContextT;
using AromatMir.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace AromatMir.Formssss
{
    public partial class AromMir : Form
    {
        public AromMir()
        {
            InitializeComponent();
            Dostup();

        }


        private void Dostup()
        {


            if (ATH.USER == null)
            {

                label1Name.Enabled = false;
                AddOrder.Enabled =false;

            }
            else
            {
                label1Name.Text = $"{ATH.USER.UserSurname} {ATH.USER.UserName} {ATH.USER.UserPatronymic} {ATH.USER.UserRole}";
                if (ATH.USER.UserRole == 2 || ATH.USER.UserRole == 3)
                {
                    AddOrder.Enabled = true;
                }

            }



        }

        private void AromMir_Load(object sender, EventArgs e)
        {
        



        }

        private void UserControl_ImageChanged(Product product, byte[] image )
        {
            using (var db = new TradeContext(DataBaseHelper.Option()))
            {
                var Productdb = db.Product.FirstOrDefault(x => x.ProductArticleNumber == product.ProductArticleNumber);
                Productdb.ProductPhoto = image;
                db.SaveChanges();
            }
        }

    
        private void AromMir_Load_1(object sender, EventArgs e)
        {
            using (var TradeContext = new TradeContext(DataBaseHelper.Option()))
            {
                var products = TradeContext.Product.ToList();
                foreach (var product in products)
                {

                    var userControl = new UserControl1(product);
                    userControl.Parent = flowLayoutPanel1;
                    userControl.OnImageChanged += UserControl_ImageChanged; ;
                }
            }

        }

        private void AddOrder_Click_1(object sender, EventArgs e)
        {
            EDITADDProduct eDITADDProduct = new EDITADDProduct();
            eDITADDProduct.ShowDialog();


            var prodict = new UserControl1(eDITADDProduct.product);
            prodict.Parent = flowLayoutPanel1;
        }
    }
}
