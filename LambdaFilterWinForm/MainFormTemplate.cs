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

    //Add button click handlers which send a func to the filter function

    //Add filter function here, which takes a func that accepts a Plant and returns a bool

}