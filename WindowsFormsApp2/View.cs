/* Copyright (C) 2023 Austin Tyler - All Rights Reserved
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{

    public class View
    {
        DefaultValues DefVal = new DefaultValues();
        public Default_Window MAINAPP = new Default_Window();
        public New_Map NEWMAP = new New_Map();
        public MapAndMapPopulator MAP;
        public MapProgress MP = new MapProgress();


        public View()
        {

            //Initialize();
        }
        public void Run()
        {
            Application.Run(MAINAPP);
        }
        public void CreateMap(int w, int h, string biome)
        {
            
            double ProgressBarMax = w * h;
            double Iterations = 0;
            MP.Show();
            int H = 0;

            Debug.WriteLine($"|View|  Generating  map in viewer...");
            MP.text.Text = "|View|  Generating  map in viewer...";
            MP.Refresh();

           
            MAP = new MapAndMapPopulator(w, h, biome);


            Debug.WriteLine($"|View|  Map Generated...");
            MP.text.Text = "|View|  Map Generated...";
            MP.Refresh();

            Debug.WriteLine($"|View|  adding Tiles to pannel 'Map' on the workspace...");
            MP.text.Text = "|View|  adding Tiles to pannel 'Map' on the workspace...";
            while (H < h)
            {
                for (int i = 0; i < w; i++)
                {
                    Iterations = Iterations + 1;
                    MAINAPP.Map.Controls.Add(MAP.TILE[i, H].getTile());
                    Debug.WriteLine($"|View|  Adding tile: {MAP.TILE[i, H].TILE.Name} to map");
                    MP.text.Text = $"|View|  Adding tile: {MAP.TILE[i, H].TILE.Name} to map";
                    MP.progressBar1.Value = Convert.ToInt32((Iterations / ProgressBarMax) * 100);
                    Debug.WriteLine($"|View|  Progressbar val {(Iterations/ProgressBarMax)*100}");//Math.Round(Iterations /
                    MP.Refresh();


                }
                H++;
            }
            MP.Close();
        }
        public void RemoveMap(int w, int h)
        {
            int H = 0;
            Debug.WriteLine($"|View|  Removing  map in viewer...");

            while (H < h)
            {
                for (int i = 0; i < w; i++)
                {
                    MAINAPP.Map.Controls.Remove(MAP.TILE[i, H].PICTUREBOX);
                    MAINAPP.Map.Controls.Remove(MAP.TILE[i, H].TILE);
                    Debug.WriteLine($"|View|  Removing tile: {MAP.TILE[i, H].TILE.Name} from map");
                }
                H++;
            }
        }
        public void TileClick(object sender, EventArgs e)
        {

        }
        public Image GetTexture(string Texture)
        {
            switch (Texture)
            {
                //Terrain
                case "Floor":
                    {
                        return WindowsFormsApp2.Properties.Resources.Floor;
                    }
                    break;
                case "Dirt":
                    {
                        return WindowsFormsApp2.Properties.Resources.Dirt;
                    }
                    break;
                case "LooseRock":
                    {
                        return WindowsFormsApp2.Properties.Resources.LooseRock;
                    }
                    break;
                case "HardRock":
                    {
                        return WindowsFormsApp2.Properties.Resources.HardRock;
                    }
                    break;
                case "SolidRock":
                    {
                        return WindowsFormsApp2.Properties.Resources.SolidRock;
                    }
                    break;
                case "Rubble1":
                    {
                        return WindowsFormsApp2.Properties.Resources.Rubble1;
                    }
                    break;
                case "Rubble2":
                    {
                        return WindowsFormsApp2.Properties.Resources.Rubble2;
                    }
                    break;
                case "Rubble3":
                    {
                        return WindowsFormsApp2.Properties.Resources.Rubble3;
                    }
                    break;
                case "Concrete":
                    {
                        return WindowsFormsApp2.Properties.Resources.Concrete;
                    }
                    break;
                case "Water":
                    {
                        return WindowsFormsApp2.Properties.Resources.Water;
                    }
                    break;
                case "Lava":
                    {
                        return WindowsFormsApp2.Properties.Resources.Lava;
                    }
                    break;
                case "Erosion1":
                    {
                        return WindowsFormsApp2.Properties.Resources.LavaErosion1;
                    }
                    break;
                case "Erosion2":
                    {
                        return WindowsFormsApp2.Properties.Resources.LavaErosion2;
                    }
                    break;

                //Buildings
                case "ToolStore":
                    {
                        return WindowsFormsApp2.Properties.Resources.ToolStore;
                    }
                    break;
                    
            }
            return null;
        }

    }
}



    