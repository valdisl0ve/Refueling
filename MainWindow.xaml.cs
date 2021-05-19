using System;
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

namespace Fuel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double fuel_type_coefficient = 0.16;
        public MainWindow()
        {
            InitializeComponent();
            
        }

       

        private void fuelList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            

            if (fuelList.SelectedItem.ToString().Contains("95"))
            {
                
                fuel_type_coefficient =  0.16;
                MessageBox.Show( "FUEL TYPE 95! PRICE IS - " + fuel_type_coefficient + "$/L");
            }
            
            if (fuelList.SelectedItem.ToString().Contains("92"))
            {
                
                fuel_type_coefficient =  0.15;
                MessageBox.Show( "FUEL TYPE 92! PRICE IS - " + fuel_type_coefficient + "$/L");
            }
            
            if (fuelList.SelectedItem.ToString().Contains("GAS"))
            {
               
                fuel_type_coefficient =  0.11;
                MessageBox.Show( "FUEL TYPE GAS! PRICE IS - " + fuel_type_coefficient + "$/L");
            }
            
            
            
        }

        

        private void value_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (value_box.IsFocused && value_box.Text != string.Empty)
            {
                
                cash_box.Background = Brushes.Gray;
                value_box.Background = Brushes.White;
                cashtopay.Text =  (Double.Parse(value_box.Text) * fuel_type_coefficient).ToString()  ;
                cash_box.Text = (Double.Parse(value_box.Text) * fuel_type_coefficient).ToString()  ;
            } else 
            {
                value_box.Background = Brushes.White;
                cash_box.Background = Brushes.White;
                
            }  if (value_box.IsFocused && value_box.Text == string.Empty) {
                
                value_box.Text = "0";
            }

           
          


        }

        private void cash_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (cash_box.IsFocused && cash_box.Text != string.Empty )
            {
                value_box.Background = Brushes.Gray;
                cash_box.Background = Brushes.White;
                
                cashtopay.Text =  cash_box.Text ;
                value_box.Text = (Double.Parse(cash_box.Text) / fuel_type_coefficient).ToString() ;
            }
            else
            {
                value_box.Background = Brushes.White;
                cash_box.Background = Brushes.White;
            } if (cash_box.IsFocused && cash_box.Text == string.Empty) {
                
                cash_box.Text = "0";
            }
            
           
            
        }

        
        
        
        
        private void Tea_OnChecked(object sender, RoutedEventArgs e)
        {
            cashtopay.Text = (Double.Parse(cashtopay.Text) + 1).ToString();
        }
        private void Tea_OnUnchecked(object sender, RoutedEventArgs e)
        {
            cashtopay.Text = (Double.Parse(cashtopay.Text) - 1).ToString();
        }
        private void Water_OnChecked(object sender, RoutedEventArgs e)
        {
            cashtopay.Text = (Double.Parse(cashtopay.Text) + 1).ToString();
        }
        private void Water_OnUnchecked(object sender, RoutedEventArgs e)
        {
            cashtopay.Text = (Double.Parse(cashtopay.Text) - 1).ToString();
        }
        private void Beer_OnChecked(object sender, RoutedEventArgs e)
        {
            cashtopay.Text = (Double.Parse(cashtopay.Text) + 1).ToString();
        }
        private void Beer_OnUnchecked(object sender, RoutedEventArgs e)
        {
            cashtopay.Text = (Double.Parse(cashtopay.Text) - 1).ToString();
        }
    }
}
