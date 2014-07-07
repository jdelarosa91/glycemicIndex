using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using GlucemicIndex_project.Controller;
// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=234238

namespace GlucemicIndex_project
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        MainViewEventController eventController;
        public MainPage()
        {
            this.InitializeComponent();
            eventController = new MainViewEventController();
        }
        private  void onClick(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;
            string selected = "";
            selected = (clickedButton.Name.Equals("b_search")) ? search_text.Text : clickedButton.Name;
            String type = "error";
            switch (selected)
            {
                case "b_fruits":
                    type = "fruits";
                    break;
                case "b_cereals":
                    type = "cereals";
                    break;
                case "b_meat":
                    type = "meat";
                    break;
                case "b_candies":
                    type = "candies";
                    break;
                case "b_milk":
                    type = "milk";
                    break;
                case "b_drinks":
                    type = "drinks";
                    break;
                case "b_high":
                    type = "Red";
                    break;
                case "b_medium":
                    type = "Yellow";
                    break;
                case "b_low":
                    type = "Green";
                    break;
                default:
                    type = selected;
                    break;
            }

            this.Frame.Navigate(typeof(ViewFood), type);
        }

    }
}
