using DollarComputers.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
    public partial class ProductInfoForm : Form
    {
        public LoadAndSaveMethods loadSave { get; set; }
        /// <summary>
        /// This is the constructor for ProductInfoForm
        /// </summary>
        public ProductInfoForm()
        {
            InitializeComponent();
            loadSave = new LoadAndSaveMethods();
        }

        /// <summary>
        /// This is the event handler for the BackButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.selectform.Show();
            this.Close();
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
        /// This is the load event for the ProductInfoForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
         private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            IDDataLabel.Text = Program.productInfo.productID;
            ConditionDataLabel.Text = Program.productInfo.condition;
            CostDataLabel.Text = "$" + Program.productInfo.Cost.ToString();
            ManufacturerDataLabel.Text = Program.productInfo.Manufacturer;
            ModelDataLabel.Text = Program.productInfo.Model;
            LCDDataLabel.Text = Program.productInfo.screensize;
            PlatFormDataLabel.Text = Program.productInfo.platform;
            OSDataLabel.Text = Program.productInfo.OS;
            RAMDataLabel.Text = Program.productInfo.RAM_size;
            CPUBrandDataLabel.Text = Program.productInfo.CPU_brand;
            CPUTypeDataLabel.Text = Program.productInfo.CPU_type;
            CPUNumberDataLabel.Text = Program.productInfo.CPU_number;
            CPUSpeedDataLabel.Text = Program.productInfo.CPU_speed;
            HDDDataLabel.Text = Program.productInfo.HDD_size;
            GPUDataLabel.Text = Program.productInfo.GPU_Type;
            WebcamDataLabel.Text = Program.productInfo.webcam;
        }

        /// <summary>
        /// This is the event handler for the SaveProductButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveProductButton_Click(object sender, EventArgs e)
        {
            //Edittin SaveFileDialogue
            SaveFileDialog.FileName = "Product.txt";
            SaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            SaveFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            //Opening SaveFileDialogue
            var result = SaveFileDialog.ShowDialog();
            if(result!= DialogResult.Cancel)
            {
                loadSave.WriteFile(SaveFileDialog.FileName);
                //Displaying MessagBox to confirm the file was saved
                MessageBox.Show("File saved Successfully", "Saving File...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
   
        }

        /// <summary>
        /// This is the event handler for the OpenToolStripMenuItem Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Edittin OpenFileDialogue
            OpenFileDialog.FileName = "Product.txt";
            OpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            OpenFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            //Opening OpenFileDialogue
            var result = OpenFileDialog.ShowDialog();
            if(result != DialogResult.Cancel)
            {
                loadSave.ReadFile(OpenFileDialog.FileName);
                //Displaying MessagBox to confirm the file was opened
                MessageBox.Show("File Loaded Successfully", "Loading File...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

           
        }

        /// <summary>
        /// This is the event handler for the NextButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.orderform.Show();
            this.Hide();
        }
    }

        
    
}
