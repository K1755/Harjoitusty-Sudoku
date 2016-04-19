/* 
 * Copyright (C) Joni Korkiakoski
 * 
 * This file is part of the my school project.
 * 
 * Created: <<16.3.2016>> 
 * Authors: <<Joni Korkiakoski>> 
 * v0.4.6
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            TextBox textBox = sender as TextBox;

            //Checking if input is correct type
            int num;

            if (int.TryParse(textBox.Text, out num))
            {

            }
             else
            {
                
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int[,] array = new int[9, 9];

            array[0, 0] = 10;

            foreach (Object control in Gridi.Children)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    int value;
                    bool result = int.TryParse(textBox.Text, out value);
                    // oliko numero
                    if (result)
                    {
                        if(value >= 1 || value <= 9)
                        {
                            
                        }

                        Debug.WriteLine(value);
                    }
                }
            }
        }

    }
}
    //JUST DO IT! >:O
