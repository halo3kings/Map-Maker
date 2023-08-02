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
        bool[] TextureSelected;

        [DllImport("Kernel32.dll")]
        static extern Boolean AllocConsole();

        public Default_Window()
        {
            InitializeComponent();
            InitializeTextureSelectedArray();

        }
        private void InitializeTextureSelectedArray()
        {
            TextureSelected = new bool[TotalNumberOfAssets];
            DeselectTexture();

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
        public void DeselectTexture()
        {
            for (int i = 0; i < TotalNumberOfAssets; i++)
            {
                TextureSelected[i] = false;
            }
        }
        public int GetSelectedTexture()
        {
            for (int i = 0; i < TotalNumberOfAssets; i++)
            {
                if (TextureSelected[i] == true)
                {
                    return i;
                }
            }
            return 0;
        }
        public void SetSelectedTexture(int texture)
        {
            for (int i = 0; i < TotalNumberOfAssets; i++)
            {
                if (i == texture)
                {
                    TextureSelected[i] = true;
                }
                else
                {
                    TextureSelected[i] = false;
                }
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

            this.pictureBox11.Image = global::WindowsFormsApp2.Properties.Resources.ToolStore_Icon;


        }
        public void UpdateIcons(string selectedIcon)
        {
            switch(selectedIcon)
            {
                case "Floor":
                    {
                        DefaultIconImage();                        
                        if (TextureSelected[0] == false)
                        {
                            SetSelectedTexture(0);
                            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.Floor_Icon_Clicked;

                        }
                        else if (TextureSelected[0] == true)
                        {
                            DeselectTexture();
                        }
                    }
                    break;
                case "Dirt":
                    {
                        DefaultIconImage();
                        if (TextureSelected[1] == false)
                        {
                            SetSelectedTexture(1);
                            this.pictureBox2.Image = global::WindowsFormsApp2.Properties.Resources.Dirt_Icon_Clicked;
                        }
                        else if (TextureSelected[1] == true)
                        {
                            DeselectTexture();
                        }
                    }
                    break;
                case "LooseRock":
                    { 
                         DefaultIconImage();
                         if (TextureSelected[2] == false)
                        {
                            SetSelectedTexture(2);
                            this.pictureBox3.Image = global::WindowsFormsApp2.Properties.Resources.LooseRock_Icon_Clicked;
                        }
                    else if (TextureSelected[2] == true)
                        {
                            DeselectTexture();
                        }

                    }
                    break;
                case "HardRock":
                    {
                        {
                            DefaultIconImage();
                            if (TextureSelected[3] == false)
                            {
                                SetSelectedTexture(3);
                                this.pictureBox4.Image = global::WindowsFormsApp2.Properties.Resources.HardRock_Icon_Clicked;
                            }
                            else if (TextureSelected[3] == true)
                            {
                                DeselectTexture();
                            }

                        }
                    }
                        break;
                case "SolidRock":
                    {
                        DefaultIconImage();
                        if (TextureSelected[4] == false)
                        {
                            SetSelectedTexture(4);
                            this.pictureBox5.Image = global::WindowsFormsApp2.Properties.Resources.SolidRock_Icon_Clicked;
                        }
                        else if (TextureSelected[4] == true)
                        {
                            DeselectTexture();
                        }
                    }
                    break;
                case "Rubble1":
                    {
                        DefaultIconImage();
                        if (TextureSelected[7] == false)
                        {
                            SetSelectedTexture(7);
                            this.pictureBox7.Image = global::WindowsFormsApp2.Properties.Resources.Rubble1_Icon_Clicked;
                        }
                        else if (TextureSelected[7] == true)
                        {
                            DeselectTexture();
                        }
                    }
                    break;
                case "Rubble2":
                    {
                        DefaultIconImage();
                        if (TextureSelected[8] == false)
                        {
                            SetSelectedTexture(8);
                            this.pictureBox8.Image = global::WindowsFormsApp2.Properties.Resources.Rubble2_Icon_Clicked;
                        }
                        else if (TextureSelected[8] == true)
                        {
                            DeselectTexture();
                        }
                    }
                    break;
                case "Rubble3":
                    {
                        DefaultIconImage();
                        if (TextureSelected[9] == false)
                        {
                            SetSelectedTexture(9);
                            this.pictureBox9.Image = global::WindowsFormsApp2.Properties.Resources.Rubble3_Icon_Clicked;
                        }
                        else if (TextureSelected[9] == true)
                        {
                            DeselectTexture();
                        }

                    }
                    break;
                case "Water":
                    {
                        DefaultIconImage();
                        if (TextureSelected[6] == false)
                        {
                            SetSelectedTexture(6);
                            this.pictureBox6.Image = global::WindowsFormsApp2.Properties.Resources.Water_Icon_Clicked;
                        }
                        else if (TextureSelected[9] == true)
                        {
                            DeselectTexture();
                        }

                    }
                    break;
                //Buildings
                case "ToolStore":
                    {
                        DefaultIconImage();
                        if (TextureSelected[9] == false)
                        {
                            SetSelectedTexture(5);
                            this.pictureBox5.Image = global::WindowsFormsApp2.Properties.Resources.ToolStore_Icon_Clicked;
                        }
                        else if (TextureSelected[5] == true)
                        {
                            DeselectTexture();
                        }

                    }
                    break;
            }

        }
    
        //-----------------------------------------------------------Texture selected --------------------------------------------
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
        //----------------------------------------------------------End of selected texture--------------------------------------------
    }
}



