using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;

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
        _plants.Add(new Plant() { Name = "Bonsai Weed", Color = Color.Red, HeightInCm = 80, ToleratesShade = false });
        _plants.Add(new Plant() { Name = "Bonsai Weed", Color = Color.Blue, HeightInCm = 80, ToleratesShade = true });
        _plants.Add(new Plant() { Name = "Mule stalk", Color = Color.White, HeightInCm = 20, ToleratesShade = true});
        _plants.Add(new Plant() { Name = "Little starstalk", Color = Color.Yellow, HeightInCm = 10, ToleratesShade = true });
        _plants.Add(new Plant() { Name = "Common grass", Color = Color.Green, HeightInCm = 12, ToleratesShade = true });
        _plants.Add(new Plant() { Name = "Orchard climber", Color = Color.Purple, HeightInCm = 180, ToleratesShade = false});
    }

    private void Filter(Func<Plant, bool> filter)
    {
        _filteredPlants.Clear();
        _plants.Where(filter).ToList().ForEach(_filteredPlants.Add);
    }
}