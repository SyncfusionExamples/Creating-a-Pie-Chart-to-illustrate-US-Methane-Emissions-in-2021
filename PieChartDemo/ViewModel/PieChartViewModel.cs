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
            new PieChartModel() { EmissionSource = "Natural Gas and Petroleum Systems", EmissionPercentage = 32},
            new PieChartModel() { EmissionSource = "Enteric Fermentation", EmissionPercentage = 27},
            new PieChartModel() { EmissionSource = "MSW Landfills", EmissionPercentage = 14 },
            new PieChartModel() { EmissionSource = "Other Landfills", EmissionPercentage = 3 },
            new PieChartModel() { EmissionSource = "Manure Management", EmissionPercentage = 9 },
            new PieChartModel() { EmissionSource = "Coal Mining", EmissionPercentage = 6 },
            new PieChartModel() { EmissionSource = "Other", EmissionPercentage = 9 }
            };

            CustomBrushes = new List<Brush>();
            CustomBrushes.Add(new SolidColorBrush(Color.FromArgb("#0E778A")));
            CustomBrushes.Add(new SolidColorBrush(Color.FromArgb("#3499AB")));
            CustomBrushes.Add(new SolidColorBrush(Color.FromArgb("#199CB3")));
            CustomBrushes.Add(new SolidColorBrush(Color.FromArgb("#42B6CB")));
            CustomBrushes.Add(new SolidColorBrush(Color.FromArgb("#6BCBDC")));
            CustomBrushes.Add(new SolidColorBrush(Color.FromArgb("#84D7E6")));
            CustomBrushes.Add(new SolidColorBrush(Color.FromArgb("#89DCEb")));
        }

        public List<PieChartModel> Data { get; set; }
        public List<Brush> CustomBrushes { get; set; }
    }
}
