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
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp2
{
    public class MapAndMapPopulator
    {
        static public int Height, Width;
        public Tile[,] TILE;
        public int[,] MAPDATA;
        public int size = 64;
        public static Tile[,] TiLE; 
        public MapAndMapPopulator(int H, int W)
        {
            Debug.WriteLine("Map Generation beginging...");
            Height = H;
            Width = W;

            Debug.WriteLine("Creating Tile  array...");
            TILE = new Tile[Height, Width];
            Debug.WriteLine("Creating MapData array...");
            MAPDATA = new int[Height, Width];

            Debug.WriteLine("Generating  map...");
            InitializeTiles();
            GenerateMap();
        }
        public void InitializeTiles()
        {
            int H = 0;
            while (H < Height)
            {
                for (int i = 0; i < Width; i++)
                {
                    Debug.WriteLine("creating tile");
                    Debug.WriteLine($"Value of  i: {i}");
                    TILE[i, H] = new Tile(size);
                    Debug.WriteLine($"Adding tile: ({i},{H})  to map");
                }

                Debug.WriteLine("move to the next array index");
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
                    Debug.WriteLine($"Creating Tile: {W},{H}");
                    TILE[W, H].SetName(W, H);

                    Debug.WriteLine($"Tile: {TILE[W, H].TILE.Name}");
                    Debug.WriteLine($"setting  picture");
                    TILE[W, H].SetPicture(1);
                    Debug.WriteLine($"setting mapdata aray value for the tile");
                    MAPDATA[W, H] = 1;

                    //*
                    //Top and bottom boundrys
                    //--Top of map, solid rock boundry
                    if (H == 0 && W < Width)
                    {
                        Debug.WriteLine($"Top Of map");
                        TILE[W, H].SetPicture(9);
                        MAPDATA[W, H] = 9;
                        WidthPlacement(W, H);
                    }
                    //--Bottom of map, solid rock boundry
                    if (H == Height - 1 && W < Width)
                    {
                        Debug.WriteLine($"Bottom Of map");
                        TILE[W, H].SetPicture(9);
                        MAPDATA[W, H] = 9;
                        WidthPlacement(W, H);
                    }
                    //Left and Right boundrys
                    //--Left of map, solid rock boundry
                    if (W == 0 && H < Height)
                    {
                        Debug.WriteLine($"Left Of map");
                        TILE[W, H].SetPicture(9);
                        MAPDATA[W, H] = 9;
                        WidthPlacement(W, H);
                    }
                    //--Right of map, solid rock boundry
                    if (W == Width - 1 && H < Height)
                    {
                        Debug.WriteLine($"Right Of map");
                        TILE[W, H].SetPicture(9);
                        MAPDATA[W, H] = 9;
                        WidthPlacement(W, H);
                    }
                    //if tile 0,0 is true, then its location will be at 0,0
                    if (TILE[W, H] == TILE[0, 0])
                    {

                        Debug.WriteLine($"Tile is at 0,0");
                        TILE[W, H].SetLocation(0, 0);
                        WidthPlacement(W, H);
                    }
                    // if tile Width is not 0 then its location should be the last location in the array + size.
                    if (TILE[W, H] != TILE[0, 0])
                    {
                        Debug.WriteLine($"Tile width is not 0");
                        WidthPlacement(W, H);
                        Debug.WriteLine($"Tile: {TILE[W, H].TILE.Name} is at location: {TILE[W, H].TILE.Location}");
                    }
                    //*/

                    //-----------------works below this.
                    if (W < Width - 1)
                    {
                        Debug.WriteLine($"W is less than map width");
                        WidthPlacement(W, H);
                        HeightPlacement(W, H);
                        Debug.WriteLine($"Tile: {TILE[W, H].TILE.Name} is at location: {TILE[W, H].TILE.Location}");
                    }
                    if (W == Width - 1)
                    {
                        Debug.WriteLine($"W is equal to map width");
                        WidthPlacement(W, H);
                        HeightPlacement(W, H);
                        Debug.WriteLine($"Tile: {TILE[W, H].TILE.Name} is at location: {TILE[W, H].TILE.Location}");

                    }

                    Debug.WriteLine($"");
                    //set tile height to the next level. 
                }
                HeightPlacement(w, H);
                H++;
                Debug.WriteLine($"Resizing  new tile");
            }
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
            Debug.WriteLine($"Caluclating width placement");
            Debug.WriteLine($"printing size: {size}");

        }
        public void HeightPlacement(int W, int H)
        {
            Debug.WriteLine($"Caluclating Height placement");

            if (H == 0)
            {
                Debug.WriteLine($"h = zero setting height to size");
                TILE[W, H].SetHeight(0);
            }
            else
            {
                Debug.WriteLine($"Height is greater than 0, dynamically calculating");
                TILE[W, H].SetHeight(TILE[W, H - 1].GetLocationHeight() + size);
                Debug.WriteLine($"printing size: {size}");
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
                    Debug.WriteLine($"Width set to: {TileSize}");

                    //set tile w,h Height to new tile size
                    TILE[W, H].SetDimensionalHeight(TileSize);
                    Debug.WriteLine($"Height set to: {TileSize}");

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
                   

                    Debug.WriteLine($"Tile: {TILE[W, H].TILE.Name} is at location: {TILE[W, H].TILE.Location}");

                    
                    TILE[W, H].getTile().Update();
                    TILE[W, H].GetPicture().Update();
                    Debug.WriteLine($"");
                }
                HeightPlacement(w, H);
                H++;
                Debug.WriteLine($"Resizing tiles");
                Debug.WriteLine($"");

            }
            

        }
        public int getSize()
        {
            return size;
        }
    }
}
