﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace B410226872
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }

       

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            DrawingAttributes da = new DrawingAttributes();
            da.Color = Colors.Green;
            da.Width = 10;
            DefaultDrawingAttributes = da;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            DrawingAttributes da = new DrawingAttributes();
            da.Color = Colors.Green;
            da.Width = 10;
            mydraw.DefaultDrawingAttributes = da;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            DrawingAttributes da = new DrawingAttributes();
            da.Color = Colors.Green;
            da.Width = 10;
            mydraw.DefaultDrawingAttributes = da;
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            DrawingAttributes da = new DrawingAttributes();
            da.Color = Colors.Green;
            da.Width = 10;
            mydraw.DefaultDrawingAttributes = da;
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            var fullFilePath = @"C:\Users\Public\Pictures\Sample Pictures\Desert";

            FileInfo fi = new FileInfo(fullFilePath);

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(fullFilePath, UriKind.Absolute);
            bitmap.EndInit();


            image1.Source = bitmap;
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            var fullFilePath = @"C:\Users\Public\Pictures\Sample Pictures\Hydrangeas";

            FileInfo fi = new FileInfo(fullFilePath);

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(fullFilePath, UriKind.Absolute);
            bitmap.EndInit();


            image1.Source = bitmap;
        }

       
    }
}
