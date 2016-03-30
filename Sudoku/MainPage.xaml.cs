/* 
 * Copyright (C) Joni Korkiakoski
 * 
 * This file is part of the my school project.
 * 
 * Created: <<16.3.2016>> 
 * Authors: <<Joni Korkiakoski>> 
 * v0.3
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Sudoku
{
    /// <summary>
    /// Sudoku page
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void r1c1_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            //TextBox textBox = sender as TextBox;

            //Checking if input is correct type
            int num;

             if (int.TryParse(r1c1.Text, out num))
            {

            }
             else
            {

            }




        }
    }
    //JUST DO IT! >:O
}
