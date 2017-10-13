using SkiaSharp;
using System.Collections.Generic;
using Xamarin.Forms;

namespace XamarinGraphics
{
    public partial class MainPage : ContentPage
    { 
        List<Microcharts.Entry> lista = new List<Microcharts.Entry>
        {
            new Microcharts.Entry(200)
            {
                Label = "Producto 1",
                ValueLabel = "5",
                Color = SKColor.Parse("#266489")
            },
            new Microcharts.Entry(250)
            {
                Label = "Producto 2",
                ValueLabel = "10",
                Color = SKColor.Parse("#68B9C0")
            },
            new Microcharts.Entry(100)
            {
                Label = "Producto 3",
                ValueLabel = "3",
                Color = SKColor.Parse("#90D585")
            },
            new Microcharts.Entry(150)
            {
                Label = "Producto 4",
                ValueLabel = "2",
                Color = SKColor.Parse("#e77e23")
            },
            new Microcharts.Entry(150)
            {
                Label = "Producto 5",
                ValueLabel = "8",
                Color = SKColor.Parse("#f55e11")
            },
        };
        
       public MainPage()
        {
            InitializeComponent();
        /*
            Grafico.Chart = new Microcharts.BarChart() { Entries = lista };

            Grafico2.Chart = new Microcharts.RadialGaugeChart() { Entries = lista };
            */
            Grafico3.Chart = new Microcharts.LineChart() { Entries = lista };
        }
    }
}
