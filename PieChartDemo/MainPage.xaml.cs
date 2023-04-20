using Syncfusion.Maui.Charts;
using System.Globalization;

namespace PieChartDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }
    
    public class ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            TooltipInfo tooltipInfo = (TooltipInfo)value;

            if (tooltipInfo != null)
            {
                var viewModel = (tooltipInfo.Source as PieSeries).BindingContext as PieChartViewModel;
                return (viewModel.CustomBrushes[tooltipInfo.Index] as SolidColorBrush).Color;
            }
            else { return null; }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

