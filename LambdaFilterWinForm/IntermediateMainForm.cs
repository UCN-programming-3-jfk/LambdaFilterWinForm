using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using LambdaFilterWinForm.Model;

namespace LambdaFilterWinForm;

public partial class IntermediateMainForm : Form
{

    private static BindingList<Plant> _plants = new BindingList<Plant>();
    private static BindingList<Plant> _filteredPlants = new BindingList<Plant>();
    public IntermediateMainForm()
    {
        InitializeComponent();
        AddFlowers();
        
        //attach filter Funcs to Click events on buttons using Lambda discard syntax
        btnRedOnes.Click += (_, _) => Filter(p => p.Color == Color.Red);
        btnTallOnes.Click += (_,_) => Filter(p => p.HeightInCm > 100);
        btnShortOnes.Click += (_, _) => Filter(p => p.HeightInCm <= 100);
        btnYellowOnes.Click += (_, _) => Filter(p => p.Color == Color.Yellow);
        btnShadeTolerant.Click += (_, _) => Filter(p => p.ToleratesShade);
        
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

    private void Filter(Predicate<Plant> filter)
    {
        _filteredPlants.Clear();
        _plants.Where(plant => filter(plant)).ToList().ForEach(_filteredPlants.Add);
    }
}