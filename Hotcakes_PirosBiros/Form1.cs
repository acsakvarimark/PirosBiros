using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
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
        string url = "http://20.234.113.211:8084/";
        string key = "1-69c91ed8-fe63-40aa-8a5c-85be6757e079";
        string productId = string.Empty;
        public Form1()
        {
            InitializeComponent();
            GetCategories();
        }

        public void GetCategories()
        {
            Api proxy = new Api(url, key);

            // call the API to find all orders in the store
            ApiResponse<List<CategorySnapshotDTO>> response = proxy.CategoriesFindAll();
            string json = JsonConvert.SerializeObject(response);

            ApiResponse<List<CategorySnapshotDTO>> categoriesApi = JsonConvert.DeserializeObject<ApiResponse<List<CategorySnapshotDTO>>>(json);

            var categories = from x in categoriesApi.Content
                             where x.Name != "Vasút"
                             select x.Name;

            listBoxCategories.DataSource = categories.ToList();
        }

        public void GetProducts(object category, string filter)
        {
            Api proxy = new Api(url, key);

            // call the API to find all orders in the store
            ApiResponse<List<ProductDTO>> response = proxy.ProductsFindAll();
            string json = JsonConvert.SerializeObject(response);

            ApiResponse<List<ProductDTO>> productsApi = JsonConvert.DeserializeObject<ApiResponse<List<ProductDTO>>>(json);

            DataTable dt = new DataTable();
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Price", typeof(int));
            dt.Columns.Add("Id", typeof(string));

            foreach (ProductDTO item in productsApi.Content)
            {
                if (item.Sku[0] == category.ToString()[0] && item.ProductName.ToLower().Contains(filter.ToLower()))
                {
                    dt.Rows.Add(item.ProductName, item.SitePrice, item.Bvin);
                }
            }

            dataGridView.DataSource = dt;
        }

        private void listBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = listBoxCategories.SelectedItem;

            GetProducts(selected, string.Empty);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var selected = listBoxCategories.SelectedItem;

            GetProducts(selected, textBox1.Text);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = (dataGridView.CurrentRow.Cells["Price"].Value.ToString());
            productId = dataGridView.CurrentRow.Cells["Id"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Api proxy = new Api(url, key);

            // call the API to find the product to update
            var product = proxy.ProductsFind(productId).Content;

            // update one or more properties of the product
            product.SitePrice = Int32.Parse(textBox2.Text);

            // call the API to update the product
            proxy.ProductsUpdate(product);

            MessageBox.Show("Price updated!");
        }
    }
}
