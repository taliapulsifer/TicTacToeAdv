using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Media;
using TicTacToeAdv;

Window mainWindow = new();
mainWindow.Title = "Grid";

    //Create the Grid
    Grid dynamicGrid = new Grid();
    dynamicGrid.Width = 400;
    dynamicGrid.Height = 400;
    dynamicGrid.HorizontalAlignment = HorizontalAlignment.Left;
    dynamicGrid.VerticalAlignment = VerticalAlignment.Top;
    dynamicGrid.ShowGridLines = true;
    dynamicGrid.Background = new SolidColorBrush(Colors.AntiqueWhite);

    //Create Columns
    ColumnDefinition gridCol1 = new ColumnDefinition();
    ColumnDefinition gridCol2 = new ColumnDefinition();
    ColumnDefinition gridCol3 = new ColumnDefinition();
    dynamicGrid.ColumnDefinitions.Add(gridCol1);
    dynamicGrid.ColumnDefinitions.Add(gridCol2);
    dynamicGrid.ColumnDefinitions.Add(gridCol3);

    //Create Rows
    RowDefinition gridRow1 = new RowDefinition();
    gridRow1.Height = new GridLength(45);
    RowDefinition gridRow2 = new RowDefinition();
    gridRow2.Height = new GridLength(45);
    RowDefinition gridRow3 = new RowDefinition();
    gridRow3.Height = new GridLength(45);
    dynamicGrid.RowDefinitions.Add(gridRow1);
    dynamicGrid.RowDefinitions.Add(gridRow2);
    dynamicGrid.RowDefinitions.Add(gridRow3);

    //Display grid into a Window
    

namespace TicTacToeAdv
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //Press button once for O and twice for X, add choice to respective queue
    }

}

