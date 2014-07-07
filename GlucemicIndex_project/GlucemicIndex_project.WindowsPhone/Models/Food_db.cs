using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GlucemicIndex_project.Controller
{
    class Food_db
    {
        [SQLite.PrimaryKey, SQLite.AutoIncrement]
        public int id { get; set; }
        public string Name { get; set; }
        public int Ig { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }

    }
}
