using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class ProductInfoForm : Form
    {
        /// <summary>
        /// This is the constructor for ProductInfoForm
        /// </summary>
        public ProductInfoForm()
        {
            InitializeComponent();
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
    }
}
