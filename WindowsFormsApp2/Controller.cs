/* Copyright (C) 2023 Austin Tyler - All Rights Reserved
 * You may use, distribute and modify this code under the
 * terms of the Attribution-ShareAlike 4.0 International, 
 * 
 * You should have received a copy of the Attribution-ShareAlike 4.0 International with
 * this file. If not, please write to: AustinTyler88@gmail.com
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Configuration;
using System.Reflection;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{

    internal class Controller
    {
        public event EventHandler Button_Clicked;
        public View VIEW = new View();
        public model MODEL = new model();
         
        public Controller() 
        {
            InitializeView();
        }
        public void InitializeView()
        {
            //InitializeNewMapAndMapPopulator();
            InitializeMainAppWindow();
            InitializeNewMap();
            //initalize
            VIEW.Run();
        }

        //-----------------------------------------------------------------MainApp METHODS----------------------------------------------------\\
        public void InitializeMainAppWindow()
        {
            this.VIEW.MAINAPP.Quit.Click += this.ClickOnQuit;
            this.VIEW.MAINAPP.mapToolStripMenuItem.Click += this.File_New_Map;
            this.VIEW.MAINAPP.KeyPress += this.MapZoom;
            this.VIEW.MAINAPP.SelectTool.Click += this.SelectToolClicked;
            this.VIEW.MAINAPP.BoxSelectTool.Click += this.BoxSelectToolClicked;
            this.VIEW.MAINAPP.EraserTool.Click +=  this.EraserToolClicked;
            this.VIEW.MAINAPP.EyeDropperTool.Click += this.EyeDropperToolClicked;
            this.VIEW.MAINAPP.PaintBrush.Click += this.PaintBrushClicked;

        }
        
        //Button Functions.
        //--MainAppWindow.

        //-----------------------------------------------------------------Tool methods-------------------------------------------------------------------
        //select tool
        private void SelectToolClicked(object sender, EventArgs e)
        {
            Debug.WriteLine($"|Controller|  Select Tool Clicked.");
            //Value must be flipped for the toggle to work.
            if (MODEL.SelectToolSelected == true)
            {
                this.VIEW.MAINAPP.SelectTool.BorderStyle = BorderStyle.None;
                MODEL.SelectToolSelected = false;
                Debug.WriteLine($"|Controller|  Select tool set to false.");

            }
            else if (MODEL.SelectToolSelected == false)
            {
                ToolClickEffect("SelectTool");
                this.MODEL.SetTool("SelectTool");
                Debug.WriteLine($"|Controller|  Select tool set to true.");
            }

        }
        //box select tool
        private void BoxSelectToolClicked(object sender, EventArgs e)
        {
            this.VIEW.MAINAPP.BoxSelectTool.BorderStyle = BorderStyle.Fixed3D;
            Debug.WriteLine($"|Controller|  Box Select Tool Clicked.");
            //Value must be flipped for the toggle to work.
            if (MODEL.BoxSelectToolSelected == true)
            {
                this.VIEW.MAINAPP.BoxSelectTool.BorderStyle = BorderStyle.None;
                MODEL.BoxSelectToolSelected = false;
                Debug.WriteLine($"|Controller|  BoxSelect Tool set to  false.");

            }
            else if (MODEL.BoxSelectToolSelected == false)
            {
                ToolClickEffect("BoxSelectTool");
                this.MODEL.SetTool("BoxSelectTool");
                Debug.WriteLine($"|Controller|  BoxSelect tool set to  true.");
            }
        }
        //eye dropper tool
        private void EyeDropperToolClicked(object sender, EventArgs e)
        {
            this.VIEW.MAINAPP.EyeDropperTool.BorderStyle = BorderStyle.Fixed3D;
            Debug.WriteLine($"|Controller|  EyeDroper Tool Clicked.");
            //Value must be flipped for the toggle to work.
            if (MODEL.EyeDropperToolSelected == true)
            {
                this.VIEW.MAINAPP.EyeDropperTool.BorderStyle = BorderStyle.None;
                MODEL.EyeDropperToolSelected = false;
                Debug.WriteLine($"|Controller|  EyeDropper tool set to  false.");

            }
            else if (MODEL.EyeDropperToolSelected == false)
            {
                ToolClickEffect("EyeDropperTool");
                this.MODEL.SetTool("EyeDropperTool");
                Debug.WriteLine($"|Controller|  EyeDropper Tool tool set to  true.");
            }
        }
        //  Paint brush tool 
        private void PaintBrushClicked(object sender, EventArgs e)
        {
            this.VIEW.MAINAPP.PaintBrush.BorderStyle = BorderStyle.Fixed3D;
            Debug.WriteLine($"|Controller|  PaintBrush Tool Clicked.");
            //Value must be flipped for the toggle to work.
            if (MODEL.PaintBrushSleceted == true)
            {
                this.VIEW.MAINAPP.PaintBrush.BorderStyle = BorderStyle.None;
                MODEL.PaintBrushSleceted = false;
                Debug.WriteLine($"|Controller|  PaintBrush tool set to  false.");

            }
            else if (MODEL.PaintBrushSleceted == false)
            {
                ToolClickEffect("PaintBrush");
                this.MODEL.SetTool("PaintBrush");
                Debug.WriteLine($"|Controller|  PaintBrush tool set to  true.");
            }
        }
        //eraser tool
        private void EraserToolClicked(object sender, EventArgs e)
        {
            this.VIEW.MAINAPP.EraserTool.BorderStyle = BorderStyle.Fixed3D;
            Debug.WriteLine($"|Controller|  Eraser Tool Clicked.");
            //Value must be flipped for the toggle to work.
            if (MODEL.EraserToolSelected == true)
            {
                this.VIEW.MAINAPP.EraserTool.BorderStyle = BorderStyle.None;
                MODEL.EraserToolSelected = false;
                Debug.WriteLine($"|Controller|  Eraser Tool set to  false.");

            }
            else if (MODEL.EraserToolSelected == false)
            {
                ToolClickEffect("EraserTool");
                this.MODEL.SetTool("EraserTool");
                Debug.WriteLine($"|Controller|  Eraser Tool set to  true.");
            }
        }
        //  a one stop shop to change  the border for  the tool icon. 
        public void ToolClickEffect(string Tool)
        {
            switch (Tool)
            {
                case "SelectTool":
                    {
                        Debug.WriteLine($"|Controller|  SelectTool selected.");
                        this.VIEW.MAINAPP.SelectTool.BorderStyle = BorderStyle.Fixed3D;
                        this.VIEW.MAINAPP.EraserTool.BorderStyle = BorderStyle.None;
                        this.VIEW.MAINAPP.PaintBrush.BorderStyle = BorderStyle.None;
                        this.VIEW.MAINAPP.EyeDropperTool.BorderStyle = BorderStyle.None;
                        this.VIEW.MAINAPP.BoxSelectTool.BorderStyle = BorderStyle.None;
                    }
                    break;
                case "BoxSelectTool":
                    {
                        Debug.WriteLine($"|Controller|  BoxSelectTool selected.");
                        this.VIEW.MAINAPP.SelectTool.BorderStyle = BorderStyle.None;
                        this.VIEW.MAINAPP.EraserTool.BorderStyle = BorderStyle.None;
                        this.VIEW.MAINAPP.PaintBrush.BorderStyle = BorderStyle.None;
                        this.VIEW.MAINAPP.EyeDropperTool.BorderStyle = BorderStyle.None;
                        this.VIEW.MAINAPP.BoxSelectTool.BorderStyle = BorderStyle.Fixed3D;

                    }
                    break;
                case "EyeDropperTool":
                    {
                        Debug.WriteLine($"|Controller|  EyeDropperTool selected.");
                        this.VIEW.MAINAPP.SelectTool.BorderStyle = BorderStyle.None;
                        this.VIEW.MAINAPP.EraserTool.BorderStyle = BorderStyle.None;
                        this.VIEW.MAINAPP.PaintBrush.BorderStyle = BorderStyle.None;
                        this.VIEW.MAINAPP.EyeDropperTool.BorderStyle = BorderStyle.Fixed3D;
                        this.VIEW.MAINAPP.BoxSelectTool.BorderStyle = BorderStyle.None;
                    }
                    break;
                case "EraserTool":
                    {
                        Debug.WriteLine($"|Controller|  EraserTool selected.");
                        this.VIEW.MAINAPP.SelectTool.BorderStyle = BorderStyle.None;
                        this.VIEW.MAINAPP.EraserTool.BorderStyle = BorderStyle.Fixed3D;
                        this.VIEW.MAINAPP.PaintBrush.BorderStyle = BorderStyle.None;
                        this.VIEW.MAINAPP.EyeDropperTool.BorderStyle = BorderStyle.None;
                        this.VIEW.MAINAPP.BoxSelectTool.BorderStyle = BorderStyle.None;
                    }
                    break;
                case "PaintBrush":
                    {
                        Debug.WriteLine($"|Controller|  PaintBrush selected.");
                        this.VIEW.MAINAPP.SelectTool.BorderStyle = BorderStyle.None;
                        this.VIEW.MAINAPP.EraserTool.BorderStyle = BorderStyle.None;
                        this.VIEW.MAINAPP.PaintBrush.BorderStyle = BorderStyle.Fixed3D;
                        this.VIEW.MAINAPP.EyeDropperTool.BorderStyle = BorderStyle.None;
                        this.VIEW.MAINAPP.BoxSelectTool.BorderStyle = BorderStyle.None;
                    }
                    break;
            }
        }
        //----------------------------------------------------------------End of Tool Methoods-----------------------------------------------------------------------
        // close the application when the quit menu option is pressed.
        private void ClickOnQuit(object sender, EventArgs e)
        {
            VIEW.MAINAPP.Close();
            Debug.WriteLine($"|Controller|  Closing Application.");
            Application.Exit();
        }

        //show the new map window
        private void File_New_Map(object sender, EventArgs e)
        {
            VIEW.NEWMAP.Show();
        }

        // Zoom Controls
        private void MapZoom(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'e')
            {
                Debug.WriteLine($"|Controller|  Mouse scroll in: ");
                this.VIEW.MAINAPP.Map.AutoScroll = false;
                this.VIEW.MAP.CustomResizeMap(this.VIEW.MAP.getSize() + 32);
                this.VIEW.MAINAPP.Map.Location = new System.Drawing.Point(0, 0);
                this.VIEW.MAINAPP.Map.AutoScroll = true;

            }
            else if (e.KeyChar == 'q')
            {
                Debug.WriteLine($"|Controller|    Mouse scroll out: ");
                this.VIEW.MAINAPP.Map.AutoScroll = false;
                this.VIEW.MAP.CustomResizeMap(this.VIEW.MAP.getSize() - 32);
                this.VIEW.MAINAPP.Map.Location = new System.Drawing.Point(0, 0);
                this.VIEW.MAINAPP.Map.AutoScroll = true;
            }

        }
        public void TileClicked(object sender, EventArgs e)
        {
            bool Run = true;
            int H = 0;
            int w = 0;
            int h = 0;
            while (H < MODEL.Height && Run == true)
            {

                for (int W = 0; W < MODEL.Width; W++)
                {
                    if(this.VIEW.MAP.TILE[W, H].clicked == true)
                    {
                        w = W;
                        h = H;
                        Run = false;
                    }
                    
                }
            }
            // depending on  the tool, do x action to tile w,h. 
            switch (w)// replace 'w' with tool that is enabled.
            {
                case 0:
                    {

                    }
                    break;
            }
        }
        // when the save 
        public void CreateMap()
        {
            this.VIEW.CreateMap(MODEL.Width, MODEL.Height);
            Debug.WriteLine($"|Controller|    Map created, initializing tile click actions.");
            initializeTileClickAction();
            
        }
        // this sets  the tile clicked action within the view>map>Tile[]. Tile object
        public void initializeTileClickAction()
        {
            Debug.WriteLine($"|Controller|    Initializing tile click..");
            int H = 0;
            while (H < MODEL.Height)
            {
                
                for (int W = 0; W < MODEL.Width; W++)
                {
                    this.VIEW.MAP.TILE[W, H].TILE.Click += this.TileClicked;
                    Debug.WriteLine($"|Controller|    Initializing tile click action for tile: {W},{H}");
                }
                H++;
            }
        }
      


        //----------------------------------------------------------------END OF DEFAULT WINDOW METHODS---------------------------------------------\\

        //-----------------------------------------------------------------NEW MAP METHODS----------------------------------------------------------\\
        
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
        //Apply Button
        public void ApplyButton(object sender, EventArgs e)
        {
            ApplySettings();

        }
        //Save  Button
        public void SaveButton(object sender, EventArgs e)
        {
            ApplySettings();
            VIEW.NEWMAP.Close();
            CreateMap();


        }
        //set the new map name
        private void SetMapName(object sender, EventArgs e)
        {

            MODEL.MapName = VIEW.NEWMAP.MapName.Text;
            Console.WriteLine($"|Controller|    MapName set to: {VIEW.NEWMAP.MapName.Text}");
        }
        //set the new map name
        // For when enter is pressed while typing a map name.
        public void MapNameEnterKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MODEL.MapName = VIEW.NEWMAP.MapName.Text;
                Console.WriteLine($"|Controller|    Height set to: {VIEW.NEWMAP.MapName.Text}");
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        //set the Width
        public void SetWidth(object sender, EventArgs e)
        {

            //Gets the value of the Width Numerical box, converts its value to an int and changes the application settings to the new value.
            MODEL.Width = Convert.ToInt32(VIEW.NEWMAP.WidthIn.Value);
            Console.WriteLine($"|Controller|    Width set to: {Convert.ToInt32(VIEW.NEWMAP.WidthIn.Value)}");
        }

        //set the Height
        public void SetHeight(object sender, EventArgs e)
        {
            //Gets the value of the Width Numerical box, converts its value to an int and changes the application settings to the new value.
            MODEL.Height = Convert.ToInt32(VIEW.NEWMAP.HeightIn.Value);
            Console.WriteLine($"|Controller|    Height set to: {Convert.ToInt32(VIEW.NEWMAP.HeightIn.Value)}");
        }

        //set the new Terrain
        public void SetTerrainType(object sender, EventArgs e)
        {
            if (VIEW.NEWMAP.TerrainType.Text.Equals("Rock") || VIEW.NEWMAP.TerrainType.Text.Equals("Lava") || VIEW.NEWMAP.TerrainType.Text.Equals("Ice"))
            {
                MODEL.TerrainType = VIEW.NEWMAP.TerrainType.Text;
                Console.WriteLine($"|Controller|    Terrain set to: {VIEW.NEWMAP.TerrainType.Text}");
            }
            else
            {
                Console.WriteLine($"|Controller|    Terrain Type Invalid! defaulting to rock.");
                //MODEL.TerrainType = this.MODEL.TerrainType;
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

                    if (VIEW.NEWMAP.HostileAI.Checked == false)
                    {
                        MODEL.HostileAI = false;
                        VIEW.NEWMAP.tableLayoutPanel3.Enabled = false;
                        VIEW.NEWMAP.tableLayoutPanel3.Invalidate();
                        VIEW.NEWMAP.tableLayoutPanel3.Refresh();
                        Application.DoEvents();
                        Debug.WriteLine($"|Controller|  Hostile AI Off");
                    }
                    else
                    {
                        VIEW.NEWMAP.tableLayoutPanel3.Enabled = true;
                        MODEL.HostileAI = true;
                        Debug.WriteLine($"|Controller|  Hostile AI On");
                    }
                    break;
                case "Erosion":

                    if (VIEW.NEWMAP.Erosion.Checked == false)
                    {
                        MODEL.Erosion = false;
                        VIEW.NEWMAP.tableLayoutPanel2.Enabled = false;
                        VIEW.NEWMAP.tableLayoutPanel2.Invalidate();
                        VIEW.NEWMAP.tableLayoutPanel2.Refresh();
                        Application.DoEvents();
                        Debug.WriteLine($"|Controller|  Erosion Off");
                    }
                    else
                    {
                        VIEW.NEWMAP.tableLayoutPanel2.Enabled = true;
                        MODEL.Erosion = true;
                        Debug.WriteLine($"|Controller|  Erosion On");
                    }

                    break;
                case "Avalanches":
                    if (VIEW.NEWMAP.Avalanche.Checked == false)
                    {
                        MODEL.Avalanches = false;
                        VIEW.NEWMAP.tableLayoutPanel10.Enabled = false;
                        VIEW.NEWMAP.tableLayoutPanel10.Invalidate();
                        VIEW.NEWMAP.tableLayoutPanel10.Refresh();
                        Application.DoEvents();
                        Debug.WriteLine($"|Controller|  Avalanches Off");
                    }
                    else
                    {
                        VIEW.NEWMAP.tableLayoutPanel10.Enabled = true;
                        MODEL.Avalanches = true;
                        Debug.WriteLine($"|Controller|  Avalanches On");
                    }

                    break;
                case "AirThreat":
                    if (VIEW.NEWMAP.AirThreat.Checked == false)
                    {
                        MODEL.AirThreat = false;
                        VIEW.NEWMAP.tableLayoutPanel14.Enabled = false;
                        VIEW.NEWMAP.tableLayoutPanel14.Invalidate();
                        VIEW.NEWMAP.tableLayoutPanel14.Refresh();
                        Application.DoEvents();
                        Debug.WriteLine($"|Controller|  Air Threat Off");
                    }
                    else
                    {
                        VIEW.NEWMAP.tableLayoutPanel14.Enabled = true;
                        MODEL.AirThreat = true;
                        Debug.WriteLine($"|Controller|  Air Threat On");
                    }

                    break;
                case "PowerDrain":
                    if (VIEW.NEWMAP.PowerDrain.Checked == false)
                    {
                        MODEL.PowerDrain = false;
                        VIEW.NEWMAP.tableLayoutPanel17.Enabled = false;
                        VIEW.NEWMAP.tableLayoutPanel17.Invalidate();
                        VIEW.NEWMAP.tableLayoutPanel17.Refresh();
                        Application.DoEvents();
                        Debug.WriteLine($"|Controller|  PowerDrain Off");
                    }
                    else
                    {
                        VIEW.NEWMAP.tableLayoutPanel17.Enabled = true;
                        MODEL.PowerDrain = true;
                        Debug.WriteLine($"|Controller|  PowerDrain On");
                    }

                    break;
                case "DamageToPlayer":
                    if (VIEW.NEWMAP.DefaultPlayerDamage.Checked == true)
                    {
                        //MODEL.DamageToPlayer = MODEL.DamageToPlayer;
                        VIEW.NEWMAP.CustomDamage.Enabled = false;
                        VIEW.NEWMAP.CustomDamage.Invalidate();
                        VIEW.NEWMAP.CustomDamage.Refresh();
                        Application.DoEvents();
                        Debug.WriteLine($"|Controller|  DamageToPlayer set to Default");
                    }
                    else
                    {
                        VIEW.NEWMAP.CustomDamage.Enabled = true;
                        VIEW.NEWMAP.UserInput("DamageToPlayer");
                        Debug.WriteLine($"|Controller|    DamageToPlayer Checked. it is now: {Convert.ToInt32(VIEW.NEWMAP.CustomDamage.Value)}");
                    }
                    break;
                case "DamageFromPlayer":
                    if (VIEW.NEWMAP.DefaultDamageFromPlayer.Checked == true)
                    {
                        //MODEL.DamageFromPlayer = MODEL.DamageFromPlayer;
                        VIEW.NEWMAP.CustomPlayerDamage.Enabled = false;
                        VIEW.NEWMAP.CustomPlayerDamage.Invalidate();
                        VIEW.NEWMAP.CustomPlayerDamage.Refresh();
                        Application.DoEvents();
                        Debug.WriteLine($"|Controller|  CustomPlayerDamage set to Default");
                    }
                    else
                    {
                        VIEW.NEWMAP.CustomPlayerDamage.Enabled = true;
                        VIEW.NEWMAP.UserInput("DamageFromPlayer");
                        Debug.WriteLine($"|Controller|    CustomPlayerDamage Checked. it is now: {Convert.ToInt32(VIEW.NEWMAP.CustomPlayerDamage.Value)}");
                    }
                    break;


                case "CreatureSpeed":
                    if (VIEW.NEWMAP.DefaultSpeed.Checked == true)
                    {
                        //MODEL.CreatureSpeed = MODEL.CreatureSpeed;
                        //MODEL.Debrismultiplier = MODEL.Debrismultiplier;
                        VIEW.NEWMAP.CustomSpeed.Enabled = false;
                        VIEW.NEWMAP.DebrisMultiplier.Enabled = false;
                        VIEW.NEWMAP.CustomSpeed.Invalidate();
                        VIEW.NEWMAP.DebrisMultiplier.Invalidate();
                        VIEW.NEWMAP.CustomSpeed.Refresh();
                        VIEW.NEWMAP.DebrisMultiplier.Refresh();
                        Application.DoEvents();
                        Debug.WriteLine($"|Controller|  Creature speed set to Default");
                    }
                    else
                    {
                        VIEW.NEWMAP.CustomSpeed.Enabled = true;
                        VIEW.NEWMAP.DebrisMultiplier.Enabled = true;
                        VIEW.NEWMAP.UserInput("CreatureSpeed");
                        VIEW.NEWMAP.UserInput("DebrisMultiplier");
                        Debug.WriteLine($"|Controller|    CreatureSpeed Checked. it is now: {Convert.ToInt32(VIEW.NEWMAP.CustomSpeed.Value)}");
                        Debug.WriteLine($"|Controller|    DebrisMultiplier Checked. it is now: {Convert.ToInt32(VIEW.NEWMAP.DebrisMultiplier.Value)}");
                    }

                    break;
                case "Hunger":
                    if (VIEW.NEWMAP.DefaultHunger.Checked == true)
                    {
                        //MODEL.Hunger = MODEL.Hunger;
                        VIEW.NEWMAP.CustomHunger.Enabled = false;
                        VIEW.NEWMAP.CustomHunger.Invalidate();
                        VIEW.NEWMAP.CustomHunger.Refresh();
                        Application.DoEvents();
                        Debug.WriteLine($"|Controller|  Creature Hunger set to Default");

                    }
                    else
                    {
                        VIEW.NEWMAP.CustomHunger.Enabled = true;
                        VIEW.NEWMAP.UserInput("Hunger");
                        Debug.WriteLine($"|Controller|    Hunger Checked. it is now: {Convert.ToInt32(VIEW.NEWMAP.CustomHunger.Value)}");
                    }

                    break;
                case "SpawnChance":
                    if (VIEW.NEWMAP.SpawnChance.Checked == true)
                    {
                        //MODEL.SpawnChance = MODEL.SpawnChance;
                        VIEW.NEWMAP.CustomSpawnChance.Enabled = false;
                        VIEW.NEWMAP.CustomSpawnChance.Invalidate();
                        VIEW.NEWMAP.CustomSpawnChance.Refresh();
                        Application.DoEvents();
                        Debug.WriteLine($"|Controller|  Creature SpawnChance set to Default");
                    }
                    else
                    {
                        VIEW.NEWMAP.CustomSpawnChance.Enabled = true;
                        VIEW.NEWMAP.UserInput("SpawnChance");
                        Debug.WriteLine($"|Controller|    SpawnChance Checked. it is now: {Convert.ToInt32(VIEW.NEWMAP.CustomSpawnChance.Value)}");
                    }

                    break;
                case "ErosionSpeed":
                    if (VIEW.NEWMAP.DefaultErosionSpeed.Checked == true)
                    {
                        //MODEL.ErosionSpeed = MODEL.ErosionSpeed;
                        VIEW.NEWMAP.CustomErosionSpeed.Enabled = false;
                        VIEW.NEWMAP.CustomErosionSpeed.Invalidate();
                        VIEW.NEWMAP.CustomErosionSpeed.Refresh();
                        Application.DoEvents();
                        Debug.WriteLine($"|Controller|  ErosionSpeed set to Default");
                    }
                    else
                    {
                        VIEW.NEWMAP.CustomErosionSpeed.Enabled = true;
                        VIEW.NEWMAP.UserInput("ErosionSpeed");
                        Debug.WriteLine($"|Controller|    CustomErosionSpeed. Checked it is now: {Convert.ToInt32(VIEW.NEWMAP.CustomSpawnChance.Value)}");
                    }

                    break;
                case "RepairCost":
                    if (VIEW.NEWMAP.DefaultRepairCost.Checked == true)
                    {
                        //MODEL.RepairCost = MODEL.RepairCost;
                        VIEW.NEWMAP.RepairCost.Enabled = false;
                        VIEW.NEWMAP.RepairCost.Invalidate();
                        VIEW.NEWMAP.RepairCost.Refresh();
                        Application.DoEvents();
                        Debug.WriteLine($"|Controller|  RepairCost set to Default");
                    }
                    else
                    {
                        VIEW.NEWMAP.RepairCost.Enabled = true;
                        VIEW.NEWMAP.UserInput("RepairCost");
                        Debug.WriteLine($"|Controller|    RepairCost Checked. it is now: {Convert.ToInt32(VIEW.NEWMAP.RepairCost.Value)}");
                    }

                    break;
                case "AvalancheDamageToPlayer":
                    if (VIEW.NEWMAP.defaultAvalancheDamageToPlayers.Checked == true)
                    {
                        //MODEL.AvalancheDamageToPlayer = MODEL.AvalancheDamageToPlayer;
                        VIEW.NEWMAP.CustomAvalanchDamage.Enabled = false;
                        VIEW.NEWMAP.CustomAvalanchDamage.Invalidate();
                        VIEW.NEWMAP.CustomAvalanchDamage.Refresh();
                        Application.DoEvents();
                        Debug.WriteLine($"|Controller|  AvalancheDamageToPlayer set to Default");
                    }
                    else
                    {
                        VIEW.NEWMAP.CustomAvalanchDamage.Enabled = true;
                        VIEW.NEWMAP.UserInput("AvalancheDamageToPlayer");
                        Debug.WriteLine($"|Controller|    AvalancheDamageToPlayer Checked. it is now: {Convert.ToInt32(VIEW.NEWMAP.CustomAvalanchDamage.Value)}");
                    }

                    break;
                case "Frequency":
                    Debug.WriteLine($"|Controller|  CustomAvalanchFrequncy Checked");
                    if (VIEW.NEWMAP.DefaultAvalancheFrequency.Checked == true)
                    {
                        //MODEL.Frequency = MODEL.Frequency;
                        VIEW.NEWMAP.CustomAvalanchFrequncy.Enabled = false;
                        VIEW.NEWMAP.CustomAvalanchFrequncy.Invalidate();
                        VIEW.NEWMAP.CustomAvalanchFrequncy.Refresh();
                        Application.DoEvents();
                        Debug.WriteLine($"|Controller|  CustomAvalanchFrequncy set to Default");
                    }
                    else
                    {
                        VIEW.NEWMAP.CustomAvalanchFrequncy.Enabled = true;
                        VIEW.NEWMAP.UserInput("Frequency");
                        Debug.WriteLine($"|Controller|  Frequency Checked. it is now: {Convert.ToInt32(VIEW.NEWMAP.CustomAvalanchFrequncy.Value)}");
                    }

                    break;
                case "RateOfConsumption":
                    if (VIEW.NEWMAP.DefaultRateOfConsumption.Checked == true)
                    {
                        //MODEL.RateOfConsumption = MODEL.RateOfConsumption;
                        VIEW.NEWMAP.RateOfConsumption.Enabled = false;
                        VIEW.NEWMAP.RateOfConsumption.Invalidate();
                        VIEW.NEWMAP.RateOfConsumption.Refresh();
                        Application.DoEvents();
                        Debug.WriteLine($"|Controller|  RateOfConsumption set to Default");
                    }
                    else
                    {
                        VIEW.NEWMAP.RateOfConsumption.Enabled = true;
                        VIEW.NEWMAP.UserInput("RateOfConsumption");
                        Debug.WriteLine($"|Controller|  RateOfConsumption Checked. it is now: {Convert.ToInt32(VIEW.NEWMAP.RateOfConsumption.Value)}");
                    }
                    break;
                case "AirQuantity":

                    if (VIEW.NEWMAP.DefaultAirQuantity.Checked == true)
                    {
                        //MODEL.AirQuantity = MODEL.AirQuantity;
                        VIEW.NEWMAP.AirQuantity.Enabled = false;
                        VIEW.NEWMAP.AirQuantity.Invalidate();
                        VIEW.NEWMAP.AirQuantity.Refresh();
                        Application.DoEvents();
                        Debug.WriteLine($"|Controller|  AirQuantity set to Default");
                    }
                    else
                    {
                        VIEW.NEWMAP.AirQuantity.Enabled = true;
                        VIEW.NEWMAP.UserInput("AirQuantity");
                        Debug.WriteLine($"|Controller|  AirQuantity Checked. it is now: {Convert.ToInt32(VIEW.NEWMAP.AirQuantity.Value)}");
                    }
                    break;
                case "PowerDrainMultiplier":

                    if (VIEW.NEWMAP.DefaultPowerDrain.Checked == true)
                    {
                        //MODEL.PowerDrainMultiplier = MODEL.PowerDrainMultiplyer;
                        VIEW.NEWMAP.PowerDrainMultiplier.Enabled = false;
                        VIEW.NEWMAP.PowerDrainMultiplier.Invalidate();
                        VIEW.NEWMAP.PowerDrainMultiplier.Refresh();
                        Application.DoEvents();
                        Debug.WriteLine($"|Controller|  PowerDrainMultiplier set to Default");
                    }
                    else
                    {
                        VIEW.NEWMAP.PowerDrainMultiplier.Enabled = true;
                        VIEW.NEWMAP.UserInput("PowerDrainMultiplier");
                        Debug.WriteLine($"|Controller|  AirQuantity Checked. it is now: {Convert.ToInt32(VIEW.NEWMAP.PowerDrainMultiplier.Value)}");
                    }

                    break;
                case "CollectCrystals":

                    if (VIEW.NEWMAP.ActiveCrystalCollection.Checked == true)
                    {

                        VIEW.NEWMAP.NeededCrystals.Enabled = true;
                        this.MODEL.CollectCrystals = true;
                        VIEW.NEWMAP.UserInput("CrystalsCount");
                        VIEW.NEWMAP.NeededCrystals.Invalidate();
                        VIEW.NEWMAP.NeededCrystals.Refresh();
                        Application.DoEvents();
                        if (WinCondCheck() == true)
                        {
                            this.VIEW.NEWMAP.button1.Enabled = true;
                            this.VIEW.NEWMAP.button1.Refresh();
                            this.VIEW.NEWMAP.button2.Enabled = true;
                            this.VIEW.NEWMAP.button2.Refresh();
                        }
                    }
                    else
                    {                        
                        VIEW.NEWMAP.NeededCrystals.Enabled = false;
                        MODEL.CollectCrystals = false;
                        Debug.WriteLine($"|Controller|  CollectCrystals Checked. it is now: False");
                        if (WinCondCheck() == false)
                        {
                            this.VIEW.NEWMAP.button1.Enabled = false;
                            this.VIEW.NEWMAP.button1.Refresh();
                            this.VIEW.NEWMAP.button2.Enabled = false;
                            this.VIEW.NEWMAP.button2.Refresh();
                        }
                    }

                    break;
                case "BuildSpecificBuilding":
                    Debug.WriteLine($"|Controller|  SpecificBuilding Checked");
                    if (VIEW.NEWMAP.ActiveSpecificBuilding.Checked == true)
                    {
                        VIEW.NEWMAP.comboBoxSpecificBuilding.Enabled = true;
                        this.MODEL.BuildSpecificBuilding = true;
                        VIEW.NEWMAP.UserInput("SpecificBuilding");
                        VIEW.NEWMAP.comboBoxSpecificBuilding.Invalidate();
                        VIEW.NEWMAP.comboBoxSpecificBuilding.Refresh();
                        Application.DoEvents();
                        if (WinCondCheck() == true)
                        {
                            this.VIEW.NEWMAP.button1.Enabled = true;
                            this.VIEW.NEWMAP.button1.Refresh();
                            this.VIEW.NEWMAP.button2.Enabled = true;
                            this.VIEW.NEWMAP.button2.Refresh();
                        }
                    }
                    else
                    {
                        VIEW.NEWMAP.comboBoxSpecificBuilding.Enabled = false;
                        MODEL.BuildSpecificBuilding = false;
                        Debug.WriteLine($"|Controller|  BuildSpecificBuilding Checked. it is now: False");
                        if (WinCondCheck() == false)
                        {
                            this.VIEW.NEWMAP.button1.Enabled = false;
                            this.VIEW.NEWMAP.button1.Refresh();
                            this.VIEW.NEWMAP.button2.Enabled = false;
                            this.VIEW.NEWMAP.button2.Refresh();
                        }
                    }

                    break;
                case "BuildSpecificUnit":
                    Debug.WriteLine($"|Controller|  SpecificUnit Checked");
                    if (VIEW.NEWMAP.ActiveSpecificUnit.Checked == true)
                    {
                        VIEW.NEWMAP.comboBoxSpecificUnit.Enabled = true;
                        this.MODEL.BuildSpecificUnit = true;
                        VIEW.NEWMAP.UserInput("SpecificUnit");
                        VIEW.NEWMAP.comboBoxSpecificUnit.Invalidate();
                        VIEW.NEWMAP.comboBoxSpecificUnit.Refresh();
                        Application.DoEvents();
                        if (WinCondCheck() == true)
                        {
                            this.VIEW.NEWMAP.button1.Enabled = true;
                            this.VIEW.NEWMAP.button1.Refresh();
                            this.VIEW.NEWMAP.button2.Enabled = true;
                            this.VIEW.NEWMAP.button2.Refresh();
                        }
                    }
                    else
                    {
                        VIEW.NEWMAP.comboBoxSpecificUnit.Enabled = false;
                        MODEL.BuildSpecificUnit = false;
                        Debug.WriteLine($"|Controller|  BuildSpecificUnit Checked. it is now: False");
                        if (WinCondCheck() == false)
                        {
                            this.VIEW.NEWMAP.button1.Enabled = false;
                            this.VIEW.NEWMAP.button1.Refresh();
                            this.VIEW.NEWMAP.button2.Enabled = false;
                            this.VIEW.NEWMAP.button2.Refresh();
                        }
                    }
                    break;

                case "SpecificRescueUnit":
                    Debug.WriteLine($"|Controller|  ActiveRescue Checked");
                    if (VIEW.NEWMAP.ActiveRescue.Checked == true)
                    {
                        VIEW.NEWMAP.comboBoxRescueUnit.Enabled = true;
                        this.MODEL.RescueSpecificUnit = true;
                        VIEW.NEWMAP.UserInput("SpecificRescueUnit");
                        VIEW.NEWMAP.comboBoxRescueUnit.Invalidate();
                        VIEW.NEWMAP.comboBoxRescueUnit.Refresh();
                        Application.DoEvents();
                        if (WinCondCheck() == true)
                        {
                            this.VIEW.NEWMAP.button1.Enabled = true;
                            this.VIEW.NEWMAP.button1.Refresh();
                            this.VIEW.NEWMAP.button2.Enabled = true;
                            this.VIEW.NEWMAP.button2.Refresh();
                        }
                    }
                    else
                    {
                        VIEW.NEWMAP.comboBoxRescueUnit.Enabled = false;
                        MODEL.RescueSpecificUnit = false;
                        Debug.WriteLine($"|Controller|  RescueSpecificUnit Checked. it is now: False");
                        if (WinCondCheck() == false)
                        {
                            this.VIEW.NEWMAP.button1.Enabled = false;
                            this.VIEW.NEWMAP.button1.Refresh();
                            this.VIEW.NEWMAP.button2.Enabled = false;
                            this.VIEW.NEWMAP.button2.Refresh();
                        }
                    }

                    break;
                case "TileReach":
                    {
                        Console.WriteLine($"|Controller|  Reach the Tile Checked");
                        if (VIEW.NEWMAP.ActiveReachTheTile.Checked == true)
                        {
                            this.MODEL.TileReach = true;
                            Application.DoEvents();

                        }
                        else
                        {
                            if (WinCondCheck() == false)
                            {
                                this.VIEW.NEWMAP.button1.Enabled = false;
                                this.VIEW.NEWMAP.button1.Refresh();
                                this.VIEW.NEWMAP.button2.Enabled = false;
                                this.VIEW.NEWMAP.button2.Refresh();
                            }
                        }
                    }
                    break;
                default:
                    Console.WriteLine($"|Controller|  ---Error_Code_1---");
                    Console.WriteLine($"|Controller|  EC1: ( {DefaultCheckBoxAction} ) is not a recognized 'DefaultCheckBoxes' CaseStatement Fix this You dummy... its probabably spelling");
                    break;

            }

        }
        public void UserInput(string NameOfDesiredVariableToChange)
        {
            switch (NameOfDesiredVariableToChange)
            {
                case "DamageToPlayer":
                    MODEL.DamageToPlayer = Convert.ToInt32(VIEW.NEWMAP.CustomDamage.Value);
                    Debug.WriteLine($"|Controller|  DamageToPlayer set to: {Convert.ToInt32(VIEW.NEWMAP.CustomDamage.Value)}");
                    break;

                case "DamageFromPlayer":
                    MODEL.DamageFromPlayer = Convert.ToInt32(VIEW.NEWMAP.CustomPlayerDamage.Value);
                    Debug.WriteLine($"|Controller|  DamageFromPlayer set to: {Convert.ToInt32(VIEW.NEWMAP.CustomPlayerDamage.Value)}");
                    break;

                case "CreatureSpeed":
                    MODEL.CreatureSpeed = Convert.ToInt32(VIEW.NEWMAP.CustomSpeed.Value);
                    Debug.WriteLine($"|Controller|  CreatureSpeed set to: {Convert.ToInt32(VIEW.NEWMAP.CustomSpeed.Value)}");
                    break;

                case "DebrisMultiplier":
                    MODEL.Debrismultiplier = Convert.ToInt32(VIEW.NEWMAP.DebrisMultiplier.Value);
                    Debug.WriteLine($"|Controller|  DebrisMultiplier set to: {Convert.ToInt32(VIEW.NEWMAP.DebrisMultiplier.Value)}");
                    break;

                case "Hunger":
                    MODEL.Hunger = Convert.ToInt32(VIEW.NEWMAP.CustomHunger.Value);
                    Debug.WriteLine($"|Controller|  Hunger set to: {Convert.ToInt32(VIEW.NEWMAP.CustomHunger.Value)}");
                    break;

                case "SpawnChance":
                    MODEL.SpawnChance = Convert.ToInt32(VIEW.NEWMAP.CustomSpawnChance.Value);
                    Debug.WriteLine($"|Controller|  SpawnChance set to: {Convert.ToInt32(VIEW.NEWMAP.CustomSpawnChance.Value)}");
                    break;

                case "ErosionSpeed":
                    MODEL.ErosionSpeed = Convert.ToInt32(VIEW.NEWMAP.CustomErosionSpeed.Value);
                    Debug.WriteLine($"|Controller|  ErosionSpeed set to: {Convert.ToInt32(VIEW.NEWMAP.CustomErosionSpeed.Value)}");
                    break;

                case "RepairCost":
                    MODEL.RepairCost = Convert.ToInt32(VIEW.NEWMAP.RepairCost.Value);
                    Debug.WriteLine($"|Controller|  RepairCost set to: {Convert.ToInt32(VIEW.NEWMAP.RepairCost.Value)}");
                    break;

                case "AvalancheDamageToPlayer":
                    MODEL.AvalancheDamageToPlayer = Convert.ToInt32(VIEW.NEWMAP.CustomAvalanchDamage.Value);
                    Debug.WriteLine($"|Controller|  AvalancheDamageToPlayer set to: {Convert.ToInt32(VIEW.NEWMAP.CustomAvalanchDamage.Value)}");
                    break;

                case "Frequency":
                    MODEL.Frequency = Convert.ToInt32(VIEW.NEWMAP.CustomAvalanchFrequncy.Value);
                    Debug.WriteLine($"|Controller|  Frequency set to: {Convert.ToInt32(VIEW.NEWMAP.CustomAvalanchFrequncy.Value)}");
                    break;

                case "RateOfConsumption":
                    MODEL.RateOfConsumption = Convert.ToInt32(VIEW.NEWMAP.RateOfConsumption.Value);
                    Debug.WriteLine($"|Controller|  RateOfConsumption set to: {Convert.ToInt32(VIEW.NEWMAP.RateOfConsumption.Value)}");
                    break;

                case "AirQuantity":
                    MODEL.AirQuantity = Convert.ToInt32(VIEW.NEWMAP.AirQuantity.Value);
                    Debug.WriteLine($"|Controller|  AirQuantity set to: {Convert.ToInt32(VIEW.NEWMAP.AirQuantity.Value)}");
                    break;

                case "PowerDrainMultiplier":
                    //MODEL.PowerDrainMultiplier = Convert.ToInt32(VIEW.NEWMAP.PowerDrainMultiplier.Value);
                    Debug.WriteLine($"|Controller|  PowerDrainMultiplier set to: {Convert.ToInt32(VIEW.NEWMAP.PowerDrainMultiplier.Value)}");
                    break;

                case "CrystalsCount":
                    MODEL.CrystalsCount = Convert.ToInt32(VIEW.NEWMAP.NeededCrystals.Value);
                    Debug.WriteLine($"|Controller|  CrystalsCount set to: {Convert.ToInt32(VIEW.NEWMAP.NeededCrystals.Value)}");
                    break;

                case "SpecificBuilding":
                    MODEL.SpecificBuilding = VIEW.NEWMAP.comboBoxSpecificBuilding.Text;
                    Debug.WriteLine($"|Controller|  SpecificBuilding set to: {VIEW.NEWMAP.comboBoxSpecificBuilding.Text}");
                    break;

                case "SpecificUnit":
                    MODEL.SpecificUnit = VIEW.NEWMAP.comboBoxSpecificUnit.Text;
                    Debug.WriteLine($"|Controller|  SpecificUnit set to: {VIEW.NEWMAP.comboBoxSpecificUnit.Text}");
                    break;

                case "SpecificRescueUnit":
                    MODEL.SpecificRescueUnit = VIEW.NEWMAP.comboBoxRescueUnit.Text;
                    Debug.WriteLine($"|Controller|  SpecificRescueUnit set to: {VIEW.NEWMAP.comboBoxRescueUnit.Text}");
                    break;

                default:
                    Console.WriteLine($"|Controller|  ---Error_Code_2---");
                    Console.WriteLine($"|Controller|  EC2: ( {NameOfDesiredVariableToChange} ) is not a recognized 'UserInput' CaseStatement Fix this You dummy... its probabably spelling");
                    break;

            }
        }
        public bool WinCondCheck()
        {
            Debug.WriteLine($"|Controller|  Testing Win Condition Check");

            bool a, b, c, d, e;
            a = MODEL.CollectCrystals;
            b = MODEL.BuildSpecificBuilding;
            c = MODEL.BuildSpecificUnit;
            d = MODEL.RescueSpecificUnit;
            e = MODEL.TileReach;

            if (a == false && b == false  && c == false && d == false && e == false)
            {
                Debug.WriteLine($"|Controller|  Win condition does not exists");
                return false;
            }
            else
            {
                Debug.WriteLine($"|Controller|  Win condition exists");
                return true;
            }
            
        }
        public void ApplySettings()
        {
            if (WinCondCheck() == true)
            {
                //Values from imputable boxes
                Debug.WriteLine($"|Controller|  ---Saving Values---");
                Debug.WriteLine($"|Controller|  -----------------------------------------------------------------------------------Foundations");
                //Foundations.-----------------------------------------------------------
                //Map Name
                MODEL.MapName = VIEW.NEWMAP.MapName.Text;
                Debug.WriteLine($"|Controller|  MapName set to:                   {VIEW.NEWMAP.MapName.Text}");

                //Width
                MODEL.Width = Convert.ToInt32(VIEW.NEWMAP.WidthIn.Value);
                Debug.WriteLine($"|Controller|  Width set to:                     {VIEW.NEWMAP.WidthIn.Value}");

                //Height
                MODEL.Height = Convert.ToInt32(VIEW.NEWMAP.HeightIn.Value);
                Debug.WriteLine($"|Controller|  Height set to:                    {VIEW.NEWMAP.HeightIn.Value}");

                //Terrain Type
                MODEL.TerrainType = VIEW.NEWMAP.TerrainType.Text;
                Debug.WriteLine($"|Controller|  TerrainType set to:               {VIEW.NEWMAP.TerrainType.Text}");

                //Environmental factors----------------------------------------------------
                Debug.WriteLine($"|Controller|  -----------------------------------------------------------------------------------Environmental");

                //Hostile AI
                MODEL.HostileAI = VIEW.NEWMAP.HostileAI.Checked;
                Debug.WriteLine($"|Controller|  HostileAI set to:                 {VIEW.NEWMAP.HostileAI.Checked}");

                //Erosion State
                MODEL.Erosion = VIEW.NEWMAP.Erosion.Checked;
                Debug.WriteLine($"|Controller|  Erosion set to:                   {VIEW.NEWMAP.Erosion.Checked}");

                //Avalanche State
                MODEL.Avalanches = VIEW.NEWMAP.Avalanche.Checked;
                Debug.WriteLine($"|Controller|  Avalanches set to:                {VIEW.NEWMAP.Avalanche.Checked}");

                //Air Threat State
                MODEL.AirThreat = VIEW.NEWMAP.AirThreat.Checked;
                Debug.WriteLine($"|Controller|  AirThreat set to:                 {VIEW.NEWMAP.AirThreat.Checked}");

                //Power Drain Sate
                MODEL.PowerDrain = VIEW.NEWMAP.PowerDrain.Checked;
                Debug.WriteLine($"|Controller|  PowerDrain set to:                {VIEW.NEWMAP.PowerDrain.Checked}");


                //Enemy Ai-----------------------------------------------------------------------------------
                Debug.WriteLine($"|Controller|  -----------------------------------------------------------------------------------Enemy Ai");

                //Damage to player
                MODEL.DamageToPlayer = Convert.ToInt32(VIEW.NEWMAP.CustomDamage.Value);
                Debug.WriteLine($"|Controller|  DamageToPlayer set to:            {Convert.ToInt32(VIEW.NEWMAP.CustomDamage.Value)}");

                //Damage From Player
                MODEL.DamageFromPlayer = Convert.ToInt32(VIEW.NEWMAP.CustomPlayerDamage.Value);
                Debug.WriteLine($"|Controller|  DamageFromPlayer set to:          {Convert.ToInt32(VIEW.NEWMAP.CustomPlayerDamage.Value)}");

                //Creature Speed
                MODEL.CreatureSpeed = Convert.ToInt32(VIEW.NEWMAP.CustomSpeed.Value);
                Debug.WriteLine($"|Controller|  CreatureSpeed set to:             {Convert.ToInt32(VIEW.NEWMAP.CustomSpeed.Value)}");

                //Debris speed multiplier
                MODEL.Debrismultiplier = Convert.ToInt32(VIEW.NEWMAP.DebrisMultiplier.Value);
                Debug.WriteLine($"|Controller|  DebrisMultiplier set to:          {Convert.ToInt32(VIEW.NEWMAP.DebrisMultiplier.Value)}");

                //Hunger
                MODEL.Hunger = Convert.ToInt32(VIEW.NEWMAP.CustomHunger.Value);
                Debug.WriteLine($"|Controller|  Hunger set to:                    {Convert.ToInt32(VIEW.NEWMAP.CustomHunger.Value)}");

                //Spawn Chance
                MODEL.SpawnChance = Convert.ToInt32(VIEW.NEWMAP.CustomSpawnChance.Value);
                Debug.WriteLine($"|Controller|  SpawnChance set to:               {Convert.ToInt32(VIEW.NEWMAP.CustomSpawnChance.Value)}");

                //Erosion-----------------------------------------------------------------------------------
                Debug.WriteLine($"|Controller|  -----------------------------------------------------------------------------------Erosion");

                //Erosion speed
                MODEL.ErosionSpeed = Convert.ToInt32(VIEW.NEWMAP.CustomErosionSpeed.Value);
                Debug.WriteLine($"|Controller|  ErosionSpeed set to:              {Convert.ToInt32(VIEW.NEWMAP.CustomErosionSpeed.Value)}");

                //Erosion Repair cost
                MODEL.RepairCost = Convert.ToInt32(VIEW.NEWMAP.RepairCost.Value);
                Debug.WriteLine($"|Controller|  RepairCost set to:                {Convert.ToInt32(VIEW.NEWMAP.RepairCost.Value)}");

                //Avalanche-----------------------------------------------------------------------------------
                Debug.WriteLine($"|Controller|  -----------------------------------------------------------------------------------Avalanche");

                //Avalanche to player
                MODEL.AvalancheDamageToPlayer = Convert.ToInt32(VIEW.NEWMAP.CustomAvalanchDamage.Value);
                Debug.WriteLine($"|Controller|  AvalancheDamageToPlayer set to:   {Convert.ToInt32(VIEW.NEWMAP.CustomAvalanchDamage.Value)}");

                //Avalanche Frequency
                MODEL.Frequency = Convert.ToInt32(VIEW.NEWMAP.CustomAvalanchFrequncy.Value);
                Debug.WriteLine($"|Controller|  Frequency set to:                 {Convert.ToInt32(VIEW.NEWMAP.CustomAvalanchFrequncy.Value)}");

                //Air-----------------------------------------------------------------------------------
                Debug.WriteLine($"|Controller|  -----------------------------------------------------------------------------------Air");

                //Rate of Consumption
                MODEL.RateOfConsumption = Convert.ToInt32(VIEW.NEWMAP.RateOfConsumption.Value);
                Debug.WriteLine($"|Controller|  RateOfConsumption set to:         {Convert.ToInt32(VIEW.NEWMAP.RateOfConsumption.Value)}");

                //Air Quantity
                MODEL.AirQuantity = Convert.ToInt32(VIEW.NEWMAP.AirQuantity.Value);
                Debug.WriteLine($"|Controller|  AirQuantity set to:               {Convert.ToInt32(VIEW.NEWMAP.AirQuantity.Value)}");

                //PowerDrain-----------------------------------------------------------------------------------
                Debug.WriteLine($"|Controller|  -----------------------------------------------------------------------------------PowerDrain");

                //Power Drain Multiplier
                MODEL.Debrismultiplier = Convert.ToInt32(VIEW.NEWMAP.PowerDrainMultiplier.Value);
                Debug.WriteLine($"|Controller|  PowerDrainMultiplier set to:      {Convert.ToInt32(VIEW.NEWMAP.PowerDrainMultiplier.Value)}");

                //Winstate-----------------------------------------------------------------------------------
                Debug.WriteLine($"|Controller|  -----------------------------------------------------------------------------------Winstate");


                //true or false values on all settings.

                //WinConditions.
                //Collect Crystal State
                MODEL.CollectCrystals = VIEW.NEWMAP.ActiveCrystalCollection.Checked;
                Debug.WriteLine($"|Controller|  CollectCrystals set to:           {VIEW.NEWMAP.ActiveCrystalCollection.Checked}");

                //Build Specific Building State
                MODEL.BuildSpecificBuilding = VIEW.NEWMAP.ActiveSpecificBuilding.Checked;
                Debug.WriteLine($"|Controller|  BuildSpecificBuilding set to:     {VIEW.NEWMAP.ActiveSpecificBuilding.Checked}");

                //Build Specific unit State
                MODEL.BuildSpecificUnit = VIEW.NEWMAP.ActiveSpecificUnit.Checked;
                Debug.WriteLine($"|Controller|  BuildSpecificUnit set to:         {VIEW.NEWMAP.ActiveSpecificUnit.Checked}");

                //Resuce Specific unit State
                MODEL.RescueSpecificUnit = VIEW.NEWMAP.ActiveRescue.Checked;
                Debug.WriteLine($"|Controller|  RescueSpecificUnit set to:        {VIEW.NEWMAP.ActiveRescue.Checked}");

                //Reach the tile State
                MODEL.TileReach = VIEW.NEWMAP.ActiveReachTheTile.Checked;
                Debug.WriteLine($"|Controller|  TileReach set to:                 {VIEW.NEWMAP.ActiveReachTheTile.Checked}");

                //Winstate Values-----------------------------------------------------------------------------------
                Debug.WriteLine($"|Controller|  -----------------------------------------------------------------------------------Winstate Values");

                //Energy Crystal
                if (MODEL.CrystalsCount == 0)
                {
                    MODEL.CrystalsCount = 10;
                    Debug.WriteLine($"|Controller|  CrystalsCount set to:             10 (to avoid not having a wincondition)");
                }
                else
                {
                    MODEL.CrystalsCount = Convert.ToInt32(VIEW.NEWMAP.NeededCrystals.Value);
                    Debug.WriteLine($"|Controller|  CrystalsCount set to:             {Convert.ToInt32(VIEW.NEWMAP.NeededCrystals.Value)}");
                }

                //build Specific Building
                MODEL.SpecificBuilding = VIEW.NEWMAP.comboBoxSpecificBuilding.Text;
                Debug.WriteLine($"|Controller|  SpecificBuilding set to:          {VIEW.NEWMAP.comboBoxSpecificBuilding.Text}");

                //Build Specific Unit
                MODEL.SpecificUnit = VIEW.NEWMAP.comboBoxSpecificUnit.Text;
                Debug.WriteLine($"|Controller|  SpecificUnit set to:              {VIEW.NEWMAP.comboBoxSpecificUnit.Text}");

                //Rescue Specific Unit
                MODEL.SpecificRescueUnit = VIEW.NEWMAP.comboBoxRescueUnit.Text;
                Debug.WriteLine($"|Controller|  SpecificRescueUnit set to:        {VIEW.NEWMAP.comboBoxRescueUnit.Text}");

                Debug.WriteLine($"|Controller|  -----------------------------------------------------------------------------------Values Saved");
                Debug.WriteLine($"|Controller|  All Values saved to system settings ✓");
                Debug.WriteLine($"|Controller|  ");
            }
            else
            {
                //E/rror
            }

        }
        public void InitializeNewMap()
        {
            Debug.WriteLine($"");
            Debug.WriteLine($"|Controller|    Initializing NewMap  window controls");
            this.InitializeNewMapButtons();
            
            Debug.WriteLine($"|Controller|    Setting NewMap values to default");
            this.setNewMapValuesToDefault();
        }
        public void InitializeNewMapButtons()
        {
            this.VIEW.NEWMAP.WidthIn.ValueChanged += SetWidth;
            this.VIEW.NEWMAP.PowerDrain.CheckedChanged += this.checkBoxPowerDrain;
            this.VIEW.NEWMAP.Avalanche.CheckedChanged += this.checkBoxAvalanche;
            this.VIEW.NEWMAP.MapName.TextChanged += this.SetMapName;
            this.VIEW.NEWMAP.KeyDown += this.SetMapName;
            this.VIEW.NEWMAP.Leave += this.SetMapName;
            this.VIEW.NEWMAP.TerrainType.TextChanged += this.SetTerrainType;
            this.VIEW.NEWMAP.TerrainType.Leave += this.SetTerrainType;
            this.VIEW.NEWMAP.Erosion.CheckedChanged += this.checkBoxErosion;
            this.VIEW.NEWMAP.HostileAI.CheckedChanged += this.checkBoxHostileAI;
            this.VIEW.NEWMAP.AirThreat.CheckedChanged += this.checkBoxAirThreat;
            this.VIEW.NEWMAP.HeightIn.ValueChanged += this.SetHeight;
            this.VIEW.NEWMAP.DefaultPlayerDamage.CheckedChanged += this.checkBox6_CheckedChanged;
            this.VIEW.NEWMAP.CustomDamage.ValueChanged += this.CustomValue_DamageToPlayer;
            this.VIEW.NEWMAP.DefaultDamageFromPlayer.CheckedChanged += this.checkBox7_CheckedChanged;
            this.VIEW.NEWMAP.CustomPlayerDamage.ValueChanged += this.CustomValue_DamageFromPlayer;
            this.VIEW.NEWMAP.SpawnChance.CheckedChanged += this.checkBox11_CheckedChanged;
            this.VIEW.NEWMAP.CustomSpawnChance.ValueChanged += this.CustomValue_Spawn;
            this.VIEW.NEWMAP.DefaultHunger.CheckedChanged += this.checkBox10_CheckedChanged;
            this.VIEW.NEWMAP.CustomHunger.ValueChanged += this.CustomValue_HungerValue;
            this.VIEW.NEWMAP.DefaultSpeed.CheckedChanged += this.checkBox9_CheckedChanged;
            this.VIEW.NEWMAP.CustomSpeed.ValueChanged += this.CustomValue_CreatureSpeed;
            this.VIEW.NEWMAP.DebrisMultiplier.ValueChanged += this.CustomValue_DebrisMultiplier;
            this.VIEW.NEWMAP.DefaultRepairCost.CheckedChanged += this.checkBox14_CheckedChanged;
            this.VIEW.NEWMAP.RepairCost.ValueChanged += this.CustomValue_RepairCost;
            this.VIEW.NEWMAP.DefaultErosionSpeed.CheckedChanged += this.checkBox8_CheckedChanged;
            this.VIEW.NEWMAP.CustomErosionSpeed.ValueChanged += this.CustomValue_Erosion;
            this.VIEW.NEWMAP.DefaultAvalancheFrequency.CheckedChanged += this.checkBox13_CheckedChanged;
            this.VIEW.NEWMAP.CustomAvalanchFrequncy.ValueChanged += this.CustomValue_AvalancheFrequency;
            this.VIEW.NEWMAP.defaultAvalancheDamageToPlayers.CheckedChanged += this.checkBox12_CheckedChanged;
            this.VIEW.NEWMAP.CustomAvalanchDamage.ValueChanged += this.CustomValue_AvalancheDamageToPlayer;
            this.VIEW.NEWMAP.DefaultAirQuantity.CheckedChanged += this.checkBox15_CheckedChanged;
            this.VIEW.NEWMAP.AirQuantity.ValueChanged += this.CustomValue_AirQuantity;
            this.VIEW.NEWMAP.DefaultRateOfConsumption.CheckedChanged += this.checkBox16_CheckedChanged;
            this.VIEW.NEWMAP.RateOfConsumption.ValueChanged += CustomValue_RateOfConsumption;
            this.VIEW.NEWMAP.DefaultPowerDrain.CheckedChanged += this.checkBox18_CheckedChanged;
            this.VIEW.NEWMAP.PowerDrainMultiplier.ValueChanged += this.CustomValue_PowerDrainMultiplier;
            this.VIEW.NEWMAP.ActiveReachTheTile.CheckedChanged += this.checkbox23_CheckedChanged;
            this.VIEW.NEWMAP.ActiveRescue.CheckedChanged += this.checkBox22_CheckedChanged;
            this.VIEW.NEWMAP.comboBoxRescueUnit.TextChanged += this.CustomValue_SpecificRescueUnit;
            this.VIEW.NEWMAP.ActiveSpecificUnit.CheckedChanged += this.checkBox21_CheckedChanged;
            this.VIEW.NEWMAP.comboBoxSpecificUnit.TextChanged += this.CustomValue_SpecificUnit;
            this.VIEW.NEWMAP.ActiveSpecificBuilding.CheckedChanged += this.checkBox20_CheckedChanged;
            this.VIEW.NEWMAP.comboBoxSpecificBuilding.TextChanged += this.CustomValue_SpecificBuilding;
            this.VIEW.NEWMAP.ActiveCrystalCollection.CheckedChanged += this.checkBox19_CheckedChanged;
            this.VIEW.NEWMAP.NeededCrystals.ValueChanged += this.CustomValue_CrystalsCount;
            this.VIEW.NEWMAP.button1.Click += this.ApplyButton;
            this.VIEW.NEWMAP.button2.Click += this.SaveButton;
        }
        public void setNewMapValuesToDefault()
        {
            //Map Name
            this.VIEW.NEWMAP.MapName.Text = this.MODEL.MapName;

            //Map Dimensions and terrain type
            this.VIEW.NEWMAP.WidthIn.Value = this.MODEL.Width;
            this.VIEW.NEWMAP.HeightIn.Value = this.MODEL.Height;
            this.VIEW.NEWMAP.TerrainType.Text = this.MODEL.TerrainType;

            //Enviromental factors
            this.VIEW.NEWMAP.HostileAI.Checked = this.MODEL.HostileAI;
            this.VIEW.NEWMAP.Erosion.Checked = this.MODEL.Erosion;
            this.VIEW.NEWMAP.Avalanche.Checked = this.MODEL.Avalanches;
            this.VIEW.NEWMAP.AirThreat.Checked = this.MODEL.AirThreat;
            this.VIEW.NEWMAP.PowerDrain.Checked = this.MODEL.PowerDrain;

            //Enemy Ai Values
            //---Damage
            this.VIEW.NEWMAP.CustomDamage.Value = this.MODEL.DamageToPlayer;
            this.VIEW.NEWMAP.CustomPlayerDamage.Value = this.MODEL.DamageFromPlayer;

            //---Speed
            this.VIEW.NEWMAP.CustomSpeed.Value = this.MODEL.CreatureSpeed;
            this.VIEW.NEWMAP.DebrisMultiplier.Value = this.MODEL.Debrismultiplier;

            //---Hunger(how many crystals it will eat before leaving
            this.VIEW.NEWMAP.CustomHunger.Value = this.MODEL.Hunger;

            //---Spawn
            this.VIEW.NEWMAP.CustomSpawnChance.Value = this.MODEL.SpawnChance;

            //Erosion
            this.VIEW.NEWMAP.CustomErosionSpeed.Value = this.MODEL.ErosionSpeed;
            this.VIEW.NEWMAP.RepairCost.Value = this.MODEL.RepairCost;

            //Avalanche
            this.VIEW.NEWMAP.CustomAvalanchDamage.Value = this.MODEL.AvalancheDamageToPlayer;
            this.VIEW.NEWMAP.CustomAvalanchFrequncy.Value = this.MODEL.Frequency;

            //Air Consumption
            this.VIEW.NEWMAP.RateOfConsumption.Value = this.MODEL.RateOfConsumption;
            this.VIEW.NEWMAP.AirQuantity.Value = this.MODEL.AirQuantity;

            //Power Drain
            this.VIEW.NEWMAP.PowerDrainMultiplier.Value = this.MODEL.PowerDrainMultiplyer;

            //Win Conditions
            //---Collect Crystals
            this.VIEW.NEWMAP.ActiveCrystalCollection.Checked = this.MODEL.CollectCrystals;
            this.VIEW.NEWMAP.NeededCrystals.Value = this.MODEL.CrystalsCount;

            //---Build Specific Buildings
            this.VIEW.NEWMAP.ActiveSpecificBuilding.Checked = this.MODEL.BuildSpecificBuilding;
            this.VIEW.NEWMAP.comboBoxSpecificBuilding.Text = this.MODEL.SpecificBuilding;

            //---Build Specific Unit
            this.VIEW.NEWMAP.ActiveSpecificUnit.Checked = this.MODEL.BuildSpecificUnit;
            this.VIEW.NEWMAP.comboBoxSpecificUnit.Text = this.MODEL.SpecificUnit;

            //---Rescue Specific Unit
            this.VIEW.NEWMAP.ActiveRescue.Checked = this.MODEL.RescueSpecificUnit;
            this.VIEW.NEWMAP.comboBoxRescueUnit.Text = this.MODEL.SpecificRescueUnit;

            //---Reach the tile
            this.VIEW.NEWMAP.ActiveReachTheTile.Checked = this.MODEL.TileReach;


        }
        //-----------------------------------------------------------------------------END OF NEW MAP METHODS--------------------------------------------------------------\\
    }

}
