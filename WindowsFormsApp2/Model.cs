using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Model
    {
        //Map Name
        private string MapName;

        //Map Dimensions and terrain type
        private int Width;
        private int Height;
        private int TerrainType;

        //Enviromental factors
        private bool HostileAI;
        private bool Erosion;
        private bool Avalanches;
        private bool AirThreat;
        private bool PowerDrain;

        //Enemy Ai Values
        //---Damage
        private int DamageToPlayer = 25;
        private int DamageFromPlayer = 15;

        //---Speed
        private int CreatureSpeed = 10;
        private int DebrisMultiplayer = 2;

        //---Hunger(how many crystals it will eat before leaving
        private int Hunger = 3;

        //---Spawn
        private float SpawnChance = .10f;

        //Erosion
        private float ErosionSpeed = .10f;
        private int RepairCost = 3;

        //Avalanche
        private int AvalancheDamageToPlayer = 3;
        private float Frequency = .10f;

        //Air Consumption
        private float RateOfConsumption = .5f;
        private int AirQuantity = 2;

        //Power Drain
        private int PowerDrainMultiplyer = 1;

        //Win Conditions
        //---Collect Crystals
        private bool CollectCrystals = false;
        private int CrystalsCount = 10;

        //---Build Specific Buildings
        private bool BuildSpecificBuilding = false;
        private string SpecificBuilding;

        //---Build Specific Unit
        private bool BuildSpecificUnit = false;
        private string SpecificUnit;

        //---Rescue Specific Unit
        private bool RescueSpecificUnit = false;
        private string SpecificRescueUnit;

        //---Reach Tile
        private bool TileReach = false;
    }
    
}
