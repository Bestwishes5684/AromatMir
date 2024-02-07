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

            }
            else
            {
                label1Name.Text = $"{ATH.USER.UserSurname} {ATH.USER.UserName} {ATH.USER.UserPatronymic} {ATH.USER.UserRole}";
            }



        }

        private void AromMir_Load(object sender, EventArgs e)
        {
            using (var TradeContext = new TradeContext(DataBaseHelper.Option()))
            {
                var products = TradeContext.Product.ToList();
                foreach (var product in products)
                {

                    var userControl = new UserControl1(product);
                    userControl.Parent = flowLayoutPanel1;
                    userControl.ImageChanged += UserControl_ImageChanged; ;
                }
            }



        }

        private void UserControl_ImageChanged(object? sender, (Product, byte[]) e)
        {
            throw new NotImplementedException();
        }

        private void AddOrder_Click(object sender, EventArgs e)
        {
            EDITADDProduct eDITADDProduct = new EDITADDProduct();
            eDITADDProduct.ShowDialog();


            var prodict = new UserControl1(eDITADDProduct.product);
            prodict.Parent = flowLayoutPanel1;

        }
    }
}
