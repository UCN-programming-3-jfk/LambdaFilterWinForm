using System;
using System.Drawing;
using System.Windows.Forms;
using LambdaFilterWinForm.Model;
namespace LambdaFilterWinForm;
public partial class MainFormSolved : Form
{
    public MainFormSolved()
    {
        InitializeComponent();
        AddFlowers();
    }
    private void AddFlowers()
    {
        lstAllPlants.Items.Clear();
        foreach (var item in PlantDAL.GetPlants())
        {
            lstAllPlants.Items.Add(item);   
        }
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