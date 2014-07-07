using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlucemicIndex_project.Models;
using GlucemicIndex_project.Controller;
using GlucemicIndex_project.Common;
namespace GlucemicIndex_project.Controller
{
    class ListFoodController: BindableBase
    {
        private FoodList _foodList = new FoodList();
        public ListFoodController(FoodList foods)
        {
            _foodList = foods;          
        }
        public FoodList FoodList
        {
            get { return _foodList; }
            set { SetProperty(ref _foodList, value); }
        }
    }
}
