using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    internal class Controller
    {
        Model MODEL;
        View VIEW;
        public Controller() 
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MODEL = new Model();
            VIEW = new View();
            MapLogger ML = new MapLogger();

            Application.Run(VIEW.GetWindow("Default_Window"));
            Application.Run();
            VIEW.GetDefaultWindow().

        }

    }
}
