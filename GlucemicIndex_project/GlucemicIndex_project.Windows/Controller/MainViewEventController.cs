using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace GlucemicIndex_project.Controller
{
    class MainViewEventController
    {
        public void goToViewItems(string selected, Frame page)
        {
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
            page.Navigate(typeof(ViewFood), type);
        }
    }
}
