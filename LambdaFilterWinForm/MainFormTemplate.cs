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

    //1) Add button click handlers which send a func to the filter function


    //2) Add the filter function here which
    // - takes a func which accepts a Plant and returns a bool (you may use a predicate if you prefer)
    
}