using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    internal class Controller
    {
        DefaultValues Default = new DefaultValues();

        public Controller() 
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Default.SetValuesToDefault();
            Default_Window Default_Window = new Default_Window();
            Application.Run(Default_Window);
            Application.Run();

        }

    }
}
