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
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Properties;

namespace WindowsFormsApp2
{
    public class Tile
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Default_Window));
        public System.Windows.Forms.Panel TILE;
        public System.Windows.Forms.PictureBox PICTUREBOX;
        
        public event EventHandler Click;

        public int Size = 0;
        public int ID = 0;
        public int TYPE = 0;
        public bool clicked = false;
        public bool exists = false;
        public Image texture = WindowsFormsApp2.Properties.Resources.Dirt256;
        public Tile(int size)
        {
            
            Size = size;
            InitializePictureBox();
            InitializeTile();//must be last
        }
        public void InitializeTile()
        {
            TILE = new System.Windows.Forms.Panel();
            Debug.WriteLine("|Tile|   initializing panel");
            //has picture

            //Generic window information
            this.TILE.BackColor = System.Drawing.SystemColors.Window;
            this.TILE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Debug.WriteLine("|Tile|   Generic window information");

            //top  left  corner  orgin
            this.TILE.Location = new System.Drawing.Point(0, 0);
            Debug.WriteLine("|Tile|   settting top  left  corner  orgin");

            //"TILE" will  be the default name with the added ID number on the end
            this.TILE.Name = "TILE" + ID;
            Debug.WriteLine("|Tile|   creating  title");

            //This sets the panel's Height and Width.
            this.TILE.Size = new System.Drawing.Size(Size, Size);
            Debug.WriteLine("|Tile|   setting  width and  height");

            // picture
            this.TILE.Controls.Add(PICTUREBOX);
            Debug.WriteLine("|Tile|   adding picture box");

        }
        public void InitializePictureBox()
        {
            PICTUREBOX = new System.Windows.Forms.PictureBox();
            Debug.WriteLine("|Tile|   initializing picture box");
            //fill the TILE
            this.PICTUREBOX.Dock = System.Windows.Forms.DockStyle.Fill;

            //The default image asset
            this.PICTUREBOX.Image = texture;

            // orgin
            this.PICTUREBOX.Location = new System.Drawing.Point(0, 0);
            
            //name
            this.PICTUREBOX.Name = "pictureBox" + ID;
            
            //size of picture box
            this.PICTUREBOX.Size = new System.Drawing.Size(Size, Size);
            
            //should the container be expanded, the image will strech to fit
            this.PICTUREBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            //ActionEvent
            
            this.PICTUREBOX.Click += new System.EventHandler(this.OnClick);
            Debug.WriteLine("|Tile|   Adding action  even");
            Debug.WriteLine("|Tile|   end off initializing panel");
        }
        public void OnClick(object sender, EventArgs e)
        {
            Debug.WriteLine("|Tile|   clicked");
            clicked = true;
        }
        public Image GetTexture()
        {
            return this.texture;
        }
        public void SetTexture(Image DesiredTexture)
        {
            this.texture = DesiredTexture;
        }
        public void setPictureBoxTexture()
        {
            PICTUREBOX.Image = texture;
        }
        public void SetLocation(int X, int Y)
        {
            this.TILE.Location = new System.Drawing.Point(X, Y);
        }
        public System.Drawing.Point GetLocation()
        {
            return this.TILE.Location;
        }
        public int GetLocationWidth()
        {
            int W = this.TILE.Location.X;
            return W;
        }
        public int GetLocationHeight()
        {
            int H = this.TILE.Location.Y;
            return H;
        }
        public void SetName(int W, int H)
        {
            this.TILE.Name = "TILE_" + W +"_"+ H;
        }
        public void SetWidth(int W)
        {
            this.TILE.Location = new System.Drawing.Point(W,this.GetLocationHeight());
        }
        public void SetHeight(int H)
        {
            this.TILE.Location = new System.Drawing.Point(this.GetLocationWidth(), H);
        }
        public void SetDimensionalWidth(int W)
        {
            this.TILE.Width = W;
        }
        public void SetDimensionalHeight(int H)
        {
            this.TILE.Height = H;
        }
        public bool Existance()
        {
            return exists;
        }
        public void SetPicture(string TYPE)
        {
            switch (TYPE)
            {
                //Terrain
                case "Floor":
                    {
                        texture = WindowsFormsApp2.Properties.Resources.Floor;
                        setPictureBoxTexture();
                    }
                    break;
                case "Dirt":
                    {
                        texture = WindowsFormsApp2.Properties.Resources.Dirt256;
                        setPictureBoxTexture(); 
                    }
                    break;
                case "LooseRock":
                    {
                        texture = WindowsFormsApp2.Properties.Resources.looseRock;
                        setPictureBoxTexture(); 
                    }
                    break;
                case "HardRock":
                    {
                        texture = WindowsFormsApp2.Properties.Resources.Hard_Rock;
                        setPictureBoxTexture(); 
                    }
                    break;
                case "SolidRock":
                    {
                        texture = WindowsFormsApp2.Properties.Resources.solid_rock;
                        setPictureBoxTexture(); 
                    }
                    break;
                case "Rubble1":
                    {
                        texture = WindowsFormsApp2.Properties.Resources.rubble_1;
                        setPictureBoxTexture(); 
                    }
                    break;
                case "Rubble2":
                    {
                        texture = WindowsFormsApp2.Properties.Resources.rubble_2;
                        setPictureBoxTexture(); 
                    }
                    break;
                case "Rubble3":
                    {
                        texture = WindowsFormsApp2.Properties.Resources.rubble_3;
                        setPictureBoxTexture(); 
                    }
                    break;
                case "Concrete":
                    {
                        texture = WindowsFormsApp2.Properties.Resources.Concrete;
                        setPictureBoxTexture(); 
                    }
                    break;
                case "Water":
                    {
                        texture = WindowsFormsApp2.Properties.Resources.Water;
                        setPictureBoxTexture(); 
                    }
                    break;

                //Buildings
                case "ToolStore":
                    {
                        texture = WindowsFormsApp2.Properties.Resources.ToolStore;
                        setPictureBoxTexture(); 
                    }
                    break;
            }
        }
        public Panel getTile()
        {
            return TILE;
        }
        public PictureBox GetPicture()
        {
            return PICTUREBOX;
        }


    }
}
