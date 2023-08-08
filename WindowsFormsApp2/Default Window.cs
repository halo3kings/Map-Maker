/* Copyright (C) 2023 Austin Tyler - All Rights Reserved
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
            Console.WriteLine($"|DefaultWindow| Floor Icon Selected");
            SelectTexture(FloorIcon, global::WindowsFormsApp2.Properties.Resources.Floor_Icon, "Floor");
        }
        public void DirtTileAsset(object sender, EventArgs e)
        {
            Console.WriteLine($"|DefaultWindow| Dirt Icon Selected");
            SelectTexture(DirtIcon, global::WindowsFormsApp2.Properties.Resources.Dirt_Icon, "Dirt");
        }
        public void LooseRockAsset(object sender, EventArgs e)
        {
            Console.WriteLine($"|DefaultWindow| Loose Rock Icon Selected");
            SelectTexture(LooseRockIcon, global::WindowsFormsApp2.Properties.Resources.LooseRock_Icon, "LooseRock");
        }
        public void HardRockAsset(object sender, EventArgs e)
        {
            Console.WriteLine($"|DefaultWindow| Hard Rock Icon Selected");
            SelectTexture(HardRockIcon, global::WindowsFormsApp2.Properties.Resources.HardRock_Icon, "HardRock");
        }
        public void SolidRockAsset(object sender, EventArgs e)
        {
            Console.WriteLine($"|DefaultWindow| Solid Rock Icon Selected");
            SelectTexture(SolidRockIcon, global::WindowsFormsApp2.Properties.Resources.SolidRock_Icon, "SolidRock");
        }
        public void WaterAsset(object sender, EventArgs e)
        {
            Console.WriteLine($"|DefaultWindow| Water Icon Selected");
            SelectTexture(WaterIcon, global::WindowsFormsApp2.Properties.Resources.Water_Icon, "Water");
        }
        public void Rubble1Asset(object sender, EventArgs e)
        {
            Console.WriteLine($"|DefaultWindow| Rubble1 Icon Selected");
            SelectTexture(Rubble1Icon, global::WindowsFormsApp2.Properties.Resources.Rubble1_Icon, "Rubble1");
        }
        public void Rubble2Asset(object sender, EventArgs e)
        {
            Console.WriteLine($"|DefaultWindow| Rubble2 Icon Selected");
            SelectTexture(Rubble2Icon, global::WindowsFormsApp2.Properties.Resources.Rubble2_Icon, "Rubble2");
        }
        public void Rubble3Asset(object sender, EventArgs e)
        {
            Console.WriteLine($"|DefaultWindow| Rubble3 Icon Selected");
            SelectTexture(Rubble3Icon, global::WindowsFormsApp2.Properties.Resources.Rubble3_Icon, "Rubble3");
        }
        public void LavaAsset(object sender, EventArgs e)
        {
            Console.WriteLine($"|DefaultWindow| Lava Icon Selected");
            SelectTexture(LavaIcon, global::WindowsFormsApp2.Properties.Resources.Lava_Icon, "Lava");
        }
        public void Erosion2asset(object sender, EventArgs e)
        {
            Console.WriteLine($"|DefaultWindow| Erosion2 Icon Selected");
            SelectTexture(LavaErosion2Icon, global::WindowsFormsApp2.Properties.Resources.LavaErosion2_Icon, "Erosion2");
        }
        public void Erosion1Asset(object sender, EventArgs e)
        {
            Console.WriteLine($"|DefaultWindow| Erosion1 Icon Selected");
            SelectTexture(LavaErosion1Icon, global::WindowsFormsApp2.Properties.Resources.LavaErosion1_Icon, "Erosion1");
        }
        //Buildings-----------------------------------------------------------------
        //--ToolStore
        public void ToolStoreAsset(object sender, EventArgs e)
        {
            Console.WriteLine($"|DefaultWindow|ToolStoreAsset()| Tool Store Icon Selected");
            SelectTexture(ToolStoreIcon, global::WindowsFormsApp2.Properties.Resources.ToolStore_Icon, "ToolStore");
        }
        //--Telepad
        public void TelePadAsset(object sender, EventArgs e)
        {
            Console.WriteLine($"|DefaultWindow|TelePadAsset()| TelePad Icon Selected");
            SelectTexture(TelePadIcon, global::WindowsFormsApp2.Properties.Resources.TelePad_Icon, "TelePad");
        }
        //--Dock
        public void DockAsset(object sender, EventArgs e)
        {
            Console.WriteLine($"|DefaultWindow|DocAsset()| Dock Icon Selected");
            SelectTexture(DockIcon, global::WindowsFormsApp2.Properties.Resources.Dock_Icon, "Dock");
        }
        //--PowerPlant
        public void PowerPlantAsset(object sender, EventArgs e)
        {
            Console.WriteLine($"|DefaultWindow|PowerPlantPadAsset()| PowerPlant Icon Selected");
            SelectTexture(PowerPlantIcon, global::WindowsFormsApp2.Properties.Resources.PowerPlant_Icon, "PowerPlant");
        }
        //--Support Station
        public void SuportStationAsset(object sender, EventArgs e)
        {
            Console.WriteLine($"|DefaultWindow|SuportStationPadAsset()| SuportStation Icon Selected");
            SelectTexture(SuportStationIcon, global::WindowsFormsApp2.Properties.Resources.SupportStation_Icon, "SuportStation");
        }
        //--UpgradeStation
        public void UpgradeStationAsset(object sender, EventArgs e)
        {
            Console.WriteLine($"|DefaultWindow|UpgradeStationAsset()| UpgradeStation Icon Selected");
            SelectTexture(UpgradeStationIcon, global::WindowsFormsApp2.Properties.Resources.UpgradeStation_Icon, "UpgradeStation");
        }
        //--Ore refinery
        public void OreRefineAsset(object sender, EventArgs e)
        {
            Console.WriteLine($"|DefaultWindow|OreRefineAsset()| OreRefine Icon Selected");
            SelectTexture(OreRefineIcon, global::WindowsFormsApp2.Properties.Resources.OreRefine_Icon, "OreRefine");
        }
        //--geological  center
        public void GeoCenterAsset(object sender, EventArgs e)
        {
            Console.WriteLine($"|DefaultWindow|GeoCenterAsset()| GeoCenter Icon Selected");
            SelectTexture(GeoCenterIcon, global::WindowsFormsApp2.Properties.Resources.GeoCent_Icon, "GeoCenter");
        }
        //--Super Teleporter 
        public void SuperTeleAsset(object sender, EventArgs e)
        {
            Console.WriteLine($"|DefaultWindow|SuperTeleAsset()| SuperTele Icon Selected");
            SelectTexture(SuperTeleIcon, global::WindowsFormsApp2.Properties.Resources.SuperTele_Icon, "SuperTele");
        }
        //--Lazer
        public void LazerAsset(object sender, EventArgs e)
        {
            Console.WriteLine($"|DefaultWindow|LazerAsset()| Lazer Icon Selected");
            SelectTexture(LazerIcon, global::WindowsFormsApp2.Properties.Resources.Lazer, "Lazer");
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
            //Rock Biome Icons
            this.FloorIcon.Image = global::WindowsFormsApp2.Properties.Resources.Floor_Icon;
            this.DirtIcon.Image = global::WindowsFormsApp2.Properties.Resources.Dirt_Icon;
            this.LooseRockIcon.Image = global::WindowsFormsApp2.Properties.Resources.LooseRock_Icon;
            this.HardRockIcon.Image = global::WindowsFormsApp2.Properties.Resources.HardRock_Icon;
            this.SolidRockIcon.Image = global::WindowsFormsApp2.Properties.Resources.SolidRock_Icon;
            this.WaterIcon.Image = global::WindowsFormsApp2.Properties.Resources.Water_Icon;
            this.Rubble1Icon.Image = global::WindowsFormsApp2.Properties.Resources.Rubble1_Icon;
            this.Rubble2Icon.Image = global::WindowsFormsApp2.Properties.Resources.Rubble2_Icon;
            this.Rubble3Icon.Image = global::WindowsFormsApp2.Properties.Resources.Rubble3_Icon;
            this.LavaIcon.Image = global::WindowsFormsApp2.Properties.Resources.Lava_Icon;
            this.LavaErosion1Icon.Image = global::WindowsFormsApp2.Properties.Resources.LavaErosion1_Icon;
            this.LavaErosion2Icon.Image = global::WindowsFormsApp2.Properties.Resources.LavaErosion2_Icon;

            //Ice Biome Icons
            this.LavaIcon.Image = global::WindowsFormsApp2.Properties.Resources.Lava_Icon;
            this.WaterIcon.Image = global::WindowsFormsApp2.Properties.Resources.Water_Icon;

            //Lava Biome Icons
            this.LavaIcon.Image = global::WindowsFormsApp2.Properties.Resources.Lava_Icon;
            this.WaterIcon.Image = global::WindowsFormsApp2.Properties.Resources.Water_Icon;

            //Buidling Icons
            this.ToolStoreIcon.Image = global::WindowsFormsApp2.Properties.Resources.ToolStore_Icon;
            this.TelePadIcon.Image = global::WindowsFormsApp2.Properties.Resources.TelePad_Icon;
            this.DockIcon.Image = global::WindowsFormsApp2.Properties.Resources.Dock_Icon;
            this.PowerPlantIcon.Image = global::WindowsFormsApp2.Properties.Resources.PowerPlant_Icon;
            this.SuportStationIcon.Image = global::WindowsFormsApp2.Properties.Resources.SupportStation_Icon;
            this.UpgradeStationIcon.Image = global::WindowsFormsApp2.Properties.Resources.UpgradeStation_Icon;
            this.GeoCenterIcon.Image = global::WindowsFormsApp2.Properties.Resources.GeoCent_Icon;
            this.OreRefineIcon.Image = global::WindowsFormsApp2.Properties.Resources.OreRefine_Icon;
            this.SuperTeleIcon.Image = global::WindowsFormsApp2.Properties.Resources.SuperTele_Icon;
            this.LazerIcon.Image = global::WindowsFormsApp2.Properties.Resources.Lazer_Icon;
            

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



