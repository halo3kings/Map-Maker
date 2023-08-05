using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Properties;

namespace WindowsFormsApp2
{

    public class model
    {
        //-------------------------------------------------------------------------Beginging of MAP DATA------------------------------------------------------------------------------
        public bool MapCreated = false;
        
        //Map Name
        public string MapName = "New Map";

        //Map Dimensions and terrain type
        public int Width = 16;
        public int Height = 16;
        public string Biome = "Rock";

        //Enviromental factors
        public bool HostileAI = false;
        public bool Erosion = false;
        public bool Avalanches = false;
        public bool AirThreat = false;
        public bool PowerDrain = false;


        //Enemy Ai Values
        //---Damage
        public int DamageToPlayer = 25;
        public int DamageFromPlayer = 15;

        //---Speed
        public int CreatureSpeed = 10;
        public int Debrismultiplier = 2;

        //---Hunger(how many crystals it will eat before leaving
        public int Hunger = 3;

        //---Spawn
        public int SpawnChance = 10;

        //Erosion
        public int ErosionSpeed = 10;
        public int RepairCost = 3;

        //Avalanche
        public int AvalancheDamageToPlayer = 3;
        public int Frequency = 10;

        //Air Consumption
        public int RateOfConsumption = 5;
        public int AirQuantity = 100;

        //Power Drain
        public int PowerDrainMultiplyer = 1;

        //Win Conditions
        //---Collect Crystals
        public bool CollectCrystals = true;
        public int CrystalsCount = 10;

        //---Build Specific Buildings
        public bool BuildSpecificBuilding = false;
        public string SpecificBuilding = "Generators";

        //---Build Specific Unit
        public bool BuildSpecificUnit = false;
        public string SpecificUnit = "Miner";

        //---Rescue Specific Unit
        public bool RescueSpecificUnit = false;
        public string SpecificRescueUnit = "Miner";

        //---Reach Tile
        public bool TileReach = false;

        //--------------------------------------------------------------------Tool settings-----------------------------------------------------------------------------

        //Select tool
        public bool SelectToolSelected = false;

        //box Select tool
        public bool BoxSelectToolSelected = false;

        //EyeDropper tool
        public bool EyeDropperToolSelected = false;

        //Eraser tool 
        public bool EraserToolSelected = false;

        //Paint Brush
        public bool PaintBrushSleceted = false;
        
        public void SetTool(string tool)
        {
            switch (tool)
            {
                case "SelectTool":
                    {
                        Debug.WriteLine($"|MODEL|  SelectTool selected.");
                        EraserToolSelected = false;
                        EyeDropperToolSelected = false;
                        BoxSelectToolSelected = false;
                        SelectToolSelected = true;
                        PaintBrushSleceted = false;
                    }
                    break;
                case "BoxSelectTool":
                    {
                        Debug.WriteLine($"|MODEL|  BoxSelectTool selected.");
                        EraserToolSelected  = false;
                        EyeDropperToolSelected = false;
                        BoxSelectToolSelected = true;
                        SelectToolSelected = false;
                        PaintBrushSleceted = false;
                    }
                    break;
                case "EyeDropperTool":
                    {
                        Debug.WriteLine($"|MODEL|  EyeDropperTool selected.");
                        EraserToolSelected  = false;
                        EyeDropperToolSelected = true;
                        BoxSelectToolSelected = false;
                        SelectToolSelected = false;
                        PaintBrushSleceted = false;
                    }
                    break;
                case "EraserTool":
                    {
                        Debug.WriteLine($"|MODEL|  EraserTool selected.");
                        EraserToolSelected  = true;
                        EyeDropperToolSelected = false;
                        BoxSelectToolSelected = false;
                        SelectToolSelected = false;
                        PaintBrushSleceted = false;
                    }
                    break;
                case "PaintBrush":
                    {
                        Debug.WriteLine($"|MODEL|  PaintBrush selected.");
                        EraserToolSelected = false;
                        EyeDropperToolSelected = false;
                        BoxSelectToolSelected = false;
                        SelectToolSelected = false;
                        PaintBrushSleceted = true;
                    }
                    break;
            }
        }
        public bool NoToolsSelected()
        {
            // if all tools are false then return true
            if (EraserToolSelected      == false &&
                EyeDropperToolSelected  == false &&
                BoxSelectToolSelected   == false &&
                SelectToolSelected      == false &&
                PaintBrushSleceted      == false)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        
        //-----------------------------------------------------------Texture Assets------------------------------------------------------------------
        //this is the selected texture for the paint brush.
        public Image TextureSelected = null;

        public model()
        {
            Debug.Write($"|MODEL|  Setting Settings to default.");
        }

        public void SetValuesToDefault()
        {

            //Map Name
            Properties.Settings.Default.MapName = MapName;

            //Map Dimensions and terrain type
            Properties.Settings.Default.Width = Width;
            Properties.Settings.Default.Height = Height;
            Properties.Settings.Default.TerrainType = Biome;

            //Enviromental factors
            Properties.Settings.Default.HostileAI = HostileAI;
            Properties.Settings.Default.Erosion = Erosion;
            Properties.Settings.Default.Avalanches = Avalanches;
            Properties.Settings.Default.AirThreat = AirThreat;
            Properties.Settings.Default.PowerDrain = PowerDrain;

            //Enemy Ai Values
            //---Damage
            Properties.Settings.Default.DamageToPlayer = DamageToPlayer;
            Properties.Settings.Default.DamageFromPlayer = DamageFromPlayer;

            //---Speed
            Properties.Settings.Default.CreatureSpeed = CreatureSpeed;
            Properties.Settings.Default.DebrisMultiplier = Debrismultiplier;

            //---Hunger(how many crystals it will eat before leaving
            Properties.Settings.Default.Hunger = Hunger;

            //---Spawn
            Properties.Settings.Default.SpawnChance = SpawnChance;

            //Erosion
            Properties.Settings.Default.ErosionSpeed = ErosionSpeed;
            Properties.Settings.Default.RepairCost = RepairCost;

            //Avalanche
            Properties.Settings.Default.AvalancheDamageToPlayer = AvalancheDamageToPlayer;
            Properties.Settings.Default.Frequency = Frequency;

            //Air Consumption
            Properties.Settings.Default.RateOfConsumption = RateOfConsumption;
            Properties.Settings.Default.AirQuantity = AirQuantity;

            //Power Drain
            Properties.Settings.Default.PowerDrainMultiplier = PowerDrainMultiplyer;

            //Win Conditions
            //---Collect Crystals

            Properties.Settings.Default.CollectCrystals = CollectCrystals;
            Properties.Settings.Default.CrystalsCount = CrystalsCount;

            //---Build Specific Buildings
            Properties.Settings.Default.BuildSpecificBuilding = BuildSpecificBuilding;
            Properties.Settings.Default.SpecificBuilding = SpecificBuilding;

            //---Build Specific Unit
            Properties.Settings.Default.BuildSpecificUnit = BuildSpecificUnit;
            Properties.Settings.Default.SpecificUnit = SpecificUnit;

            //---Rescue Specific Unit
            Properties.Settings.Default.RescueSpecificUnit = RescueSpecificUnit;
            Properties.Settings.Default.SpecificRescueUnit = SpecificRescueUnit;

            //---Reach Tile
            Properties.Settings.Default.TileReach = TileReach;

        }
        //-------------------------------------------------------------Map clearing---------------------------------------------------------------
        public int OldHeight = 0;
        public int OldWidth = 0;
    }
}


    

