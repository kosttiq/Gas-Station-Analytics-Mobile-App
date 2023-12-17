using App1.Models;
using App1.ViewModels;
using App1.Views;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microcharts;
using SkiaSharp;
using ChartEntry = Microcharts.ChartEntry;
using App1.Services;

namespace App1.Views
{
    public partial class ChartsPage : ContentPage
    {
        //ChartsViewModel _viewModel
        public ChartsPage()
        {
            InitializeComponent();

            DisplayChart();

            //BindingContext = _viewModel = new ChartsViewModel();
        }

        public void DisplayChart()
        {
            var barchartcomparsionentries = new[]
{
                 new ChartEntry(350)
                 {
                     Label = "АИ-92 " +
                     "План",
                     ValueLabel = "350",
                     Color = SKColor.Parse("#6666a3")
                 },
                 new ChartEntry(300)
                 {
                     Label = "АИ-92 " +
                     "Факт",

                     ValueLabel = "300",
                     Color = SKColor.Parse("#6666a3")
                 },
                 new ChartEntry(600)
                 {
                     Label = "АИ-95 " +
                     "План",
                     ValueLabel = "600",
                     Color = SKColor.Parse("#fbb4b4")
                 },
                 new ChartEntry(550)
                 {
                     Label = "АИ-95 " +
                     "Факт",
                     ValueLabel = "550",
                     Color = SKColor.Parse("#fbb4b4")
                 },
                 new ChartEntry(290)
                 {
                     Label = "АИ-98 " +
                     "План",
                     ValueLabel = "290",
                     Color = SKColor.Parse("#a1b88d")
                 },
                 new ChartEntry(300)
                 {
                     Label = "АИ-98 " +
                     "Факт",
                     ValueLabel = "300",
                     Color = SKColor.Parse("#a1b88d")
                 },
                 new ChartEntry(135)
                 {
                     Label = "Дизель " +
                     "План",
                     ValueLabel = "135",
                     Color = SKColor.Parse("#374f70")
                 },
                 new ChartEntry(150)
                 {
                     Label = "Дизель" +
                     "Факт",
                     ValueLabel = "150",
                     Color = SKColor.Parse("#374f70")
                 }

                 };

            var barchartcomparsion = new BarChart()
            {
                Entries = barchartcomparsionentries,
                LabelTextSize = 15,
                LabelColor = SKColor.Parse("#112B47"),
                LabelOrientation = Orientation.Horizontal,
                ValueLabelOrientation = Orientation.Vertical,
                MaxValue = 700,
                MinValue = 1,

            };
            this.barchartcomparsion.Chart = barchartcomparsion;

            var entries = new[]
            {
                 new ChartEntry(350)
                 {
                     Label = "АИ-92",
                     ValueLabel = "350",
                     Color = SKColor.Parse("#6666a3")
                 },
                 new ChartEntry(550)
                 {
                     Label = "АИ-95",
                     ValueLabel = "550",
                     Color = SKColor.Parse("#fbb4b4")
                 },
                 new ChartEntry(290)
                 {
                     Label = "АИ-98",
                     ValueLabel = "290",
                     Color = SKColor.Parse("#a1b88d")
                 },
                 new ChartEntry(150)
                 {
                     Label = "ДТ",
                     ValueLabel = "150",
                     Color = SKColor.Parse("#374f70")
                     
            }    };

            var barchart = new BarChart() { 
                Entries = entries,
                LabelTextSize = 45,
                LabelColor = SKColor.Parse("#112B47"),
                LabelOrientation = Orientation.Horizontal,
                ValueLabelOrientation = Orientation.Vertical,
                MaxValue = 600,
                MinValue = 100
                
            };
            this.barchart.Chart = barchart;


            var piechartentries = new[]
            {
                 new ChartEntry(7000)
                 {
                     Label = "АИ-92",
                     ValueLabel = "7.000",
                     Color = SKColor.Parse("#6666a3"),
                     ValueLabelColor = SKColor.Parse("#6666a3")
                 },
                 new ChartEntry(10000)
                 {
                     Label = "АИ-95",
                     ValueLabel = "10.000",
                     Color = SKColor.Parse("#fbb4b4"),
                     ValueLabelColor = SKColor.Parse("#fbb4b4")
                 },
                 new ChartEntry(5090)
                 {
                     Label = "АИ-98",
                     ValueLabel = "5.090",
                     Color = SKColor.Parse("#a1b88d"),
                     ValueLabelColor = SKColor.Parse("#a1b88d")
                 },
                 new ChartEntry(2500)
                 {
                     Label = "ДТ",
                     ValueLabel = "2.500",
                     Color = SKColor.Parse("#374f70"),
                     ValueLabelColor = SKColor.Parse("#374f70")

            }    };

            var piechart = new PieChart()
            {
                Entries = piechartentries,
                LabelTextSize = 45,
                //LabelColor = SKColor.Parse("#ffffff"),
                BackgroundColor = SKColor.Parse("#ffffff")
            };
            this.piechart.Chart = piechart;

            var linechartentries = new[]
            {
                 new ChartEntry(1450)
                 {
                     Label = "Янв. 2023",
                     ValueLabel = "1.450",
                     Color = SKColor.Parse("#000000"),
                     //ValueLabelColor = SKColor.Parse("#6666a3")
                 },
                 new ChartEntry(1230)
                 {
                     Label = "Фев. 2023",
                     ValueLabel = "1.230",
                     Color = SKColor.Parse("#000000"),
                     //ValueLabelColor = SKColor.Parse("#fbb4b4")
                 },
                 new ChartEntry(1480)
                 {
                     Label = "Мар. 2023",
                     ValueLabel = "1.480",
                     Color = SKColor.Parse("#000000"),
                     //ValueLabelColor = SKColor.Parse("#a1b88d")
                 },
                 new ChartEntry(1345)
                 {
                     Label = "Апр. 2023",
                     ValueLabel = "1.345",
                     Color = SKColor.Parse("#000000"),
                     //ValueLabelColor = SKColor.Parse("#374f70")
                 },
                 new ChartEntry(1310)
                 {
                     Label = "Май. 2023",
                     ValueLabel = "1.310",
                     Color = SKColor.Parse("#000000"),
                     //ValueLabelColor = SKColor.Parse("#a1b88d")
                 },
                 new ChartEntry(1490)
                 {
                     Label = "Июн. 2023",
                     ValueLabel = "1.490",
                     Color = SKColor.Parse("#000000"),
                     //ValueLabelColor = SKColor.Parse("#a1b88d")
                 },
                 new ChartEntry(1427)
                 {
                     Label = "Июл. 2023",
                     ValueLabel = "1.427",
                     Color = SKColor.Parse("#000000"),
                     //ValueLabelColor = SKColor.Parse("#a1b88d")
                 },
                 new ChartEntry(1398)
                 {
                     Label = "Авг. 2023",
                     ValueLabel = "1.398",
                     Color = SKColor.Parse("#000000"),
                     //ValueLabelColor = SKColor.Parse("#a1b88d")
                 },
                 new ChartEntry(1320)
                 {
                     Label = "Сен. 2023",
                     ValueLabel = "1.320",
                     Color = SKColor.Parse("#000000"),
                     //ValueLabelColor = SKColor.Parse("#a1b88d")
                 },
                 new ChartEntry(1294)
                 {
                     Label = "Окт. 2023",
                     ValueLabel = "1.294",
                     Color = SKColor.Parse("#000000"),
                     //ValueLabelColor = SKColor.Parse("#a1b88d")
                 },
                 new ChartEntry(1319)
                 {
                     Label = "Ноя. 2023",
                     ValueLabel = "1.319",
                     Color = SKColor.Parse("#000000"),
                     //ValueLabelColor = SKColor.Parse("#a1b88d")
                 },
                 new ChartEntry(1340)
                 {
                     Label = "Дек. 2023",
                     ValueLabel = "1.340",
                     Color = SKColor.Parse("#000000"),
                     //ValueLabelColor = SKColor.Parse("#a1b88d")

            }    };

            var linechart = new LineChart()
            {
                Entries = linechartentries,
                LabelTextSize = 45,
                //LabelColor = SKColor.Parse("#ffffff"),
                BackgroundColor = SKColor.Parse("#ffffff"),
                MaxValue = 1500,
                MinValue = 1100
            };
            this.linechart.Chart = linechart;

        }

    }

}