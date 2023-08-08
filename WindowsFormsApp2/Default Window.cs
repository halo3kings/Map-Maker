/* Copyright (C) 2023 Austin Tyler - All Rights Reserved
 * You may use, distribute and modify this code under the
 * terms of the Attribution-ShareAlike 4.0 International, 
 * 
 * You should have received a copy of the Attribution-ShareAlike 4.0 International with
 * this file. If not, please write to: AustinTyler88@gmail.com
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{

    public partial class Default_Window : Form
    {
        int TotalNumberOfAssets = 10;
        string SelectedTexture = ""; //test
        bool[] TextureSelected;
        Bitmap Selected = new Bitmap(global::WindowsFormsApp2.Properties.Resources.Selected);
        public int AssetIconPictureBoxWidth = 104;
        public int AssetIconPictureBoxHeight = 84;

        [DllImport("Kernel32.dll")]
        static extern Boolean AllocConsole();

        public Default_Window()
        {
            InitializeComponent();
        }
        public void QuitButton(object sender, EventArgs e)
        {

        }
        private void New_Map(object sender, EventArgs e)
        {

        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
        private void Workspace_Paint(object sender, PaintEventArgs e)
        {

        }
        public void KeyPressed(object sender, KeyPressEventArgs e)
        {

        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine("pannel Clicked");
        }
        public void UnselectTexture()
        {
                SelectedTexture = "";
        }
        public string GetTextureSelected()
        {
            return SelectedTexture;
        }
        public void SetSelectedTexture(string texture)
        {
            SelectedTexture = texture;
        }

        //-----------------------------------------------------------Texture selected functionality --------------------------------------------
        //Updates the icon to show the user this is the one that is selected. 
        public void FloorTileAsset(object sender, EventArgs e)
        {
            Console.WriteLine($"|DefaultWindow| Floor Texture Asset Selected");
            UpdateIcons("Floor");
        }
        public void DirtTileAsset(object sender, EventArgs e)
        {
            Console.WriteLine($"|DefaultWindow| Dirt Texture Asset Selected");
            UpdateIcons("Dirt");
        }
        public void LooseRockAsset(object sender, EventArgs e)
        {
            Console.WriteLine($"|DefaultWindow| Loose Rock Texture Asset Selected");
            UpdateIcons("LooseRock");
        }
        public void HardRockAsset(object sender, EventArgs e)
        {
            Console.WriteLine($"|DefaultWindow| Hard Rock Texture Asset Selected");
            UpdateIcons("HardRock");
        }
        public void SolidRockAsset(object sender, EventArgs e)
        {
            Console.WriteLine($"|DefaultWindow| Solid Rock Texture Asset Selected");
            UpdateIcons("SolidRock");
        }
        public void ToolStoreAsset(object sender, EventArgs e)
        {
            Console.WriteLine($"|DefaultWindow| Tool Store Texture Asset Selected");
            UpdateIcons("ToolStore");
        }
        public void WaterAsset(object sender, EventArgs e)
        {
            Console.WriteLine($"|DefaultWindow| Water Texture Asset Selected");
            UpdateIcons("Water");
        }
        public void Rubble1Asset(object sender, EventArgs e)
        {
            Console.WriteLine($"|DefaultWindow| Rubble1 Texture Asset Selected");
            UpdateIcons("Rubble1");
        }
        public void Rubble2Asset(object sender, EventArgs e)
        {
            Console.WriteLine($"|DefaultWindow| Rubble2 Texture Asset Selected");
            UpdateIcons("Rubble2");
        }
        public void Rubble3Asset(object sender, EventArgs e)
        {
            Console.WriteLine($"|DefaultWindow| Rubble3 Texture Asset Selected");
            UpdateIcons("Rubble3");
        }
        public void LavaAsset(object sender, EventArgs e)
        {
            Console.WriteLine($"|DefaultWindow| Lava Texture Asset Selected");
            UpdateIcons("Lava");
        }
        public void Erosion2asset(object sender, EventArgs e)
        {
            Console.WriteLine($"|DefaultWindow| Erosion2 Texture Asset Selected");
            UpdateIcons("Erosion2");
        }
        public void Erosion1Asset(object sender, EventArgs e)
        {
            Console.WriteLine($"|DefaultWindow| Erosion1 Texture Asset Selected");
            UpdateIcons("Erosion1");
        }

        public void UpdateIcons(string selectedIcon)
        {
            switch(selectedIcon)
            {
                case "Floor":
                    {
                        Console.WriteLine($"|DefaultWindow| Floor Selected");
                        SelectTexture(pictureBox1, global::WindowsFormsApp2.Properties.Resources.Floor_Icon,"Floor");
                    }
                    break;
                case "Dirt":
                    {
                        Console.WriteLine($"|DefaultWindow| Dirt Selected");
                        SelectTexture(pictureBox2, global::WindowsFormsApp2.Properties.Resources.Dirt_Icon,"Dirt");
                    }
                    break;
                case "LooseRock":
                    {
                        Console.WriteLine($"|DefaultWindow| Loose Rock Selected");
                        SelectTexture(pictureBox3, global::WindowsFormsApp2.Properties.Resources.LooseRock_Icon,"LooseRock");
                    }
                    break;
                case "HardRock":
                    {
                        Console.WriteLine($"|DefaultWindow| Hard Rock Selected");
                        SelectTexture(pictureBox4, global::WindowsFormsApp2.Properties.Resources.HardRock_Icon,"HardRock");
                    }
                        break;
                case "SolidRock":
                    {
                        Console.WriteLine($"|DefaultWindow| Solid rock Selected");
                        SelectTexture(pictureBox5, global::WindowsFormsApp2.Properties.Resources.SolidRock_Icon,"SolidRock");
                    }
                    break;
                case "Rubble1":
                    {
                        Console.WriteLine($"|DefaultWindow| Rubble 1 Selected");
                        SelectTexture(pictureBox7, global::WindowsFormsApp2.Properties.Resources.Rubble1_Icon,"Rubble1");
                    }
                    break;
                case "Rubble2":
                    {
                        Console.WriteLine($"|DefaultWindow| Rubble 2 Selected");
                        SelectTexture(pictureBox8, global::WindowsFormsApp2.Properties.Resources.Rubble2_Icon,"Rubble2");
                    }
                    break;
                case "Rubble3":
                    {
                        Console.WriteLine($"|DefaultWindow| Rubble 3 Selected");
                        SelectTexture(pictureBox9, global::WindowsFormsApp2.Properties.Resources.Rubble3_Icon, "Rubble3");
                    }
                    break;
                case "Water":
                    {
                        Console.WriteLine($"|DefaultWindow| Water Selected");
                        SelectTexture(pictureBox6, global::WindowsFormsApp2.Properties.Resources.Water_Icon, "Water");
                    }
                    break;
                case "Lava":
                    {
                        Console.WriteLine($"|DefaultWindow| Lava Selected");
                        SelectTexture(pictureBox19, global::WindowsFormsApp2.Properties.Resources.Lava_Icon, "Lava");
                    }
                    break;
                case "Erosion1":
                    {
                        Console.WriteLine($"|DefaultWindow| Erosion1 Selected");
                        SelectTexture(pictureBox20, global::WindowsFormsApp2.Properties.Resources.LavaErosion1_Icon, "Erosion1");
                    }
                    break;
                case "Erosion2":
                    {
                        Console.WriteLine($"|DefaultWindow| Erosion2 Selected");
                        SelectTexture(pictureBox21,global::WindowsFormsApp2.Properties.Resources.LavaErosion2_Icon,"Erosion2");
                    }
                    break;
                //Buildings
                case "ToolStore":
                    {
                        Console.WriteLine($"|DefaultWindow| Tool Store selected");
                        SelectTexture(pictureBox21, global::WindowsFormsApp2.Properties.Resources.LavaErosion2_Icon, "Erosion2");
                    }
                    break;
            }

        }
   
        public void SelectTexture(PictureBox TextureButton, Image ImageOfTexture, string NameOfTexture)
        {
            Console.WriteLine($"|DefaultWindow| Selecting Texture");
            Bitmap Icon = new Bitmap(AssetIconPictureBoxWidth, AssetIconPictureBoxHeight);
            Graphics g = Graphics.FromImage(Icon);
            DefaultIconImage();

            if (!SelectedTexture.Equals(NameOfTexture))
            {
                SetSelectedTexture(NameOfTexture);
                Console.WriteLine($"|DefaultWindow| Name of texture: {NameOfTexture} is not equal to: {GetTextureSelected()} ");
                g.DrawImage(ImageOfTexture, 0, 0, AssetIconPictureBoxWidth, AssetIconPictureBoxHeight);
                g.DrawImage(Selected, 0, 0, AssetIconPictureBoxWidth, AssetIconPictureBoxHeight);
                TextureButton.Image = Icon;
            }
            else if (SelectedTexture.Equals(NameOfTexture))
            {
                Console.WriteLine($"|DefaultWindow| Name of texture {NameOfTexture} is equal to: {SelectedTexture} ");
                TextureButton.Image = ImageOfTexture;
                UnselectTexture();
            }
        }
        public void DefaultIconImage()
        {
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.Floor_Icon;
            this.pictureBox2.Image = global::WindowsFormsApp2.Properties.Resources.Dirt_Icon;
            this.pictureBox3.Image = global::WindowsFormsApp2.Properties.Resources.LooseRock_Icon;
            this.pictureBox4.Image = global::WindowsFormsApp2.Properties.Resources.HardRock_Icon;
            this.pictureBox5.Image = global::WindowsFormsApp2.Properties.Resources.SolidRock_Icon;
            this.pictureBox6.Image = global::WindowsFormsApp2.Properties.Resources.Water_Icon;
            this.pictureBox7.Image = global::WindowsFormsApp2.Properties.Resources.Rubble1_Icon;
            this.pictureBox8.Image = global::WindowsFormsApp2.Properties.Resources.Rubble2_Icon;
            this.pictureBox9.Image = global::WindowsFormsApp2.Properties.Resources.Rubble3_Icon;
            this.pictureBox19.Image = global::WindowsFormsApp2.Properties.Resources.Lava_Icon;
            this.pictureBox20.Image = global::WindowsFormsApp2.Properties.Resources.LavaErosion1_Icon;
            this.pictureBox21.Image = global::WindowsFormsApp2.Properties.Resources.LavaErosion2_Icon;

            this.pictureBox11.Image = global::WindowsFormsApp2.Properties.Resources.ToolStore_Icon;

        }
        //----------------------------------------------------------End of selected texture--------------------------------------------

        public void ExportMapImage(object sender, EventArgs e)
        {

        }

        public void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        public void SaveAs(object sender, EventArgs e)
        {
      
        }
    }
}



