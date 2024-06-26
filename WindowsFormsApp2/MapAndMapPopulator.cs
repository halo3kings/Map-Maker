﻿/* Copyright (C) 2023 Austin Tyler - All Rights Reserved
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.Remoting.Messaging;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace WindowsFormsApp2
{
    public class MapAndMapPopulator
    {
        static public int Height, Width;
        public string BIOME;
        public Tile[,] TILE;
        public int[,] MAPDATA;
        public int size = 64;
        public MapAndMapPopulator(int W, int H, string Biome)
        {
            Debug.WriteLine($"|MapAndMapPop|      Map Generation beginging...");
            Height = H;
            Width = W;
            BIOME = Biome;

            Debug.WriteLine($"|MapAndMapPop|      Creating Tile  array...");

            TILE = new Tile[Width, Height];

            Debug.WriteLine($"|MapAndMapPop|      Creating MapData array...");

            MAPDATA = new int[Width, Height];

            Debug.WriteLine($"|MapAndMapPop|      Generating  map...");

            InitializeTiles();
            GenerateMap();
        }
        public void ClearMap(int W, int H)
        {
            Tile[,] ResetTiles = new Tile[W, H];
            TILE = ResetTiles;
            InitializeTiles();
        }

        public void InitializeTiles()
        {
            int id = 0;
            int H = 0;
            while (H < Height)
            {
                for (int i = 0; i < Width; i++)
                {
                    
                    Debug.WriteLine($"|MapAndMapPop|      creating tile");
                    Debug.WriteLine($"|MapAndMapPop|      Value of  i: {i}");
                    TILE[i, H] = new Tile(size, BIOME,id,i,H);

                    Debug.WriteLine($"|MapAndMapPop|      Adding tile: ({i},{H})  to map");
                    TILE[i, H].TILE.Click += this.TileClicked;
                    TILE[i, H].exists = true;
                    id++;
                }

                Debug.WriteLine($"|MapAndMapPop|      move to the next array index");
                H++;
            }
        }

        public void GenerateMap()
        {
            int H = 0;


            //by adding +1 at the end, it will make the matrix  one size larger so the boundry doesnt get counted in  the map size.
            while (H < Height)
            {
                int w = 0;

                for (int W = 0; W < Width; W++)
                {
                    w = W;
                    Debug.WriteLine($"|MapAndMapPop|      Creating Tile: {W},{H}");
                    TILE[W, H].SetName(W, H);

                    Debug.WriteLine($"|MapAndMapPop|      Tile: {TILE[W, H].TILE.Name}");
                    TILE[W, H].SetTexture(BiomesSpecificFloor());
                    Debug.WriteLine($"|MapAndMapPop|      setting  picture");
                    Debug.WriteLine($"|MapAndMapPop|      setting mapdata aray value for the tile");
                    MAPDATA[W, H] = 1;

                    //*
                    //Top and bottom boundrys
                    //--Top of map, solid rock boundry
                    if (H == 0 && W < Width)
                    {
                        Debug.WriteLine($"|MapAndMapPop|      Top Of map");
                        TILE[W, H].SetTexture(BiomesSpecificWalls());
                        MAPDATA[W, H] = 9;
                        WidthPlacement(W, H);
                    }
                    //--Bottom of map, solid rock boundry
                    if (H == Height - 1 && W < Width)
                    {
                        Debug.WriteLine($"|MapAndMapPop|      Bottom Of map");
                        TILE[W, H].SetTexture(BiomesSpecificWalls());
                        MAPDATA[W, H] = 9;
                        WidthPlacement(W, H);
                    }
                    //Left and Right boundrys
                    //--Left of map, solid rock boundry
                    if (W == 0 && H < Height)
                    {
                        Debug.WriteLine($"|MapAndMapPop|      Left Of map");
                        TILE[W, H].SetTexture(BiomesSpecificWalls());
                        MAPDATA[W, H] = 9;
                        WidthPlacement(W, H);
                    }
                    //--Right of map, solid rock boundry
                    if (W == Width - 1 && H < Height)
                    {
                        Debug.WriteLine($"|MapAndMapPop|      Right Of map");
                        TILE[W, H].SetTexture(BiomesSpecificWalls());
                        MAPDATA[W, H] = 9;
                        WidthPlacement(W, H);
                    }
                    //if tile 0,0 is true, then its location will be at 0,0
                    if (TILE[W, H] == TILE[0, 0])
                    {

                        Debug.WriteLine($"|MapAndMapPop|      Tile is at 0,0");
                        TILE[W, H].SetLocation(0, 0);
                        WidthPlacement(W, H);
                    }
                    // if tile Width is not 0 then its location should be the last location in the array + size.
                    if (TILE[W, H] != TILE[0, 0])
                    {
                        Debug.WriteLine($"|MapAndMapPop|      Tile width is not 0");
                        WidthPlacement(W, H);
                        Debug.WriteLine($"|MapAndMapPop|      Tile: {TILE[W, H].TILE.Name} is at location: {TILE[W, H].TILE.Location}");
                    }
                    //*/

                    //-----------------works below this.
                    if (W < Width - 1)
                    {
                        Debug.WriteLine($"|MapAndMapPop|      W is less than map width");
                        WidthPlacement(W, H);
                        HeightPlacement(W, H);
                        Debug.WriteLine($"|MapAndMapPop|      Tile: {TILE[W, H].TILE.Name} is at location: {TILE[W, H].TILE.Location}");
                    }
                    if (W == Width - 1)
                    {
                        Debug.WriteLine($"|MapAndMapPop|      W is equal to map width");
                        WidthPlacement(W, H);
                        HeightPlacement(W, H);
                        Debug.WriteLine($"|MapAndMapPop|      Tile: {TILE[W, H].TILE.Name} is at location: {TILE[W, H].TILE.Location}");

                    }

                    Debug.WriteLine($"|MapAndMapPop|      ");
                    //set tile height to the next level. 
                }
                HeightPlacement(w, H);
                H++;
                Debug.WriteLine($"|MapAndMapPop|      Resizing  new tile");
            }
        }
        public Bitmap BiomesSpecificFloor()
        {
            switch (BIOME)
            {
                case "Ice":
                    {
                        return WindowsFormsApp2.Properties.Resources.ICE00;
                    }
                    break;
                case "Rock":
                    {
                        return WindowsFormsApp2.Properties.Resources.Floor;
                    }
                    break;
                case "Lava":
                    {
                        return WindowsFormsApp2.Properties.Resources.LAVA00;
                    }
                    break;
            }
            return null;
        }
        public Bitmap BiomesSpecificWalls()
        {
            switch (BIOME)
            {
                case "Ice":
                    {
                        return WindowsFormsApp2.Properties.Resources.ICE05;
                    }
                    break;
                case "Rock":
                    {
                        return WindowsFormsApp2.Properties.Resources.SolidRock;
                    }
                    break;
                case "Lava":
                    {
                        return WindowsFormsApp2.Properties.Resources.LAVA05;
                    }
                    break;
            }
            return null;
        }


        public void WidthPlacement(int W, int H)
        {
            //if the width is zero set it to zero
            if (W == 0)
            {
                TILE[W, H].SetWidth(0);
            }
            else
            {
                TILE[W, H].SetWidth(TILE[W - 1, H].GetLocationWidth() + size);
            }
            Debug.WriteLine($"|MapAndMapPop|      Caluclating width placement");
            Debug.WriteLine($"|MapAndMapPop|      printing size: {size}");

        }
        public void HeightPlacement(int W, int H)
        {
            Debug.WriteLine($"|MapAndMapPop|      Caluclating Height placement");

            if (H == 0)
            {
                Debug.WriteLine($"|MapAndMapPop|      h = zero setting height to size");
                TILE[W, H].SetHeight(0);
            }
            else
            {
                Debug.WriteLine($"|MapAndMapPop|      Height is greater than 0, dynamically calculating");
                TILE[W, H].SetHeight(TILE[W, H - 1].GetLocationHeight() + size);
                Debug.WriteLine($"|MapAndMapPop|      printing size: {size}");
            }


        }
        public void CustomResizeMap(int TileSize)
        {
            
            size = TileSize;
            int H = 0;
            while (H < Height)
            {
                int w = 0;

                for (int W = 0; W < Width; W++)
                {
                    //set tile w,h width to new tile size
                    TILE[W, H].SetDimensionalWidth(TileSize);
                    Debug.WriteLine($"|MapAndMapPop|      Width set to: {TileSize}");

                    //set tile w,h Height to new tile size
                    TILE[W, H].SetDimensionalHeight(TileSize);
                    Debug.WriteLine($"|MapAndMapPop|      Height set to: {TileSize}");

                    //Set The Width
                    if (W == 0)
                    {
                        TILE[W, H].SetWidth(0);
                    }
                    else
                    {
                        TILE[W, H].SetWidth(TILE[W - 1, H].GetLocationWidth() + TileSize);
                    }

                    if(H == 0)
                    {
                        TILE[W,H].SetHeight(0);
                    }
                    else
                    {
                        TILE[W, H].SetHeight(TILE[W, H - 1].GetLocationHeight() + TileSize);
                    }
                   

                    Debug.WriteLine($"|MapAndMapPop|      Tile: {TILE[W, H].TILE.Name} is at location: {TILE[W, H].TILE.Location}");

                    
                    TILE[W, H].getTile().Update();
                    TILE[W, H].GetPicture().Update();
                    Debug.WriteLine($"|MapAndMapPop|      ");
                }
                HeightPlacement(w, H);
                H++;
                Debug.WriteLine($"|MapAndMapPop|      Resizing tiles");
                Debug.WriteLine($"|MapAndMapPop|      ");

            }
            

        }
        public int getSize()
        {
            return size;
        }
        public void TileClicked(object sender, EventArgs e)
        {
            getSender(sender);
        }
        public object getSender(object sender)
        {
            return sender;
        }
        public void Updater(object sender, EventArgs e)
        {

        }

    }
}
