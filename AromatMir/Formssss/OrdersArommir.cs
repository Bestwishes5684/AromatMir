using AromatMir.DbContextT;
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
    public partial class OrdersArommir : Form
    {
        public OrdersArommir()
        {
            InitializeComponent();
        }

        private void OrdersArommir_Load(object sender, EventArgs e)
        {
            using (var TradeContext = new TradeContext(DataBaseHelper.Option()))
            {
                var products = TradeContext.Product.ToList();
                foreach (var product in products)
                {

                    var userControl = new UserControl1(product);
                    userControl.Parent = flowLayoutPanel1;
                     
                };
            }
        }
    }
}
