using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Hotcakes.CommerceDTO.v1;
using Hotcakes.CommerceDTO.v1.Catalog;
using Hotcakes.CommerceDTO.v1.Client;

namespace PirosBiros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            apiHivas();
        }

        private static void apiHivas()
        {
            MessageBox.Show("This is an API Sample Program for Hotcakes");

            var url = "http://20.234.113.211:8084/";
            var key = "1-bc670955-f477-441d-8f8c-60cd5d958f8e";

            //if (args.Length > 0)
            //{
            //    foreach (var arg in args)
            //    {
            //        url = args[0];
            //        key = args[1];
            //    }
            //}

            //if (url == string.Empty) url = "http://20.234.113.211:8084/";
            //if (key == string.Empty) key = "1-bc670955-f477-441d-8f8c-60cd5d958f8e";

            var proxy = new Api(url, key);

            var snaps = proxy.ProductOptionsFindAll();

            MessageBox.Show(snaps.ToString());

            if (snaps.Content != null)
            {
                MessageBox.Show("Found " + snaps.Content.Count + " categories");
                MessageBox.Show("-- First 5 --");
                for (var i = 0; i < snaps.Content.Count; i++)
                {
                    //if (i < snaps.Content.Count)
                    //{
                    //    MessageBox.Show(i + ") " + snaps.Content[i].Name);
                    //    var cat = proxy.CategoriesFind(snaps.Content[i].Bvin);
                    //    if (cat.Errors.Count > 0)
                    //    {
                    //        foreach (var err in cat.Errors)
                    //        {
                    //            MessageBox.Show("ERROR: " + err.Code + " " + err.Description);
                    //        }
                    //    }
                    //    else
                    //    {
                    //        MessageBox.Show("By Bvin: " + cat.Content.Name);
                    //    }

                    //    var catslug = proxy.CategoriesFindBySlug(snaps.Content[i].RewriteUrl);
                    //    if (catslug.Errors.Count > 0)
                    //    {
                    //        foreach (var err in catslug.Errors)
                    //        {
                    //            MessageBox.Show("error: " + err.Code + " " + err.Description);
                    //        }
                    //    }
                    //    else
                    //    {
                    //        MessageBox.Show("by slug: " + cat.Content.Name + " | " + cat.Content.Description);
                    //    }
                    //}
                }
            }

            MessageBox.Show("Done - Press a key to continue");
            //Console.ReadKey();
        }
    }
}
