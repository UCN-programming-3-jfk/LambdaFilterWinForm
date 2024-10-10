using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using LambdaFilterWinForm.Model;

namespace LambdaFilterWinForm;
public partial class AdvancedMainForm : Form
{
    //create two lists for the unfiltered and filtered plants
    private BindingList<Plant> _plants = new();
    private BindingList<Plant> _filteredPlants = new();
    
    //create a dictionary to store the filter Funcs with the checkboxes as key
    Dictionary<CheckBox, Func<Plant, bool>> checkboxFilters = new();
    public AdvancedMainForm()
    {
        InitializeComponent();
        AddFlowers();

        //store the funcs as values in the dictionary with the checkboxes as key
        checkboxFilters.Add(chkRedOnes, (Plant p) => p.Color == Color.Red);
        checkboxFilters.Add(chkTallOnes, (Plant p) => p.HeightInCm > 100);
        checkboxFilters.Add(chkShortOnes, (Plant p) => p.HeightInCm <= 100);
        checkboxFilters.Add(chkYellowOnes, (Plant p) => p.Color == Color.Yellow);
        checkboxFilters.Add(chkToleratesShade, (Plant p) => p.ToleratesShade);
        
        //subscribe to the Filter button's Click event
        btnFilter.Click += (_, _) => Filter();

        //databind the listboxes to the lists, so they autoupdate when the list of items change
        lstAllPlants.DataSource = _plants;
        lstFilteredPlants.DataSource = _filteredPlants;
    }

    private void AddFlowers()
    {
        lstAllPlants.Items.Clear();
        foreach (var item in PlantDAL.GetPlants())
        {
            _plants.Add(item);
        }
    }

    private void Filter()
    {
        _filteredPlants.Clear();        //clear the filtered plants bindinglist
        var result = _plants.ToList();  //get all the plants

        //get all the checked boxes
        foreach (CheckBox box in Controls.OfType<CheckBox>().Where(chkBox => chkBox.Checked))
        {
            //find the filter in the dictionary and filter the results (again)
            result = result.Where(checkboxFilters[box]).ToList();
        }
        
        //add the filtered results to the _filteredPlants list
        result.ToList().ForEach(_filteredPlants.Add);
    }
}