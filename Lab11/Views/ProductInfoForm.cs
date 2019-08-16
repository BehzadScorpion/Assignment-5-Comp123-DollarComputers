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
        public TextWriter FileWriter { get; set; }
        public TextReader FileReader { get; set; }
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

        /// <summary>
        /// This is the event handler for the SaveProductButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveProductButton_Click(object sender, EventArgs e)
        {
            WriteFile();
        }

        /// <summary>
        /// This is the event handler for the OpenToolStripMenuItem Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(StreamReader FileReader= new StreamReader(File.Open("Product.txt", FileMode.Open)))
            {
                Program.productInfo.productID = FileReader.ReadLine();
                Program.productInfo.Cost= Convert.ToDouble(FileReader.ReadLine());
                Program.productInfo.Manufacturer= FileReader.ReadLine();
                Program.productInfo.Model= FileReader.ReadLine();
                Program.productInfo.RAM_type= FileReader.ReadLine();
                Program.productInfo.RAM_size= FileReader.ReadLine();
                Program.productInfo.displaytype= FileReader.ReadLine();
                Program.productInfo.screensize= FileReader.ReadLine();
                Program.productInfo.resolution= FileReader.ReadLine();
                Program.productInfo.CPU_Class= FileReader.ReadLine();
                Program.productInfo.CPU_brand= FileReader.ReadLine();
                Program.productInfo.CPU_type=FileReader.ReadLine();
                Program.productInfo.CPU_speed= FileReader.ReadLine();
                Program.productInfo.CPU_number= FileReader.ReadLine();
                Program.productInfo.CPU_number= FileReader.ReadLine();
                Program.productInfo.condition= FileReader.ReadLine();
                Program.productInfo.OS= FileReader.ReadLine();
                Program.productInfo.platform= FileReader.ReadLine();
                Program.productInfo.HDD_size= FileReader.ReadLine();
                Program.productInfo.HDD_speed= FileReader.ReadLine();
                Program.productInfo.GPU_Type=FileReader.ReadLine();
                Program.productInfo.optical_drive= FileReader.ReadLine();
                Program.productInfo.Audio_type= FileReader.ReadLine();
                Program.productInfo.LAN= FileReader.ReadLine();
                Program.productInfo.WIFI=FileReader.ReadLine();
                Program.productInfo.width= FileReader.ReadLine();
                Program.productInfo.height= FileReader.ReadLine();
                Program.productInfo.depth= FileReader.ReadLine();
                Program.productInfo.weight= FileReader.ReadLine();
                Program.productInfo.moust_type= FileReader.ReadLine();
                Program.productInfo.power= FileReader.ReadLine();
                Program.productInfo.webcam=FileReader.ReadLine();

                FileReader.Close();
                FileReader.Dispose();

                //reloading the productInfoForm
                this.Close();
                Program.productinfoForm = new ProductInfoForm();
                Program.productinfoForm.Show();

                //Displaying MessagBox to confirm the file was opened
                MessageBox.Show("File Loaded Successfully", "Loading File...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// This method writes the productInfo object onto the Product.txt file and confirms that the file was saved successfully
        /// </summary>
        private void WriteFile()
        {
            using (StreamWriter FileWriter = new StreamWriter(File.Open("Product.txt", FileMode.Create)))
            {
                FileWriter.WriteLine(Program.productInfo.productID);
                FileWriter.WriteLine(Program.productInfo.Cost);
                FileWriter.WriteLine(Program.productInfo.Manufacturer);
                FileWriter.WriteLine(Program.productInfo.Model);
                FileWriter.WriteLine(Program.productInfo.RAM_type);
                FileWriter.WriteLine(Program.productInfo.RAM_size);
                FileWriter.WriteLine(Program.productInfo.displaytype);
                FileWriter.WriteLine(Program.productInfo.screensize);
                FileWriter.WriteLine(Program.productInfo.resolution);
                FileWriter.WriteLine(Program.productInfo.CPU_Class);
                FileWriter.WriteLine(Program.productInfo.CPU_brand);
                FileWriter.WriteLine(Program.productInfo.CPU_type);
                FileWriter.WriteLine(Program.productInfo.CPU_speed);
                FileWriter.WriteLine(Program.productInfo.CPU_number);
                FileWriter.WriteLine(Program.productInfo.CPU_number);
                FileWriter.WriteLine(Program.productInfo.condition);
                FileWriter.WriteLine(Program.productInfo.OS);
                FileWriter.WriteLine(Program.productInfo.platform);
                FileWriter.WriteLine(Program.productInfo.HDD_size);
                FileWriter.WriteLine(Program.productInfo.HDD_speed);
                FileWriter.WriteLine(Program.productInfo.GPU_Type);
                FileWriter.WriteLine(Program.productInfo.optical_drive);
                FileWriter.WriteLine(Program.productInfo.Audio_type);
                FileWriter.WriteLine(Program.productInfo.LAN);
                FileWriter.WriteLine(Program.productInfo.WIFI);
                FileWriter.WriteLine(Program.productInfo.width);
                FileWriter.WriteLine(Program.productInfo.height);
                FileWriter.WriteLine(Program.productInfo.depth);
                FileWriter.WriteLine(Program.productInfo.weight);
                FileWriter.WriteLine(Program.productInfo.moust_type);
                FileWriter.WriteLine(Program.productInfo.power);
                FileWriter.WriteLine(Program.productInfo.webcam);

                FileWriter.Close();
                FileWriter.Dispose();

                //Displaying MessagBox to confirm the file was saved
                MessageBox.Show( "File saved Successfully", "Saving File...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
    }
}
