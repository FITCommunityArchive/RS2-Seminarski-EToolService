﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EToolService.Model.Models;
using System.IO;
using EToolService.Desktop.Forms.Product;

namespace EToolService.Desktop.UserControls
{
    public partial class ProductCard : UserControl
    {
        private Product _product;
        public ProductCard(Product product)
        {
            InitializeComponent();

            _product = product;

            lblNazivProizvoda.Text = product.ProductName;
            valCondition.Text = product.Condition;
            valPopust.Text = Math.Round((product.Discount * 100), 1).ToString() + "%";
            valPrice.Text = Math.Round(product.Price, 2).ToString() + " KM";
            valID.Text = product.Id.ToString();
            Image image = null;
            try
            {
                using (var ms = new MemoryStream(product.Image))
                {
                    image = Image.FromStream(ms);
                }
            }
            catch(Exception) { }
            picProductImage.Image = image;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var editForm = new frmProductEdit(_product)
            {
                Parent = this
            };
            editForm.Show();
        }

        public void Reload(Product product)
        {
            _product = product;

            lblNazivProizvoda.Text = product.ProductName;
            valCondition.Text = product.Condition;
            valPopust.Text = Math.Round((product.Discount * 100), 1).ToString() + "%";
            valPrice.Text = Math.Round(product.Price, 2).ToString() + " KM";
            valID.Text = product.Id.ToString();
            Image image = null;
            try
            {
                using (var ms = new MemoryStream(product.Image))
                {
                    image = Image.FromStream(ms);
                }
            }
            catch (Exception) { }
            picProductImage.Image = image;
        }
    }
}
