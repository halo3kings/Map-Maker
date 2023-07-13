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
     public class View
    {
        public int NumberOfWindows = 0;
        List<String> WindowNameList = new List<String> { "<Name>" };
        Form[] Windows = new Form[64];
        string[] WindowNames = new string[64];

        Default_Window Default_Window = new Default_Window();
        //New_Map New_Map = new New_Map();

        public View()
        {

            Debug.WriteLine("Initializing Windows...");

            /*
            * (1). create new window
            * (2). set new window as the 'Form' for position 0 in the 'Windows' Form Array.
            * (3). populate the 'WindowName' array with their names, starting at pos 0.
            * (4). iterate the global number of frames by one.
            */


            //--------------------------------------------------------

            Windows[NumberOfWindows] = Default_Window;              // (2)
            WindowNames[NumberOfWindows] = "Default_Window";        // (3)
            NumberOfWindows++;                                      // (4)

            //--------------------------------------------------------

           // Windows[NumberOfWindows] = New_Map;                      // (2)
            //WindowNames[NumberOfWindows] = "New_Map";                // (3)
            //NumberOfWindows++;                                       // (4)

            //--------------------------------------------------------

        }

        public Form GetDefaultWindow() 
        { 
            return Default_Window; 
        }

        public void getData()
        {

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
    }
}
