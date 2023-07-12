using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Default_Window : Form
    {
        Form newMapWindow;
        public Default_Window()
        {
            InitializeComponent();
            Form newMapWindow;
        }

        private void QuitButton(object sender, EventArgs e)
        {
            this.Close();
            
        }
        private void New_Map(object sender, EventArgs e)
        {

            newMapWindow = new New_Map();
            newMapWindow.Show();
        }
        public Form getNewMap()
        {
            return newMapWindow;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void ShowNewMapWindow()
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public ToolStripMenuItem getQuit()
        {
            return Quitt;
        }

    }

}
