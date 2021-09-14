using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WStoreNETAPI
{
    public partial class Default : Form
    {
        public static bool validKey;
        public static string apiKey;
        public Default()
        {
            InitializeComponent();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Default_Load(object sender, EventArgs e)
        {
// [PROGRAM START] //
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            if (keyBox.Text != "")
            {
                apiKey = keyBox.Text;
                MessageBox.Show("Успешно зададохте своя API KEY", "W-STORE | API");
                validKey = true;
            }
            else
            {
                Errors.KeyNotSET();
            }
        }

        private void testTopCustomer_Click(object sender, EventArgs e)
        {
            if (validKey == true)
            {
                apiRead.getTopCustomer(apiKey);
            }
            else
            {
                Errors.KeyNotSET();

            }
        }

        private void testQueue_Click(object sender, EventArgs e)
        {
            if (validKey == true)
            {
                apiRead.getOrders(apiKey);
            }
            else
            {
                Errors.KeyNotSET();

            }
        }

        private void recentTop_Click(object sender, EventArgs e)
        {
            if (validKey == true)
            {
                apiRead.getrecentTopCustomer(apiKey);
            }
            else
            {
                Errors.KeyNotSET();

            }
        }

        private void recentPayments_Click(object sender, EventArgs e)
        {
            if (validKey == true)
            {
                apiRead.getRecentPayments(apiKey);
            }
            else
            {
                Errors.KeyNotSET();
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (validKey == true)
            {
                apiRead.getGoal(apiKey);
            }
            else
            {
                Errors.KeyNotSET();
            }
        }

        private void recProduct_Click(object sender, EventArgs e)
        {
            if (validKey == true)
            {
                apiRead.getRecommendedProduct(apiKey);
            }
            else
            {
                Errors.KeyNotSET();
            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            if (validKey == true)
            {
                Sources.getSource = "product_id";
                ProductAPI productAPI = new ProductAPI();
                productAPI.ShowDialog();
            }
            else
            {
                Errors.KeyNotSET();
            }
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            if (validKey == true)
            {
                Sources.getSource = "category_id";
                ProductAPI productAPI = new ProductAPI();
                productAPI.ShowDialog();
            }
            else
            {
                Errors.KeyNotSET();
            }
        }
    }
}