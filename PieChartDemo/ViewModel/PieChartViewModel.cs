using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieChartDemo
{
    public class PieChartViewModel
    {
        public PieChartViewModel()
        {
            Data = new List<PieChartModel>()
            {
            new PieChartModel() { CrimeBiasType = "Race/Ethnicity/Ancestry", PercentageOfVictims = 65.64461965,Victims = 4496 },
            new PieChartModel() { CrimeBiasType = "Religion", PercentageOfVictims = 14.79048, Victims = 1013 },
            new PieChartModel() { CrimeBiasType = "Sexual Orientation", PercentageOfVictims = 16.52796, Victims = 1132 },
            new PieChartModel() { CrimeBiasType = "Disability", PercentageOfVictims = 1.985691, Victims = 136 },
            new PieChartModel() { CrimeBiasType = "Gender", PercentageOfVictims = 1.051248, Victims = 72 }
            };

            CustomBrushes = new List<Brush>();
            CustomBrushes.Add(new SolidColorBrush(Color.FromArgb("#FF701421")));
            CustomBrushes.Add(new SolidColorBrush(Color.FromArgb("#FFBA261A")));
            CustomBrushes.Add(new SolidColorBrush(Color.FromArgb("#FFEB3527")));
            CustomBrushes.Add(new SolidColorBrush(Color.FromArgb("#FFF6ABAF")));
            CustomBrushes.Add(new SolidColorBrush(Color.FromArgb("#FFF5D3D4")));
        }

        public List<PieChartModel> Data { get; set; }
        public List<Brush> CustomBrushes { get; set; }
    }
}
