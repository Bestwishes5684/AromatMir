using AromatMir.DbContextT;
using AromatMir.Model;
using Microsoft.VisualBasic.ApplicationServices;
using User = AromatMir.Model.User;

namespace AromatMir.Formssss
{
    public partial class ATH : Form
    {
        public ATH()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new TradeContext(DataBaseHelper.Option()))
            {
                
                var user = db.User.FirstOrDefault(x=>x.UserLogin == textBox1.Text && x.UserPassword==textBox2.Text);
             
                if (user == null)
                {
                    MessageBox.Show("Неправильный логин или пароль");
                    return;
                }

                USER= user;

              


              
                var aromMir = new AromMir();
                this.Hide();
                aromMir.ShowDialog();
                this.Show();
            
           


             }

        }


        public static User USER { get; set; }


        private void button3_Click(object sender, EventArgs e)
        {
            AromMir aromMir =new AromMir();
            aromMir.Show();
            USER = null;
        }
    }
}






