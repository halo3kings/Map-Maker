

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

        //---------------------------------------------------------------------------------------------
        //all of the default buttons, tabs and how they effect their respective enabled states. 

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
            DefaultCheckBoxes("SpecificRescueUnit");
        }
        //--Reach the tile
        public void checkbox23_CheckedChanged(object sender, EventArgs e)
        {
            DefaultCheckBoxes("TileReach");
        }
        public void ApplyButton(object sender, EventArgs e)
        {
            ApplySettings();

        }
        public void SaveButton(object sender, EventArgs e)
        {
            ApplySettings();
            this.Close();

        }
        //-----------------------------------------------------------------------------------------------------------------------------
        // The setting of the Custom Values section of  the code

        //set the new map name
        private void SetMapName(object sender, EventArgs e)
        {

            WindowsFormsApp2.Properties.Settings.Default.MapName = MapName.Text;
            Console.WriteLine($"MapName set to: {MapName.Text}");
        }
        //set the new map name
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

        //set the Width
        public void SetWidth(object sender, EventArgs e)
        {

            //Gets the value of the Width Numerical box, converts its value to an int and changes the application settings to the new value.
            Properties.Settings.Default.Width = Convert.ToInt32(WidthIn.Value);
            Console.WriteLine($"Width set to: {Convert.ToInt32(WidthIn.Value)}");
        }

        //set the Height
        public void SetHeight(object sender, EventArgs e)
        {
            //Gets the value of the Width Numerical box, converts its value to an int and changes the application settings to the new value.
            Properties.Settings.Default.Height = Convert.ToInt32(HeightIn.Value);
            Console.WriteLine($"Height set to: {Convert.ToInt32(HeightIn.Value)}");
        }

        //set the new Terrain
        public void SetTerrainType(object sender, EventArgs e)
        {
            if (TerrainType.Text.Equals("Rock") || TerrainType.Text.Equals("Lava") || TerrainType.Text.Equals("Ice"))
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

        //Custom Values for Hostile AI.
        public void CustomValue_DamageToPlayer(object sender, EventArgs e)
        {
            UserInput("DamageToPlayer");
        }
        public void CustomValue_DamageFromPlayer(object sender, EventArgs e)
        {
            UserInput("DamageFromPlayer");
        }
        public void CustomValue_CreatureSpeed(object sender, EventArgs e)
        {
            UserInput("CreatureSpeed");
        }
        public void CustomValue_DebrisMultiplier(object sender, EventArgs e)
        {
            UserInput("DebrisMultiplier");
        }
        public void CustomValue_HungerValue(object sender, EventArgs e)
        {
            UserInput("Hunger");
        }
        public void CustomValue_Spawn(object sender, EventArgs e)
        {
            UserInput("SpawnChance");
        }

        //Erosion values
        public void CustomValue_Erosion(object sender, EventArgs e)
        {
            UserInput("ErosionSpeed");
        }
        public void CustomValue_RepairCost(object sender, EventArgs e)
        {
            UserInput("RepairCost");
        }

        //Avalanche values
        public void CustomValue_AvalancheDamageToPlayer(object sender, EventArgs e)
        {
            UserInput("AvalancheDamageToPlayer");
        }
        public void CustomValue_AvalancheFrequency(object sender, EventArgs e)
        {
            UserInput("Frequency");
        }

        //Air Values 
        public void CustomValue_RateOfConsumption(object sender, EventArgs e)
        {
            UserInput("RateOfConsumption");
        }
        public void CustomValue_AirQuantity(object sender, EventArgs e)
        {
            UserInput("AirQuantity");
        }

        // Power Drain Values
        public void CustomValue_PowerDrainMultiplier(object sender, EventArgs e)
        {
            UserInput("PowerDrainMultiplier");
        }

        //Win condition values 
        public void CustomValue_CrystalsCount(object sender, EventArgs e)
        {
            UserInput("CrystalsCount");
        }
        public void CustomValue_SpecificBuilding(object sender, EventArgs e)
        {
            UserInput("SpecificBuilding");
        }
        public void CustomValue_SpecificUnit(object sender, EventArgs e)
        {
            UserInput("SpecificUnit");
        }
        public void CustomValue_SpecificRescueUnit(object sender, EventArgs e)
        {
            UserInput("SpecificRescueUnit");
        }
        public event EventHandler ButtonClicked;




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
                        Debug.WriteLine("DamageToPlayer set to Default");
                    }
                    else
                    {
                        CustomDamage.Enabled = true;
                        UserInput("DamageToPlayer");
                        Debug.WriteLine($"DamageToPlayer Checked. it is now: {Convert.ToInt32(CustomDamage.Value)}");
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
                        UserInput("DamageFromPlayer");
                        Debug.WriteLine($"CustomPlayerDamage Checked. it is now: {Convert.ToInt32(CustomPlayerDamage.Value)}");
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
                        UserInput("CreatureSpeed");
                        UserInput("DebrisMultiplier");
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
                        UserInput("Hunger");
                        Debug.WriteLine($"Hunger Checked. it is now: {Convert.ToInt32(CustomHunger.Value)}");
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
                        UserInput("SpawnChance");
                        Debug.WriteLine($"SpawnChance Checked. it is now: {Convert.ToInt32(CustomSpawnChance.Value)}");
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
                        UserInput("ErosionSpeed");
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
                        UserInput("RepairCost");
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
                        UserInput("AvalancheDamageToPlayer");
                        Debug.WriteLine($"AvalancheDamageToPlayer Checked. it is now: {Convert.ToInt32(CustomAvalanchDamage.Value)}");
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
                        UserInput("Frequency");
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
                        UserInput("RateOfConsumption");
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
                        UserInput("AirQuantity");
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
                        UserInput("PowerDrainMultiplier");
                        Debug.WriteLine($"AirQuantity Checked. it is now: {Convert.ToInt32(PowerDrainMultiplier.Value)}");
                    }

                    break;
                case "CollectCrystals":

                    if (ActiveCrystalCollection.Checked == true)
                    {
                        NeededCrystals.Enabled = true;
                        UserInput("CrystalsCount");
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
                        UserInput("SpecificBuilding");
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
                        UserInput("SpecificUnit");
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

                case "SpecificRescueUnit":
                    Debug.WriteLine("ActiveRescue Checked");
                    if (ActiveRescue.Checked == true)
                    {
                        comboBoxRescueUnit.Enabled = true;
                        UserInput("SpecificRescueUnit");
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
                    Debug.WriteLine($"DamageToPlayer set to: {Convert.ToInt32(CustomDamage.Value)}");
                    break;

                case "DamageFromPlayer":
                    Properties.Settings.Default.DamageFromPlayer = Convert.ToInt32(CustomPlayerDamage.Value);
                    Debug.WriteLine($"DamageFromPlayer set to: {Convert.ToInt32(CustomPlayerDamage.Value)}");
                    break;

                case "CreatureSpeed":
                    Properties.Settings.Default.CreatureSpeed = Convert.ToInt32(CustomSpeed.Value);
                    Debug.WriteLine($"CreatureSpeed set to: {Convert.ToInt32(CustomSpeed.Value)}");
                    break;

                case "DebrisMultiplier":
                    Properties.Settings.Default.DebrisMultiplier = Convert.ToInt32(DebrisMultiplier.Value);
                    Debug.WriteLine($"DebrisMultiplier set to: {Convert.ToInt32(DebrisMultiplier.Value)}");
                    break;

                case "Hunger":
                    Properties.Settings.Default.Hunger = Convert.ToInt32(CustomHunger.Value);
                    Debug.WriteLine($"Hunger set to: {Convert.ToInt32(CustomHunger.Value)}");
                    break;

                case "SpawnChance":
                    Properties.Settings.Default.SpawnChance = Convert.ToInt32(CustomSpawnChance.Value);
                    Debug.WriteLine($"SpawnChance set to: {Convert.ToInt32(CustomSpawnChance.Value)}");
                    break;

                case "ErosionSpeed":
                    Properties.Settings.Default.ErosionSpeed = Convert.ToInt32(CustomErosionSpeed.Value);
                    Debug.WriteLine($"ErosionSpeed set to: {Convert.ToInt32(CustomErosionSpeed.Value)}");
                    break;

                case "RepairCost":
                    Properties.Settings.Default.RepairCost = Convert.ToInt32(RepairCost.Value);
                    Debug.WriteLine($"RepairCost set to: {Convert.ToInt32(RepairCost.Value)}");
                    break;

                case "AvalancheDamageToPlayer":
                    Properties.Settings.Default.AvalancheDamageToPlayer = Convert.ToInt32(CustomAvalanchDamage.Value);
                    Debug.WriteLine($"AvalancheDamageToPlayer set to: {Convert.ToInt32(CustomAvalanchDamage.Value)}");
                    break;

                case "Frequency":
                    Properties.Settings.Default.Frequency = Convert.ToInt32(CustomAvalanchFrequncy.Value);
                    Debug.WriteLine($"Frequency set to: {Convert.ToInt32(CustomAvalanchFrequncy.Value)}");
                    break;

                case "RateOfConsumption":
                    Properties.Settings.Default.RateOfConsumption = Convert.ToInt32(RateOfConsumption.Value);
                    Debug.WriteLine($"RateOfConsumption set to: {Convert.ToInt32(RateOfConsumption.Value)}");
                    break;

                case "AirQuantity":
                    Properties.Settings.Default.AirQuantity = Convert.ToInt32(AirQuantity.Value);
                    Debug.WriteLine($"AirQuantity set to: {Convert.ToInt32(AirQuantity.Value)}");
                    break;

                case "PowerDrainMultiplier":
                    Properties.Settings.Default.PowerDrainMultiplier = Convert.ToInt32(PowerDrainMultiplier.Value);
                    Debug.WriteLine($"PowerDrainMultiplier set to: {Convert.ToInt32(PowerDrainMultiplier.Value)}");
                    break;

                case "CrystalsCount":
                    Properties.Settings.Default.CrystalsCount = Convert.ToInt32(NeededCrystals.Value);
                    Debug.WriteLine($"CrystalsCount set to: {Convert.ToInt32(NeededCrystals.Value)}");
                    break;

                case "SpecificBuilding":
                    Properties.Settings.Default.SpecificBuilding = comboBoxSpecificBuilding.Text;
                    Debug.WriteLine($"SpecificBuilding set to: {comboBoxSpecificBuilding.Text}");
                    break;

                case "SpecificUnit":
                    Properties.Settings.Default.SpecificUnit = comboBoxSpecificUnit.Text;
                    Debug.WriteLine($"SpecificUnit set to: {comboBoxSpecificUnit.Text}");
                    break;

                case "SpecificRescueUnit":
                    Properties.Settings.Default.SpecificRescueUnit = comboBoxRescueUnit.Text;
                    Debug.WriteLine($"SpecificRescueUnit set to: {comboBoxRescueUnit.Text}");
                    break;

                default:
                    Console.WriteLine("---Error_Code_2---");
                    Console.WriteLine($"EC2: ( {NameOfDesiredVariableToChange} ) is not a recognized 'UserInput' CaseStatement Fix this You dummy... its probabably spelling");
                    break;

            }
        }
        public void ApplySettings()
        {
            //Values from imputable boxes
            Debug.WriteLine("---Saving Values---");
            Debug.WriteLine("-----------------------------------------------------------------------------------Foundations");
            //Foundations.-----------------------------------------------------------
            //Map Name
            Properties.Settings.Default.MapName = MapName.Text;
            Debug.WriteLine($"MapName set to:                   {MapName.Text}");

            //Width
            Properties.Settings.Default.Width = Convert.ToInt32(WidthIn.Value);
            Debug.WriteLine($"Width set to:                     {WidthIn.Value}");

            //Height
            Properties.Settings.Default.Height = Convert.ToInt32(HeightIn.Value);
            Debug.WriteLine($"Height set to:                    {HeightIn.Value}");

            //Terrain Type
            Properties.Settings.Default.TerrainType = TerrainType.Text;
            Debug.WriteLine($"TerrainType set to:               {TerrainType.Text}");

            //Environmental factors----------------------------------------------------
            Debug.WriteLine("-----------------------------------------------------------------------------------Environmental");

            //Hostile AI
            Properties.Settings.Default.HostileAI = HostileAI.Checked;
            Debug.WriteLine($"HostileAI set to:                 {HostileAI.Checked}");

            //Erosion State
            Properties.Settings.Default.Erosion = Erosion.Checked;
            Debug.WriteLine($"Erosion set to:                   {Erosion.Checked}");

            //Avalanche State
            Properties.Settings.Default.Avalanches = Avalanche.Checked;
            Debug.WriteLine($"Avalanches set to:                {Avalanche.Checked}");

            //Air Threat State
            Properties.Settings.Default.AirThreat = AirThreat.Checked;
            Debug.WriteLine($"AirThreat set to:                 {AirThreat.Checked}");

            //Power Drain Sate
            Properties.Settings.Default.PowerDrain = PowerDrain.Checked;
            Debug.WriteLine($"PowerDrain set to:                {PowerDrain.Checked}");


            //Enemy Ai-----------------------------------------------------------------------------------
            Debug.WriteLine("-----------------------------------------------------------------------------------Enemy Ai");

            //Damage to player
            Properties.Settings.Default.DamageToPlayer = Convert.ToInt32(CustomDamage.Value);
            Debug.WriteLine($"DamageToPlayer set to:            {Convert.ToInt32(CustomDamage.Value)}");

            //Damage From Player
            Properties.Settings.Default.DamageFromPlayer = Convert.ToInt32(CustomPlayerDamage.Value);
            Debug.WriteLine($"DamageFromPlayer set to:          {Convert.ToInt32(CustomPlayerDamage.Value)}");

            //Creature Speed
            Properties.Settings.Default.CreatureSpeed = Convert.ToInt32(CustomSpeed.Value);
            Debug.WriteLine($"CreatureSpeed set to:             {Convert.ToInt32(CustomSpeed.Value)}");

            //Debris speed multiplier
            Properties.Settings.Default.DebrisMultiplier = Convert.ToInt32(DebrisMultiplier.Value);
            Debug.WriteLine($"DebrisMultiplier set to:          {Convert.ToInt32(DebrisMultiplier.Value)}");

            //Hunger
            Properties.Settings.Default.Hunger = Convert.ToInt32(CustomHunger.Value);
            Debug.WriteLine($"Hunger set to:                    {Convert.ToInt32(CustomHunger.Value)}");

            //Spawn Chance
            Properties.Settings.Default.SpawnChance = Convert.ToInt32(CustomSpawnChance.Value);
            Debug.WriteLine($"SpawnChance set to:               {Convert.ToInt32(CustomSpawnChance.Value)}");

            //Erosion-----------------------------------------------------------------------------------
            Debug.WriteLine("-----------------------------------------------------------------------------------Erosion");

            //Erosion speed
            Properties.Settings.Default.ErosionSpeed = Convert.ToInt32(CustomErosionSpeed.Value);
            Debug.WriteLine($"ErosionSpeed set to:              {Convert.ToInt32(CustomErosionSpeed.Value)}");

            //Erosion Repair cost
            Properties.Settings.Default.RepairCost = Convert.ToInt32(RepairCost.Value);
            Debug.WriteLine($"RepairCost set to:                {Convert.ToInt32(RepairCost.Value)}");

            //Avalanche-----------------------------------------------------------------------------------
            Debug.WriteLine("-----------------------------------------------------------------------------------Avalanche");

            //Avalanche to player
            Properties.Settings.Default.AvalancheDamageToPlayer = Convert.ToInt32(CustomAvalanchDamage.Value);
            Debug.WriteLine($"AvalancheDamageToPlayer set to:   {Convert.ToInt32(CustomAvalanchDamage.Value)}");

            //Avalanche Frequency
            Properties.Settings.Default.Frequency = Convert.ToInt32(CustomAvalanchFrequncy.Value);
            Debug.WriteLine($"Frequency set to:                 {Convert.ToInt32(CustomAvalanchFrequncy.Value)}");

            //Air-----------------------------------------------------------------------------------
            Debug.WriteLine("-----------------------------------------------------------------------------------Air");

            //Rate of Consumption
            Properties.Settings.Default.RateOfConsumption = Convert.ToInt32(RateOfConsumption.Value);
            Debug.WriteLine($"RateOfConsumption set to:         {Convert.ToInt32(RateOfConsumption.Value)}");

            //Air Quantity
            Properties.Settings.Default.AirQuantity = Convert.ToInt32(AirQuantity.Value);
            Debug.WriteLine($"AirQuantity set to:               {Convert.ToInt32(AirQuantity.Value)}");

            //PowerDrain-----------------------------------------------------------------------------------
            Debug.WriteLine("-----------------------------------------------------------------------------------PowerDrain");

            //Power Drain Multiplier
            Properties.Settings.Default.PowerDrainMultiplier = Convert.ToInt32(PowerDrainMultiplier.Value);
            Debug.WriteLine($"PowerDrainMultiplier set to:      {Convert.ToInt32(PowerDrainMultiplier.Value)}");

            //Winstate-----------------------------------------------------------------------------------
            Debug.WriteLine("-----------------------------------------------------------------------------------Winstate");


            //true or false values on all settings.

            //WinConditions.
            //Collect Crystal State
            Properties.Settings.Default.CollectCrystals = ActiveCrystalCollection.Checked;
            Debug.WriteLine($"CollectCrystals set to:           {ActiveCrystalCollection.Checked}");

            //Build Specific Building State
            Properties.Settings.Default.BuildSpecificBuilding = ActiveSpecificBuilding.Checked;
            Debug.WriteLine($"BuildSpecificBuilding set to:     {ActiveSpecificBuilding.Checked}");

            //Build Specific unit State
            Properties.Settings.Default.BuildSpecificUnit = ActiveSpecificUnit.Checked;
            Debug.WriteLine($"BuildSpecificUnit set to:         {ActiveSpecificUnit.Checked}");

            //Resuce Specific unit State
            Properties.Settings.Default.RescueSpecificUnit = ActiveRescue.Checked;
            Debug.WriteLine($"RescueSpecificUnit set to:        {ActiveRescue.Checked}");

            //Reach the tile State
            Properties.Settings.Default.TileReach = ActiveReachTheTile.Checked;
            Debug.WriteLine($"TileReach set to:                 {ActiveReachTheTile.Checked}");

            //Winstate Values-----------------------------------------------------------------------------------
            Debug.WriteLine("-----------------------------------------------------------------------------------Winstate Values");

            //Energy Crystal
            Properties.Settings.Default.CrystalsCount = Convert.ToInt32(NeededCrystals.Value);
            Debug.WriteLine($"CrystalsCount set to:             {Convert.ToInt32(NeededCrystals.Value)}");

            //build Specific Building
            Properties.Settings.Default.SpecificBuilding = comboBoxSpecificBuilding.Text;
            Debug.WriteLine($"SpecificBuilding set to:          {comboBoxSpecificBuilding.Text}");

            //Build Specific Unit
            Properties.Settings.Default.SpecificUnit = comboBoxSpecificUnit.Text;
            Debug.WriteLine($"SpecificUnit set to:              {comboBoxSpecificUnit.Text}");

            //Rescue Specific Unit
            Properties.Settings.Default.SpecificRescueUnit = comboBoxRescueUnit.Text;
            Debug.WriteLine($"SpecificRescueUnit set to:        {comboBoxRescueUnit.Text}");

            Debug.WriteLine("-----------------------------------------------------------------------------------Values Saved");
            Debug.WriteLine("All Values saved to system settings ✓");

        }
        
        public TableLayoutPanel getPanel()
        {
            return tableLayoutPanel3;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

