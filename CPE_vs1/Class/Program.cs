using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
namespace CPE_vs1
{
    //static class Program
    //{
    //    /// <summary>
    //    /// The main entry point for the application.
    //    /// </summary>
    //    [STAThread]
    //    static void Main()
    //    {
    //        Application.EnableVisualStyles();
    //        Application.SetCompatibleTextRenderingDefault(false);
    //        DevExpress.Utils.AppearanceObject.DefaultFont = new System.Drawing.Font("Arial Unicode MS", 20f);
    //        Application.Run(new Login());
    //     //   Application.Run(new CPELoan());
    //    }
    //}
    static class Program
    {

        // Form chính cần gọi của chương trình phải đặt là static

        static FormMain frm;

        [STAThread]

        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.Utils.AppearanceObject.DefaultFont = new System.Drawing.Font("Arial Unicode MS", 16f);
            frm = new FormMain();

            SingleInstanceApplication.Run(frm, NewInstanceHandler);

        }

        public static void NewInstanceHandler(object sender, StartupNextInstanceEventArgs e)
        {

            // Kích hoạt cửa sổ của instance đang chạy

            // Bạn có thể thay thế bằng 1 hành động khác

            frm.Activate();

        }

        /// <summary>

        /// Lớp này dùng để gọi chạy form dạng single instance

        /// </summary>

        public class SingleInstanceApplication : WindowsFormsApplicationBase
        {

            private SingleInstanceApplication()
            {

                base.IsSingleInstance = true;

            }

            public static void Run(System.Windows.Forms.Form f, StartupNextInstanceEventHandler startupHandler)
            {

                SingleInstanceApplication app = new SingleInstanceApplication();

                app.MainForm = f;

                app.StartupNextInstance += startupHandler;

                app.Run(Environment.GetCommandLineArgs());

            }

        }

    }
}
