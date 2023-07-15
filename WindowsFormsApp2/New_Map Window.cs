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
        DefaultValues DefVal = new DefaultValues();
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

        private void label5_Click(object sender, EventArgs e)
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
        //On Switches for enviromental map  effects
        private void checkBoxHostileAI(object sender, EventArgs e)
        {
            DefaultCheckBoxes("HostileAI");
        }
        private void checkBoxErosion(object sender, EventArgs e)
        {
            DefaultCheckBoxes("Erosion");
        }
        private void checkBoxAvalanche(object sender, EventArgs e)
        {
            DefaultCheckBoxes("Avalanches");
        }
        private void checkBoxAirThreat(object sender, EventArgs e)
        {
            DefaultCheckBoxes("AirThreat");
        }
        private void checkBoxPowerDrain(object sender, EventArgs e)
        {
            DefaultCheckBoxes("PowerDrain");
        }

        //all of the buttons and tabs and things they link too
        //---Enemy Ai
        public void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            DefaultCheckBoxes("DamageToPlayer");
        }
        public void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            DefaultCheckBoxes("DamageFromPlayer");
        }
        public void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            DefaultCheckBoxes("CreatureSpeed");
        }
        public void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            DefaultCheckBoxes("Hunger");
        }
        public void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            DefaultCheckBoxes("SpawnChance");
        }

        //---Erosion
        public void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            DefaultCheckBoxes("ErosionSpeed");
        }
        public void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            DefaultCheckBoxes("RepairCost");
        }

        //---Avalanche
        public void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            DefaultCheckBoxes("AvalancheDamageToPlayer");
        }
        public void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            DefaultCheckBoxes("Frequency");
        }

        //---Air
        public void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            DefaultCheckBoxes("RateOfConsumption");
        }
        public void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            DefaultCheckBoxes("AirQuantity");
        }

        //--Power Drain
        public void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            DefaultCheckBoxes("PowerDrainMultiplyer");
        }

        //Win States
        //--Crystal Collection 
        public void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            DefaultCheckBoxes("CollectCrystals");
        }
        //--Building Requirment
        public void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            DefaultCheckBoxes("BuildSpecificBuilding");
        }
        //--Unit requirement
        public void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            DefaultCheckBoxes("BuildSpecificUnit");
        }
        //--Rescue
        public void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            DefaultCheckBoxes("RescueSpecificUnit");
        }
        //--Reach the tile
        public void checkbox23_CheckedChanged(object sender, EventArgs e)
        {
            DefaultCheckBoxes("SpecificRescueUnit");
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

        private void SetMapName(object sender, EventArgs e)
        {
            Properties.Settings.Default.MapName = MapName.Text;
            Console.WriteLine($"MapName set to: {MapName.Text}");
        }
        public void SetWidth(object sender, EventArgs e)
        {

            //Gets the value of the Width Numerical box, converts its value to an int and changes the application settings to the new value.
            int W = Convert.ToInt32(WidthIn.Value);
            Properties.Settings.Default.Width = W;
            Console.WriteLine($"Width set to: {W}");
        }
        public void SetHeight(object sender, EventArgs e)
        {
            //Gets the value of the Width Numerical box, converts its value to an int and changes the application settings to the new value.
            int H = Convert.ToInt32(HeightIn.Value);
            Properties.Settings.Default.Height = H;
            Console.WriteLine($"Height set to: {H}");
        }
        public void SetTerrainType(object sender, EventArgs e)
        {
            if(TerrainType.Text.Equals("Rock") || TerrainType.Text.Equals("Lava") || TerrainType.Text.Equals("Ice"))
            {
                Properties.Settings.Default.TerrainType = TerrainType.Text;
                Console.WriteLine($"Terrain set to: {TerrainType.Text}");
            }
            else
            {
                Console.WriteLine($"Terrain Type Invalid! defaulting to rock.");
                Properties.Settings.Default.TerrainType = DefVal.TerrainType;
            }
        }
        public void MapNameEnterKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Properties.Settings.Default.MapName = MapName.Text;
                Console.WriteLine($"Height set to: {MapName.Text}");
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        //public void MapSettings(string name, int width , int height, int terrainType, bool hostile)


        public void DefaultCheckBoxes(string DefaultCheckBoxAction)
        {
            switch (DefaultCheckBoxAction)
            {

                case "HostileAI":
                    Debug.WriteLine("Hostile AI On");
                    if (HostileAI.Checked == false)
                    {
                        Properties.Settings.Default.HostileAI = false;
                        tableLayoutPanel3.Enabled = false;
                        tableLayoutPanel3.Invalidate();
                        tableLayoutPanel3.Refresh();
                        Application.DoEvents();
                    }
                    else
                    {
                        tableLayoutPanel3.Enabled = true;
                        Properties.Settings.Default.HostileAI = true;
                    }
                    break;
                case "Erosion":
                    Debug.WriteLine("Erosion On");
                    if (Erosion.Checked == false)
                    {
                        Properties.Settings.Default.Erosion = false;
                        tableLayoutPanel2.Enabled = false;
                        tableLayoutPanel2.Invalidate();
                        tableLayoutPanel2.Refresh();
                        Application.DoEvents();
                    }
                    else
                    {
                        tableLayoutPanel2.Enabled = true;
                        Properties.Settings.Default.Erosion = true;
                    }

                    break;
                case "Avalanches":
                    Debug.WriteLine("Avalanches On");
                    if (Avalanche.Checked == false)
                    {
                        Properties.Settings.Default.Avalanches = false;
                        tableLayoutPanel10.Enabled = false;
                        tableLayoutPanel10.Invalidate();
                        tableLayoutPanel10.Refresh();
                        Application.DoEvents();
                    }
                    else
                    {
                        tableLayoutPanel10.Enabled = true;
                        Properties.Settings.Default.Avalanches = true;
                    }

                    break;
                case "AirThreat":
                    Debug.WriteLine("Air Threat On");
                    if (AirThreat.Checked == false)
                    {
                        Properties.Settings.Default.AirThreat = false;
                        tableLayoutPanel14.Enabled = false;
                        tableLayoutPanel14.Invalidate();
                        tableLayoutPanel14.Refresh();
                        Application.DoEvents();
                    }
                    else
                    {
                        tableLayoutPanel14.Enabled = true;
                        Properties.Settings.Default.AirThreat = true;
                    }

                    break;
                case "PowerDrain":
                    Debug.WriteLine("PowerDrain On");
                    if (PowerDrain.Checked == false)
                    {
                        Properties.Settings.Default.PowerDrain = false;
                        tableLayoutPanel17.Enabled = false;
                        tableLayoutPanel17.Invalidate();
                        tableLayoutPanel17.Refresh();
                        Application.DoEvents();
                    }
                    else
                    {
                        tableLayoutPanel17.Enabled = true;
                        Properties.Settings.Default.PowerDrain = true;
                    }

                    break;
                case "DamageToPlayer":
                    Debug.WriteLine("CustomDamage Checked");
                    if (DefaultPlayerDamage.Checked == true)
                    {
                        CustomDamage.Enabled = false;
                        CustomDamage.Invalidate();
                        CustomDamage.Refresh();
                        Application.DoEvents();
                    }
                    else
                    {
                        CustomDamage.Enabled = true;
                    }
                    break;
                case "DamageFromPlayer":
                    Debug.WriteLine("CustomPlayerDamage Checked");
                    if (DefaultDamageFromPlayer.Checked == true)
                    {
                        CustomPlayerDamage.Enabled = false;
                        CustomPlayerDamage.Invalidate();
                        CustomPlayerDamage.Refresh();
                        Application.DoEvents();
                    }
                    else
                    {
                        CustomDamage.Enabled = true;
                    }
                    break;


                case "CreatureSpeed":
                    Debug.WriteLine("CustomSpeeds Checked");
                    if (DefaultSpeed.Checked == true)
                    {
                        CustomSpeed.Enabled = false;
                        DebrisMultiplier.Enabled = false;

                        CustomSpeed.Invalidate();
                        DebrisMultiplier.Invalidate();

                        CustomSpeed.Refresh();
                        DebrisMultiplier.Refresh();

                        Application.DoEvents();
                    }
                    else
                    {
                        CustomSpeed.Enabled = true;
                        DebrisMultiplier.Enabled = true;
                    }

                    break;
                case "Hunger":
                    Debug.WriteLine("CustomHunger Checked");
                    if (DefaultHunger.Checked == true)
                    {
                        CustomHunger.Enabled = false;
                        CustomHunger.Invalidate();
                        CustomHunger.Refresh();
                        Application.DoEvents();
                    }
                    else
                    {
                        CustomHunger.Enabled = true;
                    }

                    break;
                case "SpawnChance":
                    Debug.WriteLine("CustomSpawnChance Checked");
                    if (SpawnChance.Checked == true)
                    {
                        CustomSpawnChance.Enabled = false;
                        CustomSpawnChance.Invalidate();
                        CustomSpawnChance.Refresh();
                        Application.DoEvents();
                    }
                    else
                    {
                        CustomSpawnChance.Enabled = true;
                    }

                    break;
                case "ErosionSpeed":
                    Debug.WriteLine("CustomErosionSpeed Checked");
                    if (DefaultErosionSpeed.Checked == true)
                    {
                        CustomErosionSpeed.Enabled = false;
                        CustomErosionSpeed.Invalidate();
                        CustomErosionSpeed.Refresh();
                        Application.DoEvents();
                    }
                    else
                    {
                        CustomErosionSpeed.Enabled = true;
                    }

                    break;
                case "RepairCost":
                    Debug.WriteLine("RepairCost Checked");
                    if (DefaultRepairCost.Checked == true)
                    {
                        RepairCost.Enabled = false;
                        RepairCost.Invalidate();
                        RepairCost.Refresh();
                        Application.DoEvents();
                    }
                    else
                    {
                        RepairCost.Enabled = true;
                    }

                    break;
                case "AvalancheDamageToPlayer":
                    Debug.WriteLine("CustomAvalanchDamage Checked");
                    if (defaultAvalancheDamageToPlayers.Checked == true)
                    {
                        CustomAvalanchDamage.Enabled = false;
                        CustomAvalanchDamage.Invalidate();
                        CustomAvalanchDamage.Refresh();
                        Application.DoEvents();
                    }
                    else
                    {
                        CustomAvalanchDamage.Enabled = true;
                    }

                    break;
                case "Frequency":
                    Debug.WriteLine("CustomAvalanchFrequncy Checked");
                    if (DefaultAvalancheFrequency.Checked == true)
                    {
                        CustomAvalanchFrequncy.Enabled = false;
                        CustomAvalanchFrequncy.Invalidate();
                        CustomAvalanchFrequncy.Refresh();
                        Application.DoEvents();
                    }
                    else
                    {
                        CustomAvalanchFrequncy.Enabled = true;
                    }

                    break;
                case "RateOfConsumption":
                    Debug.WriteLine("RateOfConsumption Checked");
                    if (DefaultRateOfConsumption.Checked == true)
                    {
                        RateOfConsumption.Enabled = false;
                        RateOfConsumption.Invalidate();
                        RateOfConsumption.Refresh();
                        Application.DoEvents();
                    }
                    else
                    {
                        RateOfConsumption.Enabled = true;
                    }
                    break;
                case "AirQuantity":
                    Debug.WriteLine("AirQuantity Checked");
                    if (DefaultAirQuantity.Checked == true)
                    {
                        AirQuantity.Enabled = false;
                        AirQuantity.Invalidate();
                        AirQuantity.Refresh();
                        Application.DoEvents();
                    }
                    else
                    {
                        AirQuantity.Enabled = true;
                    }
                    break;
                case "PowerDrainMultiplyer":
                    Debug.WriteLine("PowerDrainMultiplier Checked");
                    if (DefaultPowerDrain.Checked == true)
                    {
                        PowerDrainMultiplier.Enabled = false;
                        PowerDrainMultiplier.Invalidate();
                        PowerDrainMultiplier.Refresh();
                        Application.DoEvents();
                    }
                    else
                    {
                        PowerDrainMultiplier.Enabled = true;
                    }

                    break;
                case "CollectCrystals":
                    Debug.WriteLine("NeededCrystals Checked");
                    if (ActiveCrystalCollection.Checked == true)
                    {
                        NeededCrystals.Enabled = true;
                        NeededCrystals.Invalidate();
                        NeededCrystals.Refresh();
                        Application.DoEvents();
                    }
                    else
                    {
                        NeededCrystals.Enabled = false;
                    }

                    break;
                case "BuildSpecificBuilding":
                    Debug.WriteLine("SpecificBuilding Checked");
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

                    break;
                case "BuildSpecificUnit":
                    Debug.WriteLine("SpecificUnit Checked");
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
                    break;

                case "RescueSpecificUnit":
                    Debug.WriteLine("ActiveRescue Checked");
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

                    break;
                case "TileReach":
                    {
                        Console.WriteLine("Reach the Tile Checked");
                        if (ActiveReachTheTile.Checked == true)
                        {

                            Application.DoEvents();
                        }
                        else
                        {

                        }
                    }
                    break;
            }

        }
    }
}

