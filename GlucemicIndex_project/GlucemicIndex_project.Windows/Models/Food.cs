using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlucemicIndex_project.Common;
namespace GlucemicIndex_project.Models
{
    class Food : BindableBase
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                SetProperty(ref _name, value);
            }
        }

        private string _type;
        public string Type
        {
            get { return _type; }
            set
            {
                SetProperty(ref _type, value);
            }
        }
        private string _color;
        public string Color
        {
            get { return _color; }
            set
            {
                SetProperty(ref _color, value);
            }
        }

        private int _ig;
        public int Ig
        {
            get { return _ig; }
            set
            {
                SetProperty(ref _ig, value);
            }
        }
    }
}
