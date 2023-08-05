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
        //public Image getTexture(string selectedTexture)
        //{
            //return 
       // }
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

            SetSelectedTexture("");
        }
        public void UpdateIcons(string selectedIcon)
        {
            switch(selectedIcon)
            {
                case "Floor":
                    {
                        Console.WriteLine($"|DefaultWindow| Floor Selected");
                        DefaultIconImage();                        
                        if (!SelectedTexture.Equals("Floor"))
                        {
                            SetSelectedTexture("Floor");
                            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.Floor_Icon_Clicked;

                        }
                        else if (SelectedTexture.Equals("Floor"))
                        {
                            
                            UnselectTexture();
                        }
                    }
                    break;
                case "Dirt":
                    {
                        Console.WriteLine($"|DefaultWindow| Dirt Rock Selected");
                        DefaultIconImage();
                        if (!SelectedTexture.Equals("Dirt"))
                        {
                            SetSelectedTexture("Dirt");
                            this.pictureBox2.Image = global::WindowsFormsApp2.Properties.Resources.Dirt_Icon_Clicked;
                        }
                        else if (SelectedTexture.Equals("Dirt"))
                        {
                            UnselectTexture();
                        }
                    }
                    break;
                case "LooseRock":
                    {
                        Console.WriteLine($"|DefaultWindow| Loose Rock Selected");
                        DefaultIconImage();
                        if (!SelectedTexture.Equals("LooseRock"))
                        {
                            SetSelectedTexture("LooseRock");
                            this.pictureBox3.Image = global::WindowsFormsApp2.Properties.Resources.LooseRock_Icon_Clicked;
                        }
                    else if (SelectedTexture.Equals("LooseRock"))
                        {
                            UnselectTexture();
                        }

                    }
                    break;
                case "HardRock":
                    {
                        Console.WriteLine($"|DefaultWindow| Hard Rock Selected");
                        {
                            DefaultIconImage();
                            if (!SelectedTexture.Equals("HardRock"))
                            {
                                SetSelectedTexture("HardRock");
                                this.pictureBox4.Image = global::WindowsFormsApp2.Properties.Resources.HardRock_Icon_Clicked;
                            }
                            else if (SelectedTexture.Equals("HardRock"))
                            {
                                UnselectTexture();
                            }

                        }
                    }
                        break;
                case "SolidRock":
                    {
                        Console.WriteLine($"|DefaultWindow| Solid rock Selected");
                        DefaultIconImage();
                        if (!SelectedTexture.Equals("SolidRock"))
                        {
                            SetSelectedTexture("SolidRock");
                            this.pictureBox5.Image = global::WindowsFormsApp2.Properties.Resources.SolidRock_Icon_Clicked;
                        }
                        else if (SelectedTexture.Equals("SolidRock"))
                        {
                            UnselectTexture();
                        }
                    }
                    break;
                case "Rubble1":
                    {
                        Console.WriteLine($"|DefaultWindow| Rubble 1 Selected");
                        DefaultIconImage();
                        if (!SelectedTexture.Equals("Rubble1"))
                        {
                            SetSelectedTexture("Rubble1");
                            this.pictureBox7.Image = global::WindowsFormsApp2.Properties.Resources.Rubble1_Icon_Clicked;
                        }
                        else if (SelectedTexture.Equals("Rubble1"))
                        {
                            UnselectTexture();
                        }
                    }
                    break;
                case "Rubble2":
                    {
                        Console.WriteLine($"|DefaultWindow| Rubble 2 Selected");
                        DefaultIconImage();
                        if (!SelectedTexture.Equals("Rubble2"))
                        {
                            SetSelectedTexture("Rubble2");
                            this.pictureBox8.Image = global::WindowsFormsApp2.Properties.Resources.Rubble2_Icon_Clicked;
                        }
                        else if (SelectedTexture.Equals("Rubble2"))
                        {
                            UnselectTexture();
                        }
                    }
                    break;
                case "Rubble3":
                    {
                        Console.WriteLine($"|DefaultWindow| Rubble 3 Selected");
                        DefaultIconImage();
                        if (!SelectedTexture.Equals("Rubble3"))
                        {
                            SetSelectedTexture("Rubble3");
                            this.pictureBox9.Image = global::WindowsFormsApp2.Properties.Resources.Rubble3_Icon_Clicked;
                        }
                        else if (SelectedTexture.Equals("Rubble3"))
                        {
                            UnselectTexture();
                        }

                    }
                    break;
                case "Water":
                    {
                        Console.WriteLine($"|DefaultWindow| Water Selected");
                        DefaultIconImage();
                        if (!SelectedTexture.Equals("Water"))
                        {
                            SetSelectedTexture("Water");
                            this.pictureBox6.Image = global::WindowsFormsApp2.Properties.Resources.Water_Icon_Clicked;
                        }
                        else if (SelectedTexture.Equals("Water"))
                        {
                            UnselectTexture();
                        }

                    }
                    break;
                //Buildings
                case "ToolStore":
                    {
                        Console.WriteLine($"|DefaultWindow| Tool Store selected");
                        DefaultIconImage();
                        if (!SelectedTexture.Equals("ToolStore"))
                        {
                            SetSelectedTexture("ToolStore");
                            this.pictureBox5.Image = global::WindowsFormsApp2.Properties.Resources.ToolStore_Icon_Clicked;
                        }
                        else if (SelectedTexture.Equals("ToolStore"))
                        {
                            UnselectTexture();
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

        public void ExportMapImage(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void SaveAs(object sender, EventArgs e)
        {
      
        }
        //----------------------------------------------------------End of selected texture--------------------------------------------
    }
}



