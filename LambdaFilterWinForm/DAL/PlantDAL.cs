using System.Collections.Generic;
using System.Drawing;
namespace LambdaFilterWinForm.Model;
public static class PlantDAL
{
    public static IEnumerable<Plant> GetPlants() {
        return new List<Plant>() { 
        new Plant() { Name = "Bonsai Weed", Color = Color.Red, HeightInCm = 80, ToleratesShade = false },
        new Plant() { Name = "Bonsai Weed", Color = Color.Blue, HeightInCm = 80, ToleratesShade = true },
        new Plant() { Name = "Mule stalk", Color = Color.White, HeightInCm = 20, ToleratesShade = true },
        new Plant() { Name = "Little starstalk", Color = Color.Yellow, HeightInCm = 10, ToleratesShade = true },
        new Plant() { Name = "Common grass", Color = Color.Green, HeightInCm = 12, ToleratesShade = true },
        new Plant() { Name = "Orchard climber", Color = Color.Purple, HeightInCm = 180, ToleratesShade = false } };
    }
}