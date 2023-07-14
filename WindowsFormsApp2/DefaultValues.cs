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
        public string MapName = "New Map";

        public int Width = 0;
        public int Height = 0;
        public string TerrainType = "Rock";

        public bool HostileAI = false;
        public bool Erosion = false;
        public bool Avalanches = false;
        public bool AirThreat = false;
        public bool PowerDrain = false;

        public int DamageToPlayer = 25;
        int DamageFromPlayer = 15;

        public int CreatureSpeed = 10;
        public int DebrisMultiplayer = 2;

        int Hunger = 3;

        float SpawnChance = .10f;

        float ErosionSpeed = .10f;
        int RepairCost = 3;

        int AvalancheDamageToPlayer = 3;
        float Frequency = .10f;

        float RateOfConsumption = .5f;
        int AirQuantity = 100;

        int PowerDrainMultiplyer = 1;
        
        bool CollectCrystals = false;
        int CrystalsCount = 10;

        bool BuildSpecificBuilding = false;
        string SpecificBuilding = "Generators";

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
            Properties.Settings.Default.HostileAi = HostileAI;
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
            bool BuildSpecificUnit = false;
            Properties.Settings.Default.BuildSpecificUnit = BuildSpecificUnit;

            string SpecificUnit = "Miner";
            Properties.Settings.Default.SpecificUnit = SpecificUnit;

            //---Rescue Specific Unit
            bool RescueSpecificUnit = false;
            Properties.Settings.Default.RescueSpecificUnit = RescueSpecificUnit;

            string SpecificRescueUnit = "Miner";
            Properties.Settings.Default.SpecificRescueUnit = SpecificRescueUnit;

            //---Reach Tile
            bool TileReach = false;
            Properties.Settings.Default.TileReach = TileReach;

        }
        public void SetSpecificValueDefault(string ItemToBeDefaulted)
        {
            switch (ItemToBeDefaulted)
            {
                case "MapName":
                    string MapName = "New Map";
                    Properties.Settings.Default.MapName = MapName;
                    break;
                case "
            }


        }
    
    }
}

 
      
    


  

