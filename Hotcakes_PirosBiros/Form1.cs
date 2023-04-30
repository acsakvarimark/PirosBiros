using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotcakes.CommerceDTO.v1;
using Hotcakes.CommerceDTO.v1.Catalog;
using Hotcakes.CommerceDTO.v1.Client;
using Hotcakes.CommerceDTO.v1.Contacts;
using Hotcakes.CommerceDTO.v1.Orders;
using Newtonsoft.Json;

namespace Hotcakes_PirosBiros
{
    public partial class Form1 : Form
    {
        string webUrl = "http://20.234.113.211:8084/";
        string apiKey = "1-bc670955-f477-441d-8f8c-60cd5d958f8e";

        string selectedProductId = string.Empty;
        string selectedCategorie = string.Empty;

        Api proxy;

        public Form1()
        {
            InitializeComponent();
            proxy = new Api(webUrl, apiKey);
        }

        public void GetProducts(string category, string filter)
        {
            // call the API to get all the products
            ApiResponse<List<ProductDTO>> response = proxy.ProductsFindAll();
            string json = JsonConvert.SerializeObject(response);

            ApiResponse<List<ProductDTO>> productsApi = JsonConvert.DeserializeObject<ApiResponse<List<ProductDTO>>>(json);

            // add columns
            DataTable dt = new DataTable();
            dt.Columns.Add("Termék_Neve", typeof(string));
            dt.Columns.Add("Ár", typeof(int));
            dt.Columns.Add("ID", typeof(string));

            // add data to tables
            foreach (ProductDTO item in productsApi.Content)
            {
                if (item.Sku[0] == category.ToString()[0] && item.ProductName.ToLower().Contains(filter.ToLower()))
                {
                    DataRow dataRow = dt.NewRow();
                    dataRow["Termék_Neve"] = item.ProductName;
                    dataRow["Ár"] = item.SitePrice;
                    dataRow["ID"] = item.Bvin;
                    dt.Rows.Add(dataRow);
                }
            }

            productsDataGridView.DataSource = dt;
        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            GetProducts(selectedCategorie, filterTextBox.Text);
        }

        private void productsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            priceTextBox.Text = (productsDataGridView.CurrentRow.Cells["Ár"].Value.ToString());
            textBox1.Text = productsDataGridView.CurrentRow.Cells["Termék_Neve"].Value.ToString();
            selectedProductId = productsDataGridView.CurrentRow.Cells["ID"].Value.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var save = MessageBox.Show("Biztos frissíteni szeretnéd az árat?", "Árfrissítés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (save == DialogResult.Yes)
            {
                // call the API to find the product to update
                var product = proxy.ProductsFind(selectedProductId).Content;

                // update price of the product
                product.SitePrice = Int32.Parse(priceTextBox.Text);

                // call the API to update the product
                proxy.ProductsUpdate(product);

                GetProducts(selectedCategorie, filterTextBox.Text);

                MessageBox.Show("Ár sikeresen frissítve!");
            }
            else
            {
                return;
            }
        }

        private void priceTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("[0-9]");
            if (!regex.IsMatch(priceTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(priceTextBox, "Csak számokat adhatsz meg!");
            }
        }

        private void priceTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(priceTextBox, string.Empty);
        }

        private void buttonPlane_Click(object sender, EventArgs e)
        {
            selectedCategorie = "Repülő";

            GetProducts(selectedCategorie, string.Empty);

            buttonPlane.BackColor = Color.Silver;
            buttonTrain.BackColor = Color.White;
            buttonCar.BackColor = Color.White;
            buttonAccess.BackColor = Color.White;

            priceTextBox.Text = null;
            textBox1.Text = null;
            selectedProductId = null;
        }

        private void buttonTrain_Click(object sender, EventArgs e)
        {
            selectedCategorie = "Vonat";

            GetProducts(selectedCategorie, string.Empty);

            buttonPlane.BackColor = Color.White;
            buttonTrain.BackColor = Color.Silver;
            buttonCar.BackColor = Color.White;
            buttonAccess.BackColor = Color.White;

            priceTextBox.Text = null;
            textBox1.Text = null;
            selectedProductId = null;
        }

        private void buttonCar_Click(object sender, EventArgs e)
        {
            selectedCategorie = "Autó";

            GetProducts(selectedCategorie, string.Empty);

            buttonPlane.BackColor = Color.White;
            buttonTrain.BackColor = Color.White;
            buttonCar.BackColor = Color.Silver;
            buttonAccess.BackColor = Color.White;

            priceTextBox.Text = null;
            textBox1.Text = null;
            selectedProductId = null;
        }

        private void buttonAccess_Click(object sender, EventArgs e)
        {
            selectedCategorie = "Kiegészítő";

            GetProducts(selectedCategorie, string.Empty);

            buttonPlane.BackColor = Color.White;
            buttonTrain.BackColor = Color.White;
            buttonCar.BackColor = Color.White;
            buttonAccess.BackColor = Color.Silver;

            priceTextBox.Text = null;
            textBox1.Text = null;
            selectedProductId = null;
        }
    }
}
