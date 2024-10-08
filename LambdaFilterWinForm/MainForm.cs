using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace LambdaFilterWinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            AddFlowers();
        }

        private void AddFlowers()
        {
            lstAllPlants.Items.Add(new Plant() { Name = "Bonsai Weed", Color = Color.Red, HeightInCm = 80, ToleratesShade = false });
            lstAllPlants.Items.Add(new Plant() { Name = "Bonsai Weed", Color = Color.Blue, HeightInCm = 80, ToleratesShade = true });
            lstAllPlants.Items.Add(new Plant() { Name = "Mule stalk", Color = Color.White, HeightInCm = 20, ToleratesShade = true});
            lstAllPlants.Items.Add(new Plant() { Name = "Little starstalk", Color = Color.Yellow, HeightInCm = 10, ToleratesShade = true });
            lstAllPlants.Items.Add(new Plant() { Name = "Common grass", Color = Color.Green, HeightInCm = 12, ToleratesShade = true });
            lstAllPlants.Items.Add(new Plant() { Name = "Orchard climber", Color = Color.Purple, HeightInCm = 180, ToleratesShade = false});
        }

        private void btnTallOnes_Click(object sender, EventArgs e) => Filter((Plant p) => p.HeightInCm > 100);
        private void btnShortOnes_Click(object sender, EventArgs e) => Filter((Plant p) => p.HeightInCm <= 100);
        private void btnRedOnes_Click(object sender, EventArgs e) => Filter((Plant p) => p.Color == Color.Red);
        private void btnYellowOnes_Click(object sender, EventArgs e) => Filter((Plant p) => p.Color == Color.Yellow);
        private void btnShadeTolerant_Click(object sender, EventArgs e) => Filter((Plant p) => p.ToleratesShade);
        private void Filter(Func<Plant, bool> filter)
        {
            lstFilteredPlants.Items.Clear();
            foreach (var plant in lstAllPlants.Items)
            {
                if (filter((Plant)plant))
                {
                    lstFilteredPlants.Items.Add(plant);
                }
            }
        }
        //Example of writing the Filter method using LINQ:
        //private void FilterLinq(Func<Plant, bool> filter)
        //{
        //    lstFilteredPlants.Items.AddRange(lstAllPlants.Items.OfType<Plant>().Where(plant => filter(plant)).ToArray());
        //}
    }
}