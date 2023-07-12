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
    public partial class New_Map : Form
    {

        public New_Map()
        {
            Debug.WriteLine("Initialize New_Map");
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void New_Map_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void groupBox14_Enter(object sender, EventArgs e)
        {

        }

        //all of the buttons and tabs and things they link too... good luck
        //---Enemy Ai
        public void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("checkBox6_CheckedChanged");
            if (checkBox6.Checked == true)
            {
                textBox4.Visible = false;
                textBox4.Invalidate();
                textBox4.Refresh();
                Application.DoEvents();
            }
            else
            {
                textBox4.Visible = true;
            }
        }
        public void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("checkBox7_CheckedChanged");
            if (checkBox7.Checked == true)
            {
                textBox5.Visible = false;
                textBox5.Invalidate();
                textBox5.Refresh();
                Application.DoEvents();
            }
            else
            {
                textBox5.Visible = true;
            }
        }
        public void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("checkBox7_CheckedChanged");
            if (checkBox9.Checked == true)
            {
                textBox6.Visible = false;
                textBox7.Visible = false;

                textBox6.Invalidate();
                textBox7.Invalidate();

                textBox6.Refresh();
                textBox7.Refresh();

                Application.DoEvents();
            }
            else
            {
                textBox6.Visible = true;
                textBox7.Visible = true;
            }
        }
        public void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("checkBox10_CheckedChanged");
            if (checkBox10.Checked == true)
            {
                textBox9.Visible = false;
                textBox9.Invalidate();
                textBox9.Refresh();
                Application.DoEvents();
            }
            else
            {
                textBox9.Visible = true;
            }
        }
        public void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("checkBox11_CheckedChanged");
            if (checkBox11.Checked == true)
            {
                textBox8.Visible = false;
                textBox8.Invalidate();
                textBox8.Refresh();
                Application.DoEvents();
            }
            else
            {
                textBox8.Visible = true;
            }
        }

        //---Erosion
        public void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("checkBox8_CheckedChanged");
            if (checkBox8.Checked == true)
            {
                textBox10.Visible = false;
                textBox10.Invalidate();
                textBox10.Refresh();
                Application.DoEvents();
            }
            else
            {
                textBox10.Visible = true;
            }
        }
        public void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("checkBox8_CheckedChanged");
            if (checkBox14.Checked == true)
            {
                textBox13.Visible = false;
                textBox13.Invalidate();
                textBox13.Refresh();
                Application.DoEvents();
            }
            else
            {
                textBox13.Visible = true;
            }
        }

        //---Avalanche
        public void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("checkBox8_CheckedChanged");
            if (checkBox12.Checked == true)
            {
                textBox11.Visible = false;
                textBox11.Invalidate();
                textBox11.Refresh();
                Application.DoEvents();
            }
            else
            {
                textBox11.Visible = true;
            }
        }
        public void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("checkBox8_CheckedChanged");
            if (checkBox13.Checked == true)
            {
                textBox12.Visible = false;
                textBox12.Invalidate();
                textBox12.Refresh();
                Application.DoEvents();
            }
            else
            {
                textBox12.Visible = true;
            }
        }

        //---Air
        public void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("checkBox8_CheckedChanged");
            if (checkBox16.Checked == true)
            {
                textBox15.Visible = false;
                textBox15.Invalidate();
                textBox15.Refresh();
                Application.DoEvents();
            }
            else
            {
                textBox15.Visible = true;
            }
        }
        public void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("checkBox8_CheckedChanged");
            if (checkBox15.Checked == true)
            {
                textBox14.Visible = false;
                textBox14.Invalidate();
                textBox14.Refresh();
                Application.DoEvents();
            }
            else
            {
                textBox14.Visible = true;
            }
        }

        //--Power Drain
        public void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("checkBox18_CheckedChanged");
            if (checkBox18.Checked == true)
            {
                textBox17.Visible = false;
                textBox17.Invalidate();
                textBox17.Refresh();
                Application.DoEvents();
            }
            else
            {
                textBox17.Visible = true;
            }
        }

        //Win State
        public void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("checkBox19_CheckedChanged");
            if (checkBox19.Checked == true)
            {
                textBox18.Visible = false;
                textBox18.Invalidate();
                textBox18.Refresh();
                Application.DoEvents();
            }
            else
            {
                textBox18.Visible = true;
            }
        }
        public void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("checkBox17_CheckedChanged");
            if (checkBox17.Checked == true)
            {
                comboBox3.Visible = false;
                comboBox3.Invalidate();
                comboBox3.Refresh();
                Application.DoEvents();
            }
            else
            {
                comboBox3.Visible = true;
            }
        }
        public void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("checkBox20_CheckedChanged");
            if (checkBox17.Checked == true)
            {
                comboBox2.Visible = false;
                comboBox2.Invalidate();
                comboBox2.Refresh();
                Application.DoEvents();
            }
            else
            {
                comboBox2.Visible = true;
            }
        }
        public void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("checkBox21_CheckedChanged");
            if (checkBox21.Checked == true)
            {
                comboBox4.Visible = false;
                comboBox4.Invalidate();
                comboBox4.Refresh();
                Application.DoEvents();
            }
            else
            {
                comboBox4.Visible = true;
            }
        }
        public void checkBox22_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void groupBox3_Enter_1(object sender, EventArgs e)
        {

        }
        private void groupBox15_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox16_Enter(object sender, EventArgs e)
        {

        }
        // Apply Button
        private void button1_Click(object sender, EventArgs e)
        {

        }
        //Save
        private void button2_Click(object sender, EventArgs e)
        {

        }

        public void MapSettings(string name, int width , int height, int terrainType, bool hostile)

    }
}
