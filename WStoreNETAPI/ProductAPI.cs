using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WStoreNETAPI
{
    public partial class ProductAPI : Form
    {
        public ProductAPI()
        {
            InitializeComponent();
        }

        private void ProductAPI_Load(object sender, EventArgs e)
        {
            if(Sources.getSource == "product_id")
            {
                source.Text = "Product ID:";
                sourceBox.PlaceholderText = "Enter Product ID ...";
            }
            if(Sources.getSource == "category_id")
            {
                source.Text = "Product Category:";
                sourceBox.PlaceholderText = "Enter Product Category ...";
            }
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if(Sources.getSource == "product_id")
            {
                apiRead.getProductByID(Default.apiKey);
            }
            if(Sources.getSource == "category_id")
            {
                apiRead.getProductByCategoryID(Default.apiKey);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
