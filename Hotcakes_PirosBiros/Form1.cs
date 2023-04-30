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
        string webUrl = "http://20.234.113.211:8084/";
        string apiKey = "1-bc670955-f477-441d-8f8c-60cd5d958f8e";

        string selectedProductId = string.Empty;
        object selectedCategorie = string.Empty;

        Api proxy;

        public Form1()
        {
            InitializeComponent();
            proxy = new Api(webUrl, apiKey);
            GetCategories();
        }

        public void GetCategories()
        {
            // call the API to get all the categories
            ApiResponse<List<CategorySnapshotDTO>> response = proxy.CategoriesFindAll();
            string json = JsonConvert.SerializeObject(response);

            ApiResponse<List<CategorySnapshotDTO>> categoriesApi = JsonConvert.DeserializeObject<ApiResponse<List<CategorySnapshotDTO>>>(json);

            var categories = from x in categoriesApi.Content
                             where x.Name != "Vasút"
                             select x.Name;

            categoriesListBox.DataSource = categories.ToList();
        }

        public void GetProducts(object category, string filter)
        {
            // call the API to get all the products
            ApiResponse<List<ProductDTO>> response = proxy.ProductsFindAll();
            string json = JsonConvert.SerializeObject(response);

            ApiResponse<List<ProductDTO>> productsApi = JsonConvert.DeserializeObject<ApiResponse<List<ProductDTO>>>(json);

            // add columns
            DataTable dt = new DataTable();
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Price", typeof(int));
            dt.Columns.Add("Id", typeof(string));


            // add data to tables
            foreach (ProductDTO item in productsApi.Content)
            {
                if (item.Sku[0] == category.ToString()[0] && item.ProductName.ToLower().Contains(filter.ToLower()))
                {
                    dt.Rows.Add(item.ProductName, item.SitePrice, item.Bvin);
                }
            }

            productsDataGridView.DataSource = dt;
            productsDataGridView.Columns["Id"].Visible = false;
            productsDataGridView.Width = 350;
            productsDataGridView.Columns["Name"].Width = 200;
            productsDataGridView.Columns["Price"].Width = 100;
        }

        private void categoriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCategorie = categoriesListBox.SelectedItem;

            GetProducts(selectedCategorie, string.Empty);
        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            GetProducts(selectedCategorie, filterTextBox.Text);
        }

        private void productsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            priceTextBox.Text = (productsDataGridView.CurrentRow.Cells["Price"].Value.ToString());
            selectedProductId = productsDataGridView.CurrentRow.Cells["Id"].Value.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
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
    }
}
