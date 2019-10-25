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
        Char[] cartas = { 'a', 'b', 'h', 'i', 'j', 'k', 'l', 'm', 'o', 'p' };
        char[,] letrasMemo;


        public MainWindow()
        {
            InitializeComponent();
            

        }
        private int NumAleatorio(int max){
            Random random = new Random();
            return random.Next(max);
        }
        private int ComprobarLetra(char[,] letras, char x){
            int cont = 0;
            for(int f=0;f<letras.GetLength(0);f++){
                for(int c=0;c<letras.GetLength(1);c++){
                    if(letras[f,c]==x) cont++;
                }
            }                                             
            return cont;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            progeso.Value=0;
            contedor.RowDefinitions.Clear();
            if (baja.IsChecked == true)
            {
                RowDefinition r1 = new RowDefinition();
                RowDefinition r2 = new RowDefinition();
                RowDefinition r3 = new RowDefinition();
                contedor.RowDefinitions.Add(r1);
                contedor.RowDefinitions.Add(r2);
                contedor.RowDefinitions.Add(r3);

                letrasMemo = new char[contedor.RowDefinitions.Count,contedor.ColumnDefinitions.Count];
                for(int i = 0; i < contedor.RowDefinitions.Count; i++)
                {   
                    for(int j = 0; j < 4; j++)
                    {

                        char x;
                        do{
                             x = cartas[NumAleatorio(6)];
                        }while(ComprobarLetra(letrasMemo,x)>1);
                        letrasMemo[i,j]= x;

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

                letrasMemo = new char[contedor.RowDefinitions.Count,contedor.ColumnDefinitions.Count];
                for (int i = 0; i < contedor.RowDefinitions.Count; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        char x;
                        do{
                             x = cartas[NumAleatorio(8)];
                        }while(ComprobarLetra(letrasMemo,x)>1);
                        letrasMemo[i,j]= x;

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

                letrasMemo = new char[contedor.RowDefinitions.Count,contedor.ColumnDefinitions.Count];
                for (int i = 0; i < contedor.RowDefinitions.Count; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        char x;
                        do{
                             x = cartas[NumAleatorio(10)];
                        }while(ComprobarLetra(letrasMemo,x)>1);
                        letrasMemo[i,j]= x;

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

        private void Button_Click_Mostrar(object sender, RoutedEventArgs e)
        {
            progeso.Value=100;
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
                        borde.Background = Brushes.White;
                        tb.Text = letrasMemo[i,j].ToString();
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
                        borde.Background = Brushes.White;
                        tb.Text = letrasMemo[i,j].ToString();;
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
                        borde.Background = Brushes.White;
                        tb.Text = letrasMemo[i,j].ToString();;
                        borde.Child = viewbox;
                        viewbox.Child = tb;
                        Grid.SetRow(borde, i);
                        Grid.SetColumn(borde, j);
                        contedor.Children.Add(borde);
                    }
                }
            }
        }

      
    }
}
