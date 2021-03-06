﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GreenFox;

namespace Ex4_ToTheCenter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();
            StartPoint(100, 40);
            StartPoint(250, 100);
            StartPoint(200, 70);
        }

        public void StartPoint(int x, int y)
        {
            var foxie = new FoxDraw(canvas);
            Color randomColor = Color.FromRgb((byte)rnd.Next(256), (byte)rnd.Next(256), (byte)rnd.Next(256));
            foxie.StrokeColor(randomColor);
            foxie.DrawLine(x, y, 150, 150);
        }
    }
}
