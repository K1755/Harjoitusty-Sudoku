/* 
 * Copyright (C) Joni Korkiakoski
 * 
 * This file is part of the my school project.
 * 
 * Created: <<16.3.2016>> 
 * Authors: <<Joni Korkiakoski>> 
 * v0.4.8
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
            //Sudoku array
            int[,] array = new int[9, 9];
            /*int[,][,] arrayJagged = new int[3,3][3,3]*/

            //array[0, 0] = 1;

            foreach (Object control in Gridi.Children)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    int value;

                    bool result = int.TryParse(textBox.Text, out value);

                    for(value = 0; value <= 9; )
                    {

                    }

                    // oliko numero
                    if (result)
                    {
                        Debug.WriteLine(value);
                    }
                        
                }
            }
        }
    }

}
//JUST DO IT! >:O
//Opettele kommentoimaan. >:/

/*if ()
{
Textbox00.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox01.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox02.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox03.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox04.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox05.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox06.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox07.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox08.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox09.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox10.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox11.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox12.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox13.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox14.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox15.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox16.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox17.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox18.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox19.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox20.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox21.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox22.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox23.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox24.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox25.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox26.Background = new SolidColorBrush(Windows.UI.Colors.Red);
//Textbox27.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox28.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox29.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox30.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox31.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox32.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox33.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox34.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox35.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox36.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox37.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox38.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox39.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox40.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox41.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox42.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox43.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox44.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox45.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox46.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox47.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox48.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox49.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox50.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox51.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox52.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox53.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox54.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox55.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox56.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox57.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox58.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox59.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox60.Background = new SolidColorBrush(Windows.UI.Colors.Red);
//Textbox61.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox62.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox63.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox64.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox65.Background = new SolidColorBrush(Windows.UI.Colors.Red);
//Textbox66.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox67.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox68.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox69.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox70.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox71.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox72.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox73.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox74.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox75.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox76.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox77.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox78.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox79.Background = new SolidColorBrush(Windows.UI.Colors.Red);
Textbox80.Background = new SolidColorBrush(Windows.UI.Colors.Red);
                        }
                        else
                        {
                            
                            Textbox00.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox01.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox02.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox03.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox04.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox05.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox06.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox07.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox08.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox09.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox10.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox11.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox12.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox13.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox14.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox15.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox16.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox17.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox18.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox19.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox20.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox21.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox22.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox23.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox24.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox25.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox26.Background = new SolidColorBrush(Windows.UI.Colors.Green);
//Textbox27.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox28.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox29.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox30.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox31.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox32.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox33.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox34.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox35.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox36.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox37.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox38.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox39.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox40.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox41.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox42.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox43.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox44.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox45.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox46.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox47.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox48.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox49.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox50.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox51.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox52.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox53.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox54.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox55.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox56.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox57.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox58.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox59.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox60.Background = new SolidColorBrush(Windows.UI.Colors.Green);
//Textbox61.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox62.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox63.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox64.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox65.Background = new SolidColorBrush(Windows.UI.Colors.Green);
//Textbox66.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox67.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox68.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox69.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox70.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox71.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox72.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox73.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox74.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox75.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox76.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox77.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox78.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox79.Background = new SolidColorBrush(Windows.UI.Colors.Green);
Textbox80.Background = new SolidColorBrush(Windows.UI.Colors.Green);
}*/
