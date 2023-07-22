/* Copyright (C) 2023 Austin Tyler - All Rights Reserved
 * You may use, distribute and modify this code under the
 * terms of the Attribution-ShareAlike 4.0 International, 
 * 
 * You should have received a copy of the Attribution-ShareAlike 4.0 International with
 * this file. If not, please write to: AustinTyler88@gmail.com
 */

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
        DefaultValues DefVal = new DefaultValues();
        public Default_Window MAINAPP = new Default_Window();
        public New_Map NEWMAP = new New_Map();

        public View()
        {
            //Initialize();
        }
        public void Run()
        {
            Application.Run(MAINAPP);


        }

    }
}
