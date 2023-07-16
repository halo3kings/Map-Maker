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
            DefaultCheckBoxes("PowerDrainMultiplier");
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
        // For when enter is pressed while typing a map name.
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
        public void CustomizedValueEnterKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               // UserInput()



                //Properties.Settings.Default.MapName = MapName.Text;
                //Console.WriteLine($"Height set to: {MapName.Text}");
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        //public void MapSettings(string name, int width , int height, int terrainType, bool hostile)


        public void DefaultCheckBoxes(string DefaultCheckBoxAction)
        {
            switch (DefaultCheckBoxAction)
            {
                /*the flow of these cases go as follows:
                 * -->check to see if the Default settings button is checked
                 * -->If Default settings are disabled then:
                 *      >update application settings to reflect that default settings are not being used.
                 *      >Disable respective settings so that the user can not input their own data.
                 *      >Redraw the application
                 *      >Refresh the windows
                 *      >Proccess
                 *      >Output to log that subsequent settings have been updated. 
                 * -->Else
                 *      >Enable respective settings so that the user can input their own data.
                 *      >update application settings to reflect that default settings are being used.
                 *      >Output to log that subsequent settings have been updated.
                */
                case "HostileAI":

                    if (HostileAI.Checked == false)
                    {
                        Properties.Settings.Default.HostileAI = false;
                        tableLayoutPanel3.Enabled = false;
                        tableLayoutPanel3.Invalidate();
                        tableLayoutPanel3.Refresh();
                        Application.DoEvents();
                        Debug.WriteLine("Hostile AI Off");
                    }
                    else
                    {
                        tableLayoutPanel3.Enabled = true;
                        Properties.Settings.Default.HostileAI = true;
                        Debug.WriteLine("Hostile AI On");
                    }
                    break;
                case "Erosion":

                    if (Erosion.Checked == false)
                    {
                        Properties.Settings.Default.Erosion = false;
                        tableLayoutPanel2.Enabled = false;
                        tableLayoutPanel2.Invalidate();
                        tableLayoutPanel2.Refresh();
                        Application.DoEvents();
                        Debug.WriteLine("Erosion Off");
                    }
                    else
                    {
                        tableLayoutPanel2.Enabled = true;
                        Properties.Settings.Default.Erosion = true;
                        Debug.WriteLine("Erosion On");
                    }

                    break;
                case "Avalanches":
                    if (Avalanche.Checked == false)
                    {
                        Properties.Settings.Default.Avalanches = false;
                        tableLayoutPanel10.Enabled = false;
                        tableLayoutPanel10.Invalidate();
                        tableLayoutPanel10.Refresh();
                        Application.DoEvents();
                        Debug.WriteLine("Avalanches Off");
                    }
                    else
                    {
                        tableLayoutPanel10.Enabled = true;
                        Properties.Settings.Default.Avalanches = true;
                        Debug.WriteLine("Avalanches On");
                    }

                    break;
                case "AirThreat":
                    if (AirThreat.Checked == false)
                    {
                        Properties.Settings.Default.AirThreat = false;
                        tableLayoutPanel14.Enabled = false;
                        tableLayoutPanel14.Invalidate();
                        tableLayoutPanel14.Refresh();
                        Application.DoEvents();
                        Debug.WriteLine("Air Threat Off");
                    }
                    else
                    {
                        tableLayoutPanel14.Enabled = true;
                        Properties.Settings.Default.AirThreat = true;
                        Debug.WriteLine("Air Threat On");
                    }

                    break;
                case "PowerDrain":
                    if (PowerDrain.Checked == false)
                    {
                        Properties.Settings.Default.PowerDrain = false;
                        tableLayoutPanel17.Enabled = false;
                        tableLayoutPanel17.Invalidate();
                        tableLayoutPanel17.Refresh();
                        Application.DoEvents();
                        Debug.WriteLine("PowerDrain Off");
                    }
                    else
                    {
                        tableLayoutPanel17.Enabled = true;
                        Properties.Settings.Default.PowerDrain = true;
                        Debug.WriteLine("PowerDrain On");
                    }

                    break;
                case "DamageToPlayer":
                    if (DefaultPlayerDamage.Checked == true)
                    {
                        Properties.Settings.Default.DamageToPlayer = DefVal.DamageToPlayer;
                        CustomDamage.Enabled = false;
                        CustomDamage.Invalidate();
                        CustomDamage.Refresh();
                        Application.DoEvents();
                        Debug.WriteLine("CustomDamage set to Default");
                    }
                    else
                    {
                        CustomDamage.Enabled = true;
                        //Properties.Settings.Default.DamageToPlayer = Convert.ToInt32(CustomDamage.Value);
                        Debug.WriteLine($"CustomDamage Checked. it is now: {Convert.ToInt32(CustomDamage.Value)}");
                    }
                    break;
                case "DamageFromPlayer":
                    if (DefaultDamageFromPlayer.Checked == true)
                    {
                        Properties.Settings.Default.DamageFromPlayer = DefVal.DamageFromPlayer;
                        CustomPlayerDamage.Enabled = false;
                        CustomPlayerDamage.Invalidate();
                        CustomPlayerDamage.Refresh();
                        Application.DoEvents();
                        Debug.WriteLine("CustomPlayerDamage set to Default");
                    }
                    else
                    {
                        CustomPlayerDamage.Enabled = true;
                        //Properties.Settings.Default.DamageFromPlayer = Convert.ToInt32(CustomPlayerDamage.Value);
                        Debug.WriteLine($"CustomDamage Checked. it is now: {Convert.ToInt32(CustomPlayerDamage.Value)}");
                    }
                    break;


                case "CreatureSpeed":
                    if (DefaultSpeed.Checked == true)
                    {
                        Properties.Settings.Default.CreatureSpeed = DefVal.CreatureSpeed;
                        Properties.Settings.Default.DebrisMultiplier = DefVal.Debrismultiplier;
                        CustomSpeed.Enabled = false;
                        DebrisMultiplier.Enabled = false;
                        CustomSpeed.Invalidate();
                        DebrisMultiplier.Invalidate();
                        CustomSpeed.Refresh();
                        DebrisMultiplier.Refresh();
                        Application.DoEvents();
                        Debug.WriteLine("Creature speed set to Default");
                    }
                    else
                    {
                        CustomSpeed.Enabled = true;
                        DebrisMultiplier.Enabled = true;
                        //Properties.Settings.Default.CreatureSpeed = Convert.ToInt32(CustomSpeed.Value);
                        //Properties.Settings.Default.DebrisMultiplier = Convert.ToInt32(DebrisMultiplier.Value);
                        Debug.WriteLine($"CreatureSpeed Checked. it is now: {Convert.ToInt32(CustomSpeed.Value)}");
                        Debug.WriteLine($"DebrisMultiplier Checked. it is now: {Convert.ToInt32(DebrisMultiplier.Value)}");
                    }

                    break;
                case "Hunger":
                    if (DefaultHunger.Checked == true)
                    {
                        Properties.Settings.Default.Hunger = DefVal.Hunger;
                        CustomHunger.Enabled = false;
                        CustomHunger.Invalidate();
                        CustomHunger.Refresh();
                        Application.DoEvents();
                        Debug.WriteLine("Creature Hunger set to Default");

                    }
                    else
                    {
                        CustomHunger.Enabled = true;
                        //Properties.Settings.Default.Hunger = Convert.ToInt32(CustomHunger.Value);
                        Debug.WriteLine($"CustomDamage Checked. it is now: {Convert.ToInt32(CustomHunger.Value)}");
                    }

                    break;
                case "SpawnChance":
                    if (SpawnChance.Checked == true)
                    {
                        Properties.Settings.Default.SpawnChance = DefVal.SpawnChance;
                        CustomSpawnChance.Enabled = false;
                        CustomSpawnChance.Invalidate();
                        CustomSpawnChance.Refresh();
                        Application.DoEvents();
                        Debug.WriteLine("Creature SpawnChance set to Default");
                    }
                    else
                    {
                        CustomSpawnChance.Enabled = true;
                        //Properties.Settings.Default.SpawnChance = Convert.ToInt32(CustomSpawnChance.Value);
                        Debug.WriteLine($"CustomDamage Checked. it is now: {Convert.ToInt32(CustomSpawnChance.Value)}");
                    }

                    break;
                case "ErosionSpeed":
                    if (DefaultErosionSpeed.Checked == true)
                    {
                        Properties.Settings.Default.ErosionSpeed = DefVal.ErosionSpeed;
                        CustomErosionSpeed.Enabled = false;
                        CustomErosionSpeed.Invalidate();
                        CustomErosionSpeed.Refresh();
                        Application.DoEvents();
                        Debug.WriteLine("ErosionSpeed set to Default");
                    }
                    else
                    {
                        CustomErosionSpeed.Enabled = true;
                        //Properties.Settings.Default.ErosionSpeed = Convert.ToInt32(CustomSpawnChance.Value);
                        Debug.WriteLine($"CustomErosionSpeed. Checked it is now: {Convert.ToInt32(CustomSpawnChance.Value)}");
                    }

                    break;
                case "RepairCost":
                    if (DefaultRepairCost.Checked == true)
                    {
                        Properties.Settings.Default.RepairCost = DefVal.RepairCost;
                        RepairCost.Enabled = false;
                        RepairCost.Invalidate();
                        RepairCost.Refresh();
                        Application.DoEvents();
                        Debug.WriteLine("RepairCost set to Default");
                    }
                    else
                    {
                        RepairCost.Enabled = true;
                        //Properties.Settings.Default.RepairCost = Convert.ToInt32(RepairCost);
                        Debug.WriteLine($"RepairCost Checked. it is now: {Convert.ToInt32(RepairCost.Value)}");
                    }

                    break;
                case "AvalancheDamageToPlayer":
                    if (defaultAvalancheDamageToPlayers.Checked == true)
                    {
                        Properties.Settings.Default.AvalancheDamageToPlayer = DefVal.AvalancheDamageToPlayer;
                        CustomAvalanchDamage.Enabled = false;
                        CustomAvalanchDamage.Invalidate();
                        CustomAvalanchDamage.Refresh();
                        Application.DoEvents();
                        Debug.WriteLine("AvalancheDamageToPlayer set to Default");
                    }
                    else
                    {
                        CustomAvalanchDamage.Enabled = true;
                        //Properties.Settings.Default.AvalancheDamageToPlayer = Convert.ToInt32(CustomAvalanchDamage);
                        Debug.WriteLine($"RepairCost Checked. it is now: {Convert.ToInt32(CustomAvalanchDamage.Value)}");
                    }

                    break;
                case "Frequency":
                    Debug.WriteLine("CustomAvalanchFrequncy Checked");
                    if (DefaultAvalancheFrequency.Checked == true)
                    {
                        Properties.Settings.Default.Frequency = DefVal.Frequency;
                        CustomAvalanchFrequncy.Enabled = false;
                        CustomAvalanchFrequncy.Invalidate();
                        CustomAvalanchFrequncy.Refresh();
                        Application.DoEvents();
                        Debug.WriteLine("CustomAvalanchFrequncy set to Default");
                    }
                    else
                    {
                        CustomAvalanchFrequncy.Enabled = true;
                        //Properties.Settings.Default.Frequency = Convert.ToInt32(CustomAvalanchFrequncy);
                        Debug.WriteLine($"Frequency Checked. it is now: {Convert.ToInt32(CustomAvalanchFrequncy.Value)}");
                    }

                    break;
                case "RateOfConsumption":
                    if (DefaultRateOfConsumption.Checked == true)
                    {
                        Properties.Settings.Default.RateOfConsumption = DefVal.RateOfConsumption;
                        RateOfConsumption.Enabled = false;
                        RateOfConsumption.Invalidate();
                        RateOfConsumption.Refresh();
                        Application.DoEvents();
                        Debug.WriteLine("RateOfConsumption set to Default");
                    }
                    else
                    {
                        RateOfConsumption.Enabled = true;
                        //Properties.Settings.Default.RateOfConsumption = Convert.ToInt32(RateOfConsumption);
                        Debug.WriteLine($"RateOfConsumption Checked. it is now: {Convert.ToInt32(RateOfConsumption.Value)}");
                    }
                    break;
                case "AirQuantity":

                    if (DefaultAirQuantity.Checked == true)
                    {
                        Properties.Settings.Default.AirQuantity = DefVal.AirQuantity;
                        AirQuantity.Enabled = false;
                        AirQuantity.Invalidate();
                        AirQuantity.Refresh();
                        Application.DoEvents();
                        Debug.WriteLine("AirQuantity set to Default");
                    }
                    else
                    {
                        AirQuantity.Enabled = true;
                        //Properties.Settings.Default.AirQuantity = Convert.ToInt32(AirQuantity);
                        Debug.WriteLine($"AirQuantity Checked. it is now: {Convert.ToInt32(AirQuantity.Value)}");
                    }
                    break;
                case "PowerDrainMultiplier":

                    if (DefaultPowerDrain.Checked == true)
                    {
                        Properties.Settings.Default.PowerDrainMultiplier = DefVal.PowerDrainMultiplyer;
                        PowerDrainMultiplier.Enabled = false;
                        PowerDrainMultiplier.Invalidate();
                        PowerDrainMultiplier.Refresh();
                        Application.DoEvents();
                        Debug.WriteLine("PowerDrainMultiplier set to Default");
                    }
                    else
                    {
                        PowerDrainMultiplier.Enabled = true;
                        //Properties.Settings.Default.PowerDrainMultiplier = Convert.ToInt32(PowerDrainMultiplier);
                        Debug.WriteLine($"AirQuantity Checked. it is now: {Convert.ToInt32(PowerDrainMultiplier.Value)}");
                    }

                    break;
                case "CollectCrystals":

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
                        Properties.Settings.Default.CollectCrystals = false;
                        Debug.WriteLine($"CollectCrystals Checked. it is now: False");
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
                        Properties.Settings.Default.BuildSpecificBuilding = false;
                        Debug.WriteLine($"BuildSpecificBuilding Checked. it is now: False");
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
                        Properties.Settings.Default.BuildSpecificUnit = false;
                        Debug.WriteLine($"BuildSpecificUnit Checked. it is now: False");
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
                        Properties.Settings.Default.RescueSpecificUnit = false;
                        Debug.WriteLine($"RescueSpecificUnit Checked. it is now: False");
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
                default:
                    Console.WriteLine("---Error_Code_1---");
                    Console.WriteLine($"EC1: ( {DefaultCheckBoxAction} ) is not a recognized 'DefaultCheckBoxes' CaseStatement Fix this You dummy... its probabably spelling");
                    break;

            }

        }
        public void UserInput(string NameOfDesiredVariableToChange)
        {
            switch (NameOfDesiredVariableToChange)
            {
                case "DamageToPlayer":
                    Properties.Settings.Default.DamageToPlayer = Convert.ToInt32(CustomDamage.Value);
                    break;

                case "DamageFromPlayer":
                    Properties.Settings.Default.DamageFromPlayer = Convert.ToInt32(CustomPlayerDamage.Value);
                    break;

                case "CreatureSpeed":
                    Properties.Settings.Default.CreatureSpeed = Convert.ToInt32(CustomSpeed.Value);
                    break;

                case "DebrisMultiplier":
                    Properties.Settings.Default.DebrisMultiplier = Convert.ToInt32(DebrisMultiplier.Value);
                    break;

                case "Hunger":
                    Properties.Settings.Default.Hunger = Convert.ToInt32(CustomHunger.Value);
                    break;

                case "SpawnChance":
                    Properties.Settings.Default.SpawnChance = Convert.ToInt32(CustomSpawnChance.Value);
                    break;

                case "ErosionSpeed":
                    Properties.Settings.Default.ErosionSpeed = Convert.ToInt32(CustomSpawnChance.Value);
                    break;

                case "RepairCost":
                    Properties.Settings.Default.RepairCost = Convert.ToInt32(RepairCost);
                    break;

                case "AvalancheDamageToPlayer":
                    Properties.Settings.Default.AvalancheDamageToPlayer = Convert.ToInt32(CustomAvalanchDamage);
                    break;

                case "Frequency":
                    Properties.Settings.Default.Frequency = Convert.ToInt32(CustomAvalanchFrequncy);
                    break;

                case "RateOfConsumption":
                    Properties.Settings.Default.RateOfConsumption = Convert.ToInt32(RateOfConsumption);
                    break;

                case "AirQuantity":
                    Properties.Settings.Default.AirQuantity = Convert.ToInt32(AirQuantity);
                    break;

                case "PowerDrainMultiplier":
                    Properties.Settings.Default.PowerDrainMultiplier = Convert.ToInt32(PowerDrainMultiplier);
                    break;
                default:
                    Console.WriteLine("---Error_Code_2---");
                    Console.WriteLine($"EC2: ( {NameOfDesiredVariableToChange} ) is not a recognized 'UserInput' CaseStatement Fix this You dummy... its probabably spelling");
                    break;

            }
        }
    }
}

