using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_2_chapter_13_14_icolon1004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDBDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.productDBDataSet.Product);

            //Method to sort Units on Hand by ascending order
            SortByUnitsOnHand();
        }

        //Method to Sort Units on Hand in ascending order
        private void SortByUnitsOnHand()
        {
            //LINQ
            var result = from product in productDBDataSet.Product
                         orderby product.Units_On_Hand
                         select product;

            //Changes the Gridview
            productDataGridView.DataSource = result.ToList();
        }

        //Method to Display products with the entered product number
        private void GetProductNumber(ProductClass number)
        {
            //Variable user entered
            number.ProductNumber = searchForProductNumberTextBox.Text;

            //LINQ
            var result = from product in productDBDataSet.Product
                         where product.Product_Number == number.ProductNumber
                         select product;

            //Changes the Gridview
            productDataGridView.DataSource = result.ToList();
        }

        //Method to Display products greater than units entered
        private void GreaterThanUnitsOnHand(ProductClass units)
        {
            //Variable user entered
            units.Units = int.Parse(unitsOnHandTextBox.Text);

            //LINQ
            var result = from product in productDBDataSet.Product
                         where product.Units_On_Hand > units.Units
                         select product;

            //Changes the Gridview
            productDataGridView.DataSource = result.ToList();
        }

        //Method to Display products lesser than units entered
        private void LesserThanUnitsOnHand(ProductClass units)
        {
            //Variable user entered
            units.Units = int.Parse(unitsOnHandTextBox.Text);

            //LINQ
            var result = from product in productDBDataSet.Product
                         where product.Units_On_Hand < units.Units
                         select product;

            //Changes the Gridview
            productDataGridView.DataSource = result.ToList();
        }

        //Method to Display Product with discription entered
        private void GetProductDescription(ProductClass description)
        {
            //Variable user entered
            description.ProductDescription = searchForProductDescriptionContainingTextBox.Text;

            //LINQ
            var result = from product in productDBDataSet.Product
                         where product.Description.Contains(description.ProductDescription)
                         select product;

            //Changes the Gridview
            productDataGridView.DataSource = result.ToList();
        }

        //Method to display prices within the range entered
        private void PriceRange(ProductClass price1, ProductClass price2)
        {
            //Variable user entered
            price1.Range = decimal.Parse(lowRangeTextBox.Text);
            price2.Range = decimal.Parse(highRangeTextBox.Text);

            //LINQ
            var result = from product in productDBDataSet.Product
                         where product.Price > price1.Range && product.Price < price2.Range
                         select product;

            //Changes the Gridview
            productDataGridView.DataSource = result.ToList();
        }

        private void searchForProductNumberButton_Click(object sender, EventArgs e)
        {
            //Method to Display Product with number entered
            ProductClass number = new ProductClass();
            GetProductNumber(number);            
        }

        private void searchForProductDescriptionContainingSpecificTextButton_Click(object sender, EventArgs e)
        {
            //Method to Display Product with discription entered
            ProductClass description = new ProductClass();
            GetProductDescription(description);
        }

        private void greaterthanTextBox_Click(object sender, EventArgs e)
        {
            try
            {
                //Method to Display products greater than units entered
                ProductClass units = new ProductClass();
                GreaterThanUnitsOnHand(units);
            }
            catch (Exception ex)
            {
                string message = "You must enter a valid number " + ex.Message;
                MessageBox.Show(message);
            }
        }

        private void lesserThanTextBox_Click(object sender, EventArgs e)
        {
            try
            {
                //Method to Display products lesser than units entered
                ProductClass units = new ProductClass();
                LesserThanUnitsOnHand(units);
            }
            catch (Exception ex)
            {
                string message = "You must enter a valid number " + ex.Message;
                MessageBox.Show(message);
            }
        }

        private void priceRangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Method to display prices within the range entered
                ProductClass price1 = new ProductClass();
                ProductClass price2 = new ProductClass();
                PriceRange(price1, price2);
            }
            catch (Exception ex)
            {
                string message = "You must enter a valid number " + ex.Message;
                MessageBox.Show(message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            SortByUnitsOnHand();
            searchForProductDescriptionContainingSpecificTextButton.Text = "";
            searchForProductDescriptionContainingTextBox.Text = "";
            lowRangeTextBox.Text = "";
            highRangeTextBox.Text = "";
            unitsOnHandTextBox.Text = "";
        }
    }
}
