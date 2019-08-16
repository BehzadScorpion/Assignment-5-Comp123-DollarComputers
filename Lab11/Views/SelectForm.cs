using DollarComputers.Controller;
using DollarComputers.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * 
 * Last Modified: 8/16/2019-4:00AM
*/
namespace DollarComputers.Views
{
    /// <summary>
    /// This is the constructor for SelectForm
    /// </summary>
    public partial class SelectForm : Form
    {
        public int RowIndex { get; set; }
        public DataGridViewRow CurrentRow { get; set; }
        public SelectForm()
        {
            InitializeComponent();  
        }

        /// <summary>
        /// This is the event handler for the CancelButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This is the event handler for the BackButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.startform.Show();
            this.Hide();
        }

        /// <summary>
        /// This is the event handler for the NextButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            StoreTemporarily();
            Program.productinfoForm = new ProductInfoForm();
            Program.productinfoForm.Show();
            this.Hide();
        }

        /// <summary>
        /// This is the event handler for the SelectForm Load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        /// <summary>
        /// The method for loading the products onto the ProductDataGridView
        /// </summary>
        private void LoadProducts()
        {
            using (var db = new DollarComputersContext())
            {
                db.products.Load();
                productBindingSource.DataSource = db.products.Local.ToBindingList();
            }
        }

        /// <summary>
        /// This is the event handler for the  ProductDataGridView SelectionChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            SelectLabel.Text = DataGridViewSelectedItem();
        }

        /// <summary>
        /// This is the method for changing the SelectLabel Text as well as the appropriate properties of the productInfo object
        /// </summary>
        /// <returns></returns>
        private string DataGridViewSelectedItem()
        {
            RowIndex = ProductDataGridView.CurrentCell.RowIndex;
            CurrentRow = ProductDataGridView.Rows[RowIndex];
            string manufacturer = CurrentRow.Cells[2].Value.ToString();
            string model = CurrentRow.Cells[3].Value.ToString();
            double cost = Convert.ToDouble(CurrentRow.Cells[1].Value);
           
            return $"{manufacturer}- Model: {model} - Cost: ${cost}";
        } 
        /// <summary>
        /// This method temporarily stores the selected product's info onto the productInfo object
        /// </summary>
        private void StoreTemporarily()
        {
            Program.productInfo.Cost = Convert.ToDouble(CurrentRow.Cells[1].Value);
            Program.productInfo.Manufacturer = CurrentRow.Cells[2].Value.ToString();
            Program.productInfo.Model = CurrentRow.Cells[3].Value.ToString();
            Program.productInfo.productID= CurrentRow.Cells[0].Value.ToString();
            Program.productInfo.screensize= CurrentRow.Cells[7].Value.ToString();
            Program.productInfo.platform= CurrentRow.Cells[16].Value.ToString();
            Program.productInfo.condition= CurrentRow.Cells[14].Value.ToString();
            Program.productInfo.OS= CurrentRow.Cells[15].Value.ToString();
            Program.productInfo.RAM_size= CurrentRow.Cells[5].Value.ToString();
            Program.productInfo.CPU_brand= CurrentRow.Cells[10].Value.ToString();
            Program.productInfo.CPU_type= CurrentRow.Cells[11].Value.ToString();
            Program.productInfo.CPU_number= CurrentRow.Cells[13].Value.ToString();
            Program.productInfo.CPU_speed= CurrentRow.Cells[12].Value.ToString();
            Program.productInfo.HDD_size= CurrentRow.Cells[17].Value.ToString();
            Program.productInfo.GPU_Type= CurrentRow.Cells[19].Value.ToString();
            Program.productInfo.webcam= CurrentRow.Cells[30].Value.ToString();
        }
        
    }
}
