using DollarComputers.Views;
using DollarComputers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DollarComputers.Controller;
/*
 * 
 * Last Modified: 8/16/2019-4:00AM
*/
namespace DollarComputers
{
    public static class Program
    {
        public static StartForm startform;
        public static SplashForm splashform;
        public static SelectForm selectform;
        public static ProductInfoForm productinfoForm;
        public static OrderForm orderform;
        public static AboutBox aboutform;


        public static Product product;
        public static ProductInfo productInfo;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
           splashform = new SplashForm();
             startform = new StartForm();           
            selectform = new SelectForm();
            orderform = new OrderForm();
            //productinfoForm = new ProductInfoForm();
            aboutform = new AboutBox();

            product = new Product();
            productInfo = new ProductInfo();

            Application.Run(splashform);
        }
    }
}
