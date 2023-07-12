using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;   

namespace WindowsFormsApp2
{
    internal class View
    {
        public int NumberOfWindows = 0;
        List<String> WindowNameList = new List<String> { "<Name>" };
        Form[] Windows = new Form[64];
        string[] WindowNames = new string[64];

        public View()
        {

            Debug.WriteLine("Initializing Windows...");

            /*
            * (1). create new default window called 'Default_Window' 
            * (2). set 'Default_Window' as the form for position 0 in the 'Windows' Form Array.
            * (3). populate the 'WindowName' array with their names, starting at pos 0.
            * (4). iterate the global number of frames by one.
            */




            //--------------------------------------------------------

            Default_Window Default_Window = new Default_Window();   // (1)
            Windows[NumberOfWindows] = Default_Window;              // (2)
            WindowNames[NumberOfWindows] = "Default_Window";        // (3)
            NumberOfWindows++;                                      // (4)

            //--------------------------------------------------------


        }
        public Form GetWindow(string Name)
        {
            for (int i = 0; 0 <= WindowNames.Length; i++)
            {
                if(Name == WindowNames[i])
                {
                    return Windows[i];
                }
            }


            return null;
        }
        public void NewMapWindowCreated()
        {
            SetVisible(GetWindow("New_MapWindow"));
        }
        public void SetVisible(Form Window)
        {
            Window.Show();
        }
        
    }
}
