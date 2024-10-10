using System;
using System.Windows.Forms;
using LambdaFilterWinForm.Model;
namespace LambdaFilterWinForm;
public partial class MainFormTemplate : Form
{
    public MainFormTemplate()
    {
        InitializeComponent();
        AddFlowers();
    }

    private void AddFlowers()
    {
        foreach (var item in PlantDAL.GetPlants())
        {
            lstAllPlants.Items.Add(item);   
        }
    }

  
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
}