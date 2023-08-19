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

        public int TILESIZE = 0;
        public int XPOS; // X position
        public int YPOS;// Y position
        public string BIOME;
        public int ID;
        public bool clicked = false;
        public bool exists = false;
        public Image texture;
        public Tile(int size,string biome,int id, int Xpos, int Ypos)
        {
            
            TILESIZE = size;
            BIOME = biome;
            XPOS = Xpos;
            YPOS = Ypos;
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
            this.TILE.Size = new System.Drawing.Size(TILESIZE, TILESIZE);
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
            this.PICTUREBOX.Size = new System.Drawing.Size(TILESIZE, TILESIZE);
            
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
            PICTUREBOX.Image = DesiredTexture;
            this.texture = DesiredTexture;
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
        public Panel getTile()
        {
            return TILE;
        }
        public PictureBox GetPicture()
        {
            return PICTUREBOX;
        }
        public Image getTexture()
        {
            return texture;
        }


    }
}
