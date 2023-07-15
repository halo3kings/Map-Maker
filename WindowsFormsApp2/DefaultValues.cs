using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Properties;

namespace WindowsFormsApp2
{
    public class DefaultValues
    {
        //Map Name
        public string MapName = "New Map";

        //Map Dimensions and terrain type
        public int Width = 16;
        public int Height = 16;
        public string TerrainType = "Rock";

        //Enviromental factors
        public bool HostileAI = false;
        public bool Erosion = false;
        public bool Avalanches = false;
        public bool AirThreat = false;
        public bool PowerDrain = false;

        //Enemy Ai Values
        //---Damage
        public int DamageToPlayer = 25;
        int DamageFromPlayer = 15;

        //---Speed
        public int CreatureSpeed = 10;
        public int DebrisMultiplayer = 2;

        //---Hunger(how many crystals it will eat before leaving
        int Hunger = 3;

        //---Spawn
        float SpawnChance = .10f;

        //Erosion
        float ErosionSpeed = .10f;
        int RepairCost = 3;

        //Avalanche
        int AvalancheDamageToPlayer = 3;
        float Frequency = .10f;

        //Air Consumption
        float RateOfConsumption = .5f;
        int AirQuantity = 100;

        //Power Drain
        int PowerDrainMultiplyer = 1;

        //Win Conditions
        //---Collect Crystals
        bool CollectCrystals = false;
        int CrystalsCount = 10;

        //---Build Specific Buildings
        bool BuildSpecificBuilding = false;
        string SpecificBuilding = "Generators";

        //---Build Specific Unit
        bool BuildSpecificUnit = false;
        string SpecificUnit = "Miner";

        //---Rescue Specific Unit
        bool RescueSpecificUnit = false;
        string SpecificRescueUnit = "Miner";
       
        //---Reach Tile
        bool TileReach = false;

        public DefaultValues()
        {
            Debug.Write("Setting Settings to default.");
        }

        public void SetValuesToDefault()
        {

            //Map Name
            Properties.Settings.Default.MapName = MapName;

            //Map Dimensions and terrain type
            Properties.Settings.Default.Width = Width;
            Properties.Settings.Default.Height = Height;
            Properties.Settings.Default.TerrainType = TerrainType;

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
            Properties.Settings.Default.DebrisMultiplayer = DebrisMultiplayer;

            //---Hunger(how many crystals it will eat before leaving
            Properties.Settings.Default.DebrisMultiplayer = Hunger;

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
            Properties.Settings.Default.PowerDrainMultiplyer = PowerDrainMultiplyer;

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
        public void SetSpecificValueDefault(string ItemToBeDefaulted)
        {
            switch (ItemToBeDefaulted)
            {
                case "MapName":
                    Properties.Settings.Default.MapName = MapName;
                    break;
                case "Width":
                    Properties.Settings.Default.Width = Width;
                    break;
                case "Height":
                    Properties.Settings.Default.Height = Height;
                    break;
                case "TerrainType":
                    Properties.Settings.Default.TerrainType = TerrainType;
                    break;
                case "HostileAI":
                    Properties.Settings.Default.HostileAI = HostileAI;
                    break;
                case "Erosion":
                    Properties.Settings.Default.Erosion = Erosion;
                    break;
                case "Avalanches":
                    Properties.Settings.Default.Avalanches = Avalanches;
                    break;
                case "AirThreat":
                    Properties.Settings.Default.AirThreat = AirThreat;
                    break;
                case "PowerDrain":
                    Properties.Settings.Default.PowerDrain = PowerDrain;
                    break;
                case "DamageToPlayer":
                    Properties.Settings.Default.DamageToPlayer = DamageToPlayer;
                    break;
                case "DamageFromPlayer":
                    Properties.Settings.Default.DamageFromPlayer = DamageFromPlayer;
                    break;
                case "CreatureSpeed":
                    Properties.Settings.Default.CreatureSpeed = CreatureSpeed;
                    break;
                case "DebrisMultiplayer":
                    Properties.Settings.Default.DebrisMultiplayer = DebrisMultiplayer;
                    break;
                case "Hunger":
                    Properties.Settings.Default.Hunger = Hunger;
                    break;
                case "SpawnChance":
                    Properties.Settings.Default.SpawnChance = SpawnChance;
                    break;
                case "ErosionSpeed":
                    Properties.Settings.Default.ErosionSpeed = ErosionSpeed;
                    break;
                case "RepairCost":
                    Properties.Settings.Default.RepairCost = RepairCost;
                    break;
                case "AvalancheDamageToPlayer":
                    Properties.Settings.Default.AvalancheDamageToPlayer = AvalancheDamageToPlayer;
                    break;
                case "Frequency":
                    Properties.Settings.Default.Frequency = Frequency;
                    break;
                case "RateOfConsumption":
                    Properties.Settings.Default.RateOfConsumption = RateOfConsumption;
                    break;
                case "AirQuantity":
                    Properties.Settings.Default.AirQuantity = AirQuantity;
                    break;
                case "PowerDrainMultiplyer":
                    Properties.Settings.Default.PowerDrainMultiplyer = PowerDrainMultiplyer;
                    break;
                case "CollectCrystals":
                    Properties.Settings.Default.CollectCrystals = CollectCrystals;
                    break;
                case "CrystalsCount":
                    Properties.Settings.Default.CrystalsCount = CrystalsCount;
                    break;
                case "BuildSpecificBuilding":
                    Properties.Settings.Default.BuildSpecificBuilding = BuildSpecificBuilding;
                    break;
                case "SpecificBuilding":
                    Properties.Settings.Default.SpecificBuilding = SpecificBuilding;
                    break;
                case "BuildSpecificUnit":
                    Properties.Settings.Default.BuildSpecificUnit = BuildSpecificUnit;
                    break;
                case "SpecificUnit":
                    Properties.Settings.Default.SpecificUnit = SpecificUnit;
                    break;
                case "RescueSpecificUnit":
                    Properties.Settings.Default.RescueSpecificUnit = RescueSpecificUnit;
                    break;
                case "SpecificRescueUnit":
                    Properties.Settings.Default.SpecificRescueUnit = SpecificRescueUnit;
                    break;
                case "TileReach":
                    Properties.Settings.Default.TileReach = TileReach;
                    break;
            }


        }
    
    }
}

 
      
    


  

