using System;
using System.Collections.Generic;
using System.Linq;
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
        public int ID = 0;
        public int TILEID = 0;
        public Tile(int id, int TileID)
        {
            ID = id;
            TILEID = TileID;

            InitializePictureBox();
            
            
            //This must be last.
            InitializeTile();
        }
        public void InitializeTile()
        {
            //has picture

            //Generic window information
            this.TILE.BackColor = System.Drawing.SystemColors.Window;
            this.TILE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            //top  left  corner  orgin
            this.TILE.Location = new System.Drawing.Point(0, 0);

            //"TILE" will  be the default name with the added ID number on the end
            this.TILE.Name = "TILE" + ID;

            //This sets the panel's Height and Width.
            this.TILE.Size = new System.Drawing.Size(256, 256);

            // picture
            this.TILE.Controls.Add(PICTUREBOX);
            this.TILE.Click += new System.EventHandler(this.OnClick);
        }
        public void InitializePictureBox()
        {
            //fill the TILE
            this.PICTUREBOX.Dock = System.Windows.Forms.DockStyle.Fill;

            //The image asset
            this.PICTUREBOX.Image = WindowsFormsApp2.Properties.Resources._256x256;
            
            // orgin
            this.PICTUREBOX.Location = new System.Drawing.Point(0, 0);
            
            //name
            this.PICTUREBOX.Name = "pictureBox" + ID;
            
            //size of picture box
            this.PICTUREBOX.Size = new System.Drawing.Size(256, 256);
            
            //should the container be expanded, the image will strech to fit
            this.PICTUREBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }
        public void OnClick(object sender, EventArgs e)
        {

        }
    }
}
