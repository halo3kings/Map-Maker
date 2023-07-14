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
        MapLogger logger = new MapLogger();
        public New_Map()
        {
            Debug.WriteLine("Initialize New_Map");
            InitializeComponent();
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
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
            if (DefaultPlayerDamage.Checked == true)
            {
                Properties.Settings.Default.HostileAi = true;
                textBoxCustomDamage.Enabled = false;
                textBoxCustomDamage.Invalidate();
                textBoxCustomDamage.Refresh();
                Application.DoEvents();
            }
            else
            {
                textBoxCustomDamage.Enabled = true;
            }
        }
        public void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("checkBox7_CheckedChanged");
            if (DefaultDamageFromPlayer.Checked == true)
            {
                textBoxCustomPlayerDamage.Enabled = false;
                textBoxCustomPlayerDamage.Invalidate();
                textBoxCustomPlayerDamage.Refresh();
                Application.DoEvents();
            }
            else
            {
                textBoxCustomPlayerDamage.Enabled = true;
            }
        }
        public void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("checkBox7_CheckedChanged");
            if (DefaultSpeed.Checked == true)
            {
                textBoxCustomSpeed.Enabled = false;
                textBoxDebrisMultiplyer.Enabled = false;

                textBoxCustomSpeed.Invalidate();
                textBoxDebrisMultiplyer.Invalidate();

                textBoxCustomSpeed.Refresh();
                textBoxDebrisMultiplyer.Refresh();

                Application.DoEvents();
            }
            else
            {
                textBoxCustomSpeed.Enabled = true;
                textBoxDebrisMultiplyer.Enabled = true;
            }
        }
        public void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("checkBox10_CheckedChanged");
            if (DefaultHunger.Checked == true)
            {
                textBoxCustomHunger.Enabled = false;
                textBoxCustomHunger.Invalidate();
                textBoxCustomHunger.Refresh();
                Application.DoEvents();
            }
            else
            {
                textBoxCustomHunger.Enabled = true;
            }
        }
        public void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("checkBox11_CheckedChanged");
            if (SpawnChance.Checked == true)
            {
                textBoxCustomSpawnChance.Enabled = false;
                textBoxCustomSpawnChance.Invalidate();
                textBoxCustomSpawnChance.Refresh();
                Application.DoEvents();
            }
            else
            {
                textBoxCustomSpawnChance.Enabled = true;
            }
        }

        //---Erosion
        public void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("checkBox8_CheckedChanged");
            if (DefaultErosionSpeed.Checked == true)
            {
                textBoxCustomErosionSpeed.Enabled = false;
                textBoxCustomErosionSpeed.Invalidate();
                textBoxCustomErosionSpeed.Refresh();
                Application.DoEvents();
            }
            else
            {
                textBoxCustomErosionSpeed.Enabled = true;
            }
        }
        public void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("checkBox8_CheckedChanged");
            if (DefaultRepairCost.Checked == true)
            {
                textBoxRepairCost.Enabled = false;
                textBoxRepairCost.Invalidate();
                textBoxRepairCost.Refresh();
                Application.DoEvents();
            }
            else
            {
                textBoxRepairCost.Enabled = true;
            }
        }

        //---Avalanche
        public void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("checkBox8_CheckedChanged");
            if (defaultAvalancheDamageToPlayers.Checked == true)
            {
                textBoxCustomAvalanchDamage.Enabled = false;
                textBoxCustomAvalanchDamage.Invalidate();
                textBoxCustomAvalanchDamage.Refresh();
                Application.DoEvents();
            }
            else
            {
                textBoxCustomAvalanchDamage.Enabled = true;
            }
        }
        public void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("checkBox8_CheckedChanged");
            if (DefaultAvalancheFrequency.Checked == true)
            {
                textBoxCustomAvalanchFrequncy.Enabled = false;
                textBoxCustomAvalanchFrequncy.Invalidate();
                textBoxCustomAvalanchFrequncy.Refresh();
                Application.DoEvents();
            }
            else
            {
                textBoxCustomAvalanchFrequncy.Enabled = true;
            }
        }

        //---Air
        public void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("checkBox8_CheckedChanged");
            if (DefaultRateOfConsumption.Checked == true)
            {
                textBoxRateOfConsumption.Enabled = false;
                textBoxRateOfConsumption.Invalidate();
                textBoxRateOfConsumption.Refresh();
                Application.DoEvents();
            }
            else
            {
                textBoxRateOfConsumption.Enabled = true;
            }
        }
        public void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("checkBox8_CheckedChanged");
            if (DefaultAirQuantity.Checked == true)
            {
                textBoxAirQuantity.Enabled = false;
                textBoxAirQuantity.Invalidate();
                textBoxAirQuantity.Refresh();
                Application.DoEvents();
            }
            else
            {
                textBoxAirQuantity.Enabled = true;
            }
        }

        //--Power Drain
        public void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("checkBox18_CheckedChanged");
            if (DefaultPowerDrain.Checked == true)
            {
                textBoxPowerDrain.Enabled = false;
                textBoxPowerDrain.Invalidate();
                textBoxPowerDrain.Refresh();
                Application.DoEvents();
            }
            else
            {
                textBoxPowerDrain.Enabled = true;
            }
        }

        //Win States
        //--Crystal Collection 
        public void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("checkBox19_CheckedChanged");
            if (ActiveCrystalCollection.Checked == true)
            {
                comboBoxCrystals.Enabled = true;
                comboBoxCrystals.Invalidate();
                comboBoxCrystals.Refresh();
                Application.DoEvents();
            }
            else
            {
                comboBoxCrystals.Enabled = false;
            }
        }
        //--Building Requirment
        public void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("checkBox20_CheckedChanged");
            if (ActiveSpecificBuilding.Checked == true)
            {
                comboBoxSpecificBuilding.Enabled = true;
                comboBoxSpecificBuilding.Invalidate();
                comboBoxSpecificBuilding.Refresh();
                Application.DoEvents();
            }
            else
            {
                comboBoxSpecificBuilding.Enabled = false;
            }
        }
        //--Unit requirement
        public void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("checkBox20_CheckedChanged");
            if (ActiveSpecificUnit.Checked == true)
            {
                comboBoxSpecificUnit.Enabled = true;
                comboBoxSpecificUnit.Invalidate();
                comboBoxSpecificUnit.Refresh();
                Application.DoEvents();
            }
            else
            {
                comboBoxSpecificUnit.Enabled = false;
            }
        }
        //--Rescue
        public void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("checkBox21_CheckedChanged");
            if (ActiveRescue.Checked == true)
            {
                comboBoxRescueUnit.Enabled = true;
                comboBoxRescueUnit.Invalidate();
                comboBoxRescueUnit.Refresh();
                Application.DoEvents();
            }
            else
            {
                comboBoxRescueUnit.Enabled = false;
            }
        }
        //--Reach the tile
        public void checkbox23_CheckedChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("checkBox21_CheckedChanged");
            if (ActiveReachTheTile.Checked == true)
            {

                Application.DoEvents();
            }
            else
            {

            }
        }

        public void SetMapName()
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

        private void SetMapName(object sender, EventArgs e)
        {
            Properties.Settings.Default.MapName = (string)sender;
        }
        public void SetWidth(object sender, EventArgs e)
        {
            try
            {
                int Width = Int32.Parse((string)sender);
                Properties.Settings.Default.Width = Width;
            }
            catch (FormatException)
            {
                Debug.WriteLine("Error, Invalid input.");

            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //public void MapSettings(string name, int width , int height, int terrainType, bool hostile)

    }
}
