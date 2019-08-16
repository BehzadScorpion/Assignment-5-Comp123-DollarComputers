using DollarComputers.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DollarComputers.Controller
{
    public class LoadAndSaveMethods
    {
        public TextWriter FileWriter { get; set; }
        public TextReader FileReader { get; set; }
        /// <summary>
        /// This method writes the productInfo object onto the Product.txt file and confirms that the file was saved successfully
        /// </summary>
        public void WriteFile( string fileName)
        {
            using (StreamWriter FileWriter = new StreamWriter(File.Open(fileName, FileMode.Create)))
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
            }
        }
            /// <summary>
            /// This method writes the productInfo object onto the Product.txt file and confirms that the file was saved successfully
            /// </summary>
            public void ReadFile(string fileName)
            {
                using (StreamReader FileReader = new StreamReader(File.Open(fileName, FileMode.Open)))
                {
                    Program.productInfo.productID = FileReader.ReadLine();
                    Program.productInfo.Cost = Convert.ToDouble(FileReader.ReadLine());
                    Program.productInfo.Manufacturer = FileReader.ReadLine();
                    Program.productInfo.Model = FileReader.ReadLine();
                    Program.productInfo.RAM_type = FileReader.ReadLine();
                    Program.productInfo.RAM_size = FileReader.ReadLine();
                    Program.productInfo.displaytype = FileReader.ReadLine();
                    Program.productInfo.screensize = FileReader.ReadLine();
                    Program.productInfo.resolution = FileReader.ReadLine();
                    Program.productInfo.CPU_Class = FileReader.ReadLine();
                    Program.productInfo.CPU_brand = FileReader.ReadLine();
                    Program.productInfo.CPU_type = FileReader.ReadLine();
                    Program.productInfo.CPU_speed = FileReader.ReadLine();
                    Program.productInfo.CPU_number = FileReader.ReadLine();
                    Program.productInfo.CPU_number = FileReader.ReadLine();
                    Program.productInfo.condition = FileReader.ReadLine();
                    Program.productInfo.OS = FileReader.ReadLine();
                    Program.productInfo.platform = FileReader.ReadLine();
                    Program.productInfo.HDD_size = FileReader.ReadLine();
                    Program.productInfo.HDD_speed = FileReader.ReadLine();
                    Program.productInfo.GPU_Type = FileReader.ReadLine();
                    Program.productInfo.optical_drive = FileReader.ReadLine();
                    Program.productInfo.Audio_type = FileReader.ReadLine();
                    Program.productInfo.LAN = FileReader.ReadLine();
                    Program.productInfo.WIFI = FileReader.ReadLine();
                    Program.productInfo.width = FileReader.ReadLine();
                    Program.productInfo.height = FileReader.ReadLine();
                    Program.productInfo.depth = FileReader.ReadLine();
                    Program.productInfo.weight = FileReader.ReadLine();
                    Program.productInfo.moust_type = FileReader.ReadLine();
                    Program.productInfo.power = FileReader.ReadLine();
                    Program.productInfo.webcam = FileReader.ReadLine();

                    FileReader.Close();
                    FileReader.Dispose();

                    //reloading the productInfoForm
                    Program.productinfoForm.Close();
                    Program.productinfoForm = new ProductInfoForm();
                    Program.productinfoForm.Show();


                }
            }
    }
}
