using Domain.Entities;
using Domain.UnitOfWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo.database_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {

            if (radioButtonAddNewProduct.Checked)
            {
                try
                {
                    Unit.Products.AddItem(new Product { Name = textBoxAddNew.Text });

                    MessageBox.Show("Add new Product: " + textBoxAddNew.Text);
                    textBoxAddNew.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
            else if (radioButtonAddNewCategorie.Checked)
            {
                try
                {
                    Unit.Categories.AddItem(new Category { Name = textBoxAddNew.Text });

                    MessageBox.Show("Add new Product: " + textBoxAddNew.Text);
                    textBoxAddNew.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
        }
    }
}
