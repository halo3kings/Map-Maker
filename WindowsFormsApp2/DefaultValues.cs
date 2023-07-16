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
        public int DamageFromPlayer = 15;

        //---Speed
        public int CreatureSpeed = 10;
        public int Debrismultiplier = 2;

        //---Hunger(how many crystals it will eat before leaving
        public int Hunger = 3;

        //---Spawn
        public float SpawnChance = .10f;

        //Erosion
        public float ErosionSpeed = .10f;
        public int RepairCost = 3;

        //Avalanche
        public int AvalancheDamageToPlayer = 3;
        public float Frequency = .10f;

        //Air Consumption
        public float RateOfConsumption = .5f;
        public int AirQuantity = 100;

        //Power Drain
        public int PowerDrainMultiplyer = 1;

        //Win Conditions
        //---Collect Crystals
        public bool CollectCrystals = false;
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
            Properties.Settings.Default.DebrisMultiplier = Debrismultiplier;

            //---Hunger(how many crystals it will eat before leaving
            Properties.Settings.Default.DebrisMultiplier = Hunger;

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
    
    }
}

 
      
    


  

