using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()


        {
            this.InitializeComponent();
        }

        bool x = true;
        bool y = false;
    
        

        private void b1_Click_1(object sender, RoutedEventArgs e)
        {

            if (x)
            {
                b1.Content = "X";
                y = true;
                x = false;
                
               int a1 = 1;

            }
            else 
                {
                b1.Content = "y";
                y = false;
                x = true;
            }
            

        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            if (x)
            {
                b2.Content = "X";
                y = true;
                x = false;
               
            }
            else 
            {
                b2.Content = "y";
                y = false;
                x = true;
            }

        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            if(x)
            {
                b3.Content = "X";
                y = true;
                x = false;
            }
            else
            {
                b3.Content = "y";
                y = false;
                x = true;
            }
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            if (x)
            {
                b4.Content = "X";
                y = true;
                x = false;
            }
            else
            {
                b4.Content = "y";
                y = false;
                x = true;
            }
        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            if (x)
            {
                b5.Content = "X";
                y = true;
                x = false;
            }
           else
            {
                b5.Content = "y";
                y = false;
                x = true;
            }
        }

        private void b6_Click(object sender, RoutedEventArgs e)
        {
            if (x)
            {
                b6.Content = "X";
                y = true;
                x = false;
            }
            else
            {
                b6.Content = "y";
                y = false;
                x = true;
            }
        }

        private void b7_Click(object sender, RoutedEventArgs e)
        {
            if (x)
            {
                b7.Content = "X";
                y = true;
                x = false;
            }
            else
            {
                b7.Content = "y";
                y = false;
                x = true;
            }
        }

        private void b8_Click(object sender, RoutedEventArgs e)
        {
            if (x)
            {
                b8.Content = "X";
                y = true;
                x = false;
            }
            else
            {
                b8.Content = "y";
                y = false;
                x = true;
            }
        }

        private void b9_Click(object sender, RoutedEventArgs e)
        {
            if (x)
            {
                b9.Content = "X";
                y = true;
                x = false;
            }
            else
            {
                b9.Content = "y";
                y = false;
                x = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            b1.Content = "";
            b2.Content = "";
            b3.Content = "";
            b4.Content = "";
            b5.Content = "";
            b6.Content = "";
            b7.Content = "";
            b8.Content = "";
            b9.Content = "";
      
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            if (b1.Content == "x" & b2.Content == "x" & b3.Content == "x")
            {
                player1.Visibility = Visibility.Visible;
            }
        }
    }
}

