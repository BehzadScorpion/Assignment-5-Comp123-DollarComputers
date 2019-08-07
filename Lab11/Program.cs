using DollarComputers.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


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
            productinfoForm = new ProductInfoForm();
            aboutform = new AboutBox();

           


            Application.Run(splashform);
        }
    }
}
