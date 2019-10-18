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

namespace Memo
{
    
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Char[] letras = { 'a', 'b', 'h', 'i', 'j', 'k', 'l', 'm', 'o', 'p' };

        public MainWindow()
        {
            InitializeComponent();
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            contedor.RowDefinitions.Clear();
            if (baja.IsChecked == true)
            {
                RowDefinition r1 = new RowDefinition();
                RowDefinition r2 = new RowDefinition();
                RowDefinition r3 = new RowDefinition();
                contedor.RowDefinitions.Add(r1);
                contedor.RowDefinitions.Add(r2);
                contedor.RowDefinitions.Add(r3);
                for(int i = 0; i < contedor.RowDefinitions.Count; i++)
                {
                    
                    for(int j = 0; j < 4; j++)
                    {
                        Border borde = new Border();   
                        Viewbox viewbox = new Viewbox();
                        TextBlock tb = new TextBlock();
                        tb.Text = "s";
                        borde.Child = viewbox;
                        viewbox.Child = tb;
                        Grid.SetRow(borde, i);
                        Grid.SetColumn(borde, j);
                        contedor.Children.Add(borde);
                    }
                }
            }
            else if(media.IsChecked == true)
            {
                RowDefinition r1 = new RowDefinition();
                RowDefinition r2 = new RowDefinition();
                RowDefinition r3 = new RowDefinition();
                RowDefinition r4 = new RowDefinition();
                contedor.RowDefinitions.Add(r4);
                contedor.RowDefinitions.Add(r1);
                contedor.RowDefinitions.Add(r2);
                contedor.RowDefinitions.Add(r3);
                for (int i = 0; i < contedor.RowDefinitions.Count; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Border borde = new Border();
                        Viewbox viewbox = new Viewbox();
                        TextBlock tb = new TextBlock();
                        tb.Text = "s";
                        borde.Child = viewbox;
                        viewbox.Child = tb;
                        Grid.SetRow(borde, i);
                        Grid.SetColumn(borde, j);
                        contedor.Children.Add(borde);
                    }
                }
            }
            else if(alta.IsChecked == true)
            {
                RowDefinition r1 = new RowDefinition();
                RowDefinition r2 = new RowDefinition();
                RowDefinition r3 = new RowDefinition();
                RowDefinition r4 = new RowDefinition();
                RowDefinition r5 = new RowDefinition();                              
                contedor.RowDefinitions.Add(r1);
                contedor.RowDefinitions.Add(r2);
                contedor.RowDefinitions.Add(r3);
                contedor.RowDefinitions.Add(r4);
                contedor.RowDefinitions.Add(r5);

                for (int i = 0; i < contedor.RowDefinitions.Count; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Border borde = new Border();
                        Viewbox viewbox = new Viewbox();
                        TextBlock tb = new TextBlock();
                        tb.Text = "s";
                        borde.Child = viewbox;
                        viewbox.Child = tb;
                        Grid.SetRow(borde, i);
                        Grid.SetColumn(borde, j);
                        contedor.Children.Add(borde);
                    }
                }
            }

            
            
        }


        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Char[] aux = new Char[6];
            Random random = new Random();
            for(int i = 0; i < 6; i++)
            {
                aux[i] = letras[random.Next(6)];
            }

        }
    }
}
