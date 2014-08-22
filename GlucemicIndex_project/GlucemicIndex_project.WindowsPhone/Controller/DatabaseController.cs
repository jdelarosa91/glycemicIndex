using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlucemicIndex_project.Common;
using System.IO;
using GlucemicIndex_project.Models;
using SQLite;
namespace GlucemicIndex_project.Controller
{
    class DatabaseController
    {
        private string DBPath = String.Empty;
        private string[] types = new string[6] { "fruits", "cereals", "meat", "candies", "milk", "drinks" };
        private string[] levels = new string[3] { "Red", "Yellow", "Green" };
        public DatabaseController()
        {
            // Get a reference to the SQLite database
            DBPath = Path.Combine(
            Windows.Storage.ApplicationData.Current.LocalFolder.Path, "foods.sqlite");
            // Initialize the database if necessary
            using (var db = new SQLite.SQLiteConnection(DBPath))
            {
                // Create the tables if they don’t exist
                db.CreateTable<Food_db>();
            }
        }
        public void insertDB()
        {
            // Initialize the database if necessary
            using (var db = new SQLite.SQLiteConnection(DBPath))
            {
                // Create the tables if they don’t exist


                fruits_vegetables(db);
                cereals_grains(db);
                milk_plus(db);
                meat_fish(db);
                drinks(db);
                sweets(db);

            }
        }

        public FoodList searchFood(string type)
        {
            if (types.Contains(type))
            {
                return selectwheretype(type);
            }
            else if (levels.Contains(type))
            {
                type = (type.Equals("Yellow")) ? "#FFCC00" : type;
                return selectwherelevel(type);
            }
            else
            {
                return selectwherename(type);
            }
        }

        private static void sweets(SQLiteConnection db)
        {
            db.Insert(new Food_db()
            {
                Name = "Arroz con leche (con azucar)",
                Type = "candies",
                Ig = 75,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Barquillo (con azucar)",
                Type = "candies",
                Ig = 75,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Azucar moreno",
                Type = "candies",
                Ig = 70,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Chocolate tableta (con azucar)",
                Type = "candies",
                Ig = 70,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Chocolate negro (>70% cacao)",
                Type = "candies",
                Ig = 25,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Chocolate negro (>80% cacao)",
                Type = "candies",
                Ig = 20,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Cereales refinados (con azucar)",
                Type = "candies",
                Ig = 70,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Azucar blanco",
                Type = "candies",
                Ig = 70,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Confitura, mermelada",
                Type = "candies",
                Ig = 65,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Muesli (con miel o azucar)",
                Type = "candies",
                Ig = 65,
                Color = "Red"
            });

            db.Insert(new Food_db()
            {
                Name = "Miel",
                Type = "candies",
                Ig = 60,
                Color = "Red"
            });

            db.Insert(new Food_db()
            {
                Name = "Sorbete/helado frutas",
                Type = "candies",
                Ig = 65,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Mermelada (con azucar)",
                Type = "candies",
                Ig = 65,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Mayonesa (con azucar)",
                Type = "candies",
                Ig = 60,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Helado de crema",
                Type = "candies",
                Ig = 60,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Chocolate en polvo",
                Type = "candies",
                Ig = 60,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Glucosa",
                Type = "candies",
                Ig = 100,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Jarabe de glucosa",
                Type = "candies",
                Ig = 100,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Jarabe de arce",
                Type = "candies",
                Ig = 65,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Jarabe de trigo",
                Type = "candies",
                Ig = 100,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Jarabe de arroz",
                Type = "candies",
                Ig = 100,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Jarabe de maiz",
                Type = "candies",
                Ig = 115,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Croissant",
                Type = "candies",
                Ig = 70,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Membrillo (con azúcar)",
                Type = "candies",
                Ig = 65,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Membrillo (sin azúcar)",
                Type = "candies",
                Ig = 45,
                Color = "#FFCC00"
            });
            db.Insert(new Food_db()
            {
                Name = "Crema de chocolate (nutella, nocilla...)",
                Type = "candies",
                Ig = 55,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Doughnut/Donut",
                Type = "candies",
                Ig = 75,
                Color = "Red"
            });
        }

        private static void drinks(SQLiteConnection db)
        {
            db.Insert(new Food_db()
            {
                Name = "Limón (zumo)",
                Type = "drinks",
                Ig = 20,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Tomate (zumo)",
                Type = "drinks",
                Ig = 35,
                Color = "Green"
            });
           
            db.Insert(new Food_db()
            {
                Name = "Zanahoria (zumo)",
                Type = "drinks",
                Ig = 40,
                Color = "#FFCC00"
            });
            db.Insert(new Food_db()
            {
                Name = "Naranja sin azucar (zumo)",
                Type = "drinks",
                Ig = 45,
                Color = "#FFCC00"
            });
            db.Insert(new Food_db()
            {
                Name = "Piña sin azucar (zumo)",
                Type = "drinks",
                Ig = 50,
                Color = "#FFCC00"
            });
            db.Insert(new Food_db()
            {
                Name = "Manzana sin azucar (zumo)",
                Type = "drinks",
                Ig = 50,
                Color = "#FFCC00"
            });
            db.Insert(new Food_db()
            {
                Name = "Arándano sin azucar (zumo)",
                Type = "drinks",
                Ig = 50,
                Color = "#FFCC00"
            });
            db.Insert(new Food_db()
            {
                Name = "Mango sin azucar (zumo)",
                Type = "drinks",
                Ig = 55,
                Color = "#FFCC00"
            });
            db.Insert(new Food_db()
            {
                Name = "Uva sin azucar (zumo)",
                Type = "drinks",
                Ig = 55,
                Color = "#FFCC00"
            });
            db.Insert(new Food_db()
            {
                Name = "Sodas, gaseosas",
                Type = "drinks",
                Ig = 70,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Refrescos endulzados",
                Type = "drinks",
                Ig = 70,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Cacao en polvo (cola cao)",
                Type = "drinks",
                Ig = 60,
                Color = "Red"
            });

            db.Insert(new Food_db()
            {
                Name = "Café",
                Type = "drinks",
                Ig = 0,
                Color = "Green"
            });

            db.Insert(new Food_db()
            {
                Name = "Té",
                Type = "drinks",
                Ig = 0,
                Color = "Green"
            });

            db.Insert(new Food_db()
            {
                Name = "Cerveza",
                Type = "drinks",
                Ig = 110,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Vino",
                Type = "drinks",
                Ig = 0,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Bebidas alcoholicas (destiladas)",
                Type = "drinks",
                Ig = 0,
                Color = "Green"
            });

            db.Insert(new Food_db()
            {
                Name = "Almendra",
                Type = "cereals",
                Ig = 15,
                Color = "Green"
            });

            db.Insert(new Food_db()
            {
                Name = "Altramuz",
                Type = "cereals",
                Ig = 15,
                Color = "Green"
            });

            db.Insert(new Food_db()
            {
                Name = "Avellana",
                Type = "cereals",
                Ig = 25,
                Color = "Green"
            });
        }

        private static void meat_fish(SQLiteConnection db)
        {
            db.Insert(new Food_db()
            {
                Name = "Carnes(ternera, ave, codero, cerdo...)",
                Type = "meat",
                Ig = 0,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Pescados (salmon, atun, etc)",
                Type = "meat",
                Ig = 0,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Crustáceos",
                Type = "meat",
                Ig = 5,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Huevos",
                Type = "meat",
                Ig = 0,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Mayonesa (casera)",
                Type = "meat",
                Ig = 0,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Mayonesa (industrial)",
                Type = "meat",
                Ig = 60,
                Color = "Red"
            });
        }

        private static void milk_plus(SQLiteConnection db)
        {
            db.Insert(new Food_db()
            {
                Name = "Yogur de soja (Con o sin sabor)",
                Type = "milk",
                Ig = 20,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Leche de almendra",
                Type = "milk",
                Ig = 30,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Leche de soja",
                Type = "milk",
                Ig = 30,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Crema de leche",
                Type = "milk",
                Ig = 0,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Leche (desnatada o no)",
                Type = "milk",
                Ig = 30,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Leche de coco",
                Type = "milk",
                Ig = 40,
                Color = "#FFCC00"
            });
            db.Insert(new Food_db()
            {
                Name = "Leche de arroz",
                Type = "milk",
                Ig = 85,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Quesos (mozzarella, ...)",
                Type = "milk",
                Ig = 0,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Requeson",
                Type = "milk",
                Ig = 30,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Yogur (Con o sin sabor)",
                Type = "milk",
                Ig = 35,
                Color = "Green"
            });
        }

        private static void cereals_grains(SQLiteConnection db)
        {
            db.Insert(new Food_db()
            {
                Name = "Cebada (descascarillada)",
                Type = "cereals",
                Ig = 25,
                Color = "Green"
            });

            db.Insert(new Food_db()
            {
                Name = "Arroz (salvaje)",
                Type = "cereals",
                Ig = 35,
                Color = "Green"
            });

            db.Insert(new Food_db()
            {
                Name = "Arroz (basmati)",
                Type = "cereals",
                Ig = 45,
                Color = "#FFCC00"
            });

            db.Insert(new Food_db()
            {
                Name = "Arroz (integral)",
                Type = "cereals",
                Ig = 50,
                Color = "#FFCC00"
            });

            db.Insert(new Food_db()
            {
                Name = "Arroz (largo)",
                Type = "cereals",
                Ig = 60,
                Color = "Red"
            });

            db.Insert(new Food_db()
            {
                Name = "Arroz (comun)",
                Type = "cereals",
                Ig = 70,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Harina (arroz)",
                Type = "cereals",
                Ig = 95,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Arroz (asiatico)",
                Type = "cereals",
                Ig = 60,
                Color = "Red"
            });

            db.Insert(new Food_db()
            {
                Name = "Pan de arroz",
                Type = "cereals",
                Ig = 70,
                Color = "Red"
            });

            db.Insert(new Food_db()
            {
                Name = "Torta de arroz",
                Type = "cereals",
                Ig = 85,
                Color = "Red"
            });

            db.Insert(new Food_db()
            {
                Name = "fideos/tallarines (arroz)",
                Type = "cereals",
                Ig = 65,
                Color = "Red"
            });

            db.Insert(new Food_db()
            {
                Name = "Salvado (Avena, trigo...)",
                Type = "cereals",
                Ig = 15,
                Color = "Green"
            });

            db.Insert(new Food_db()
            {
                Name = "Cereales germinados (germen de trigo...)",
                Type = "cereals",
                Ig = 15,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Tallarines chinos (trigo duro)",
                Type = "cereals",
                Ig = 35,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Lentejas",
                Type = "cereals",
                Ig = 30,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Garbanzos",
                Type = "cereals",
                Ig = 30,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Falafel",
                Type = "cereals",
                Ig = 35,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Harina de garbanzos",
                Type = "cereals",
                Ig = 35,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Judias (habichuelas)",
                Type = "cereals",
                Ig = 30,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Hummus (puré de garbanzos)",
                Type = "cereals",
                Ig = 25,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Habas (cocidas)",
                Type = "cereals",
                Ig = 65,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Habas (crudas)",
                Type = "cereals",
                Ig = 40,
                Color = "#FFCC00"
            });
            db.Insert(new Food_db()
            {
                Name = "Guisantes (frescos)",
                Type = "cereals",
                Ig = 35,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Guisantes(lata)",
                Type = "cereals",
                Ig = 45,
                Color = "#FFCC00"
            });
            db.Insert(new Food_db()
            {
                Name = "Pasta al dente",
                Type = "cereals",
                Ig = 40,
                Color = "#FFCC00"
            });
            db.Insert(new Food_db()
            {
                Name = "Pasta de trigo completo",
                Type = "cereals",
                Ig = 50,
                Color = "#FFCC00"
            });
            db.Insert(new Food_db()
            {
                Name = "Cuscús integral",
                Type = "cereals",
                Ig = 45,
                Color = "#FFCC00"
            }); db.Insert(new Food_db()
            {
                Name = "Cuscús integral",
                Type = "cereals",
                Ig = 60,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Macarrones / espagueti (Trigo duro)",
                Type = "cereals",
                Ig = 50,
                Color = "#FFCC00"
            });
            db.Insert(new Food_db()
            {
                Name = "Harina blanca de trigo",
                Type = "cereals",
                Ig = 85,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Pasta de trigo blando",
                Type = "cereals",
                Ig = 70,
                Color = "Red"
            });

            db.Insert(new Food_db()
            {
                Name = "Avena",
                Type = "cereals",
                Ig = 40,
                Color = "#FFCC00"
            });
            db.Insert(new Food_db()
            {
                Name = "Avena (copo)",
                Type = "cereals",
                Ig = 40,
                Color = "#FFCC00"
            });

            db.Insert(new Food_db()
            {
                Name = "Centeno integral(harina, pan)",
                Type = "cereals",
                Ig = 45,
                Color = "#FFCC00"
            });
            db.Insert(new Food_db()
            {
                Name = "Pan de centeno(30%)",
                Type = "cereals",
                Ig = 65,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Muesli (sin azucar)",
                Type = "cereals",
                Ig = 50,
                Color = "#FFCC00"
            });
            db.Insert(new Food_db()
            {
                Name = "Muesli (con azucar)",
                Type = "cereals",
                Ig = 65,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Palomitas (saladas)",
                Type = "cereals",
                Ig = 85,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Jarabe de maiz",
                Type = "cereals",
                Ig = 115,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Pan de leche",
                Type = "cereals",
                Ig = 60,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Pan completo",
                Type = "cereals",
                Ig = 65,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Pan semi-integral (con levadura)",
                Type = "cereals",
                Ig = 65,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Pan blanco",
                Type = "cereals",
                Ig = 85,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Pan baguette",
                Type = "cereals",
                Ig = 70,
                Color = "Red"
            });
        }

        private static void fruits_vegetables(SQLiteConnection db)
        {
            db.Insert(new Food_db()
            {
                Name = "Aceitununa",
                Type = "fruits",
                Ig = 15,
                Color = "Green"
            });

            db.Insert(new Food_db()
            {
                Name = "Aguacate",
                Type = "fruits",
                Ig = 10,
                Color = "Green"
            });



            db.Insert(new Food_db()
            {
                Name = "Acerola",
                Type = "fruits",
                Ig = 20,
                Color = "Green"
            });

            db.Insert(new Food_db()
            {
                Name = "Manzana (fruta)",
                Type = "fruits",
                Ig = 35,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Pera (fruta)",
                Type = "fruits",
                Ig = 30,
                Color = "Green"
            });

            db.Insert(new Food_db()
            {
                Name = "Espárragos",
                Type = "fruits",
                Ig = 15,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Chile, Chili (pimiento picante)",
                Type = "fruits",
                Ig = 15,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Platano (fruta)",
                Type = "fruits",
                Ig = 45,
                Color = "#FFCC00"
            });
            db.Insert(new Food_db()
            {
                Name = "Fresa (fruta)",
                Type = "fruits",
                Ig = 25,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Naranja (fruta)",
                Type = "fruits",
                Ig = 45,
                Color = "#FFCC00"
            });
            db.Insert(new Food_db()
            {
                Name = "Limon (fruta)",
                Type = "fruits",
                Ig = 20,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Cereza (fruta)",
                Type = "fruits",
                Ig = 25,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Melon (fruta)",
                Type = "fruits",
                Ig = 60,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Sandía (fruta)",
                Type = "fruits",
                Ig = 75,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Albaricoque (fruta)",
                Type = "fruits",
                Ig = 30,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Melocotón (fruta)",
                Type = "fruits",
                Ig = 35,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Chirimoya (fruta)",
                Type = "fruits",
                Ig = 35,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Uva (fruta)",
                Type = "fruits",
                Ig = 45,
                Color = "#FFCC00"
            });
            db.Insert(new Food_db()
            {
                Name = "Kiwi (fruta)",
                Type = "fruits",
                Ig = 50,
                Color = "#FFCC00"
            });
            db.Insert(new Food_db()
            {
                Name = "Ciruela (fruta)",
                Type = "fruits",
                Ig = 35,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Frambuesa (fruta)",
                Type = "fruits",
                Ig = 25,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Mora (fruta)",
                Type = "fruits",
                Ig = 25,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Arandano (fruta)",
                Type = "fruits",
                Ig = 25,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Dátil (fruta)",
                Type = "fruits",
                Ig = 70,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Coco (fruta)",
                Type = "fruits",
                Ig = 35,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Papaya (fruta)",
                Type = "fruits",
                Ig = 55,
                Color = "#FFCC00"
            });
            db.Insert(new Food_db()
            {
                Name = "Granada (fruta)",
                Type = "fruits",
                Ig = 35,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Piña (fruta)",
                Type = "fruits",
                Ig = 45,
                Color = "#FFCC00"
            });
            db.Insert(new Food_db()
            {
                Name = "Mango (fruta)",
                Type = "fruits",
                Ig = 50,
                Color = "#FFCC00"
            });
            db.Insert(new Food_db()
            {
                Name = "Maracuyá (fruta)",
                Type = "fruits",
                Ig = 30,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Pasa (fruta)",
                Type = "fruits",
                Ig = 40,
                Color = "#FFCC00"
            });
            db.Insert(new Food_db()
            {
                Name = "Higo (fruta)",
                Type = "fruits",
                Ig = 35,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Higo seco (fruta)",
                Type = "fruits",
                Ig = 40,
                Color = "#FFCC00"
            });
            db.Insert(new Food_db()
            {
                Name = "Nispero (fruta)",
                Type = "fruits",
                Ig = 55,
                Color = "#FFCC00"
            });
            db.Insert(new Food_db()
            {
                Name = "Pomelo (fruta)",
                Type = "fruits",
                Ig = 30,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Acelga ",
                Type = "fruits",
                Ig = 15,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Ajo",
                Type = "fruits",
                Ig = 30,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Alcachofa",
                Type = "fruits",
                Ig = 20,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Apio",
                Type = "fruits",
                Ig = 15,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Berenjena",
                Type = "fruits",
                Ig = 20,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Batata, boniato",
                Type = "fruits",
                Ig = 50,
                Color = "#FFCC00"
            });
            db.Insert(new Food_db()
            {
                Name = "Brécol, brócoli",
                Type = "fruits",
                Ig = 15,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Calabacín, calabaza",
                Type = "fruits",
                Ig = 15,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Pipas de calabacín/calabaza",
                Type = "fruits",
                Ig = 25,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Cebolla",
                Type = "fruits",
                Ig = 15,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Coliflor",
                Type = "fruits",
                Ig = 15,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Col de bruselas",
                Type = "fruits",
                Ig = 15,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Col",
                Type = "fruits",
                Ig = 15,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Espinacas",
                Type = "fruits",
                Ig = 15,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Especia: perejil, oregano...",
                Type = "fruits",
                Ig = 5,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Judias verdes",
                Type = "fruits",
                Ig = 30,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Lechuga",
                Type = "fruits",
                Ig = 15,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Maiz (crudo)",
                Type = "fruits",
                Ig = 35,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Nabo (crudo)",
                Type = "fruits",
                Ig = 30,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Nabo (cocido)",
                Type = "fruits",
                Ig = 85,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Patata (hervida)",
                Type = "fruits",
                Ig = 65,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Patata (fritas)",
                Type = "fruits",
                Ig = 70,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Patata (almidon)",
                Type = "fruits",
                Ig = 95,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Patata (horno)",
                Type = "fruits",
                Ig = 95,
                Color = "Red"
            });
            db.Insert(new Food_db()
            {
                Name = "Pepino",
                Type = "fruits",
                Ig = 15,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Pimiento",
                Type = "fruits",
                Ig = 15,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Puerro",
                Type = "fruits",
                Ig = 15,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Repollo",
                Type = "fruits",
                Ig = 15,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Tomate",
                Type = "fruits",
                Ig = 30,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Mostaza (salsa)",
                Type = "drinks",
                Ig = 55,
                Color = "#FFCC00"
            });
            db.Insert(new Food_db()
            {
                Name = "Tomate frito (salsa)",
                Type = "fruits",
                Ig = 45,
                Color = "#FFCC00"
            });
            db.Insert(new Food_db()
            {
                Name = "Ketchup (salsa)",
                Type = "fruits",
                Ig = 55,
                Color = "#FFCC00"
            });
            db.Insert(new Food_db()
            {
                Name = "Zanahoria (Cruda)",
                Type = "fruits",
                Ig = 20,
                Color = "Green"
            });
            db.Insert(new Food_db()
            {
                Name = "Zanahoria (Cocida)",
                Type = "fruits",
                Ig = 40,
                Color = "#FFCC00"
            });
        }

        public void deleteDB()
        {
            using (var db = new SQLiteConnection(DBPath))
            {
                db.DeleteAll<Food_db>();
            }
        }

        private FoodList selectwheretype(string type)
        {
            FoodList foods = new FoodList();
            using (var db = new SQLite.SQLiteConnection(DBPath))
            {
                var query = db.Table<Food_db>().Where(
                    c => c.Type.Equals(type)).OrderBy(c => c.Ig).Reverse();

                foreach (var _food in query)
                {
                    Food food = new Food()
                    {
                        Name = _food.Name,
                        Type = _food.Type,
                        Ig = _food.Ig,
                        Color = _food.Color
                    };
                    foods.Add(food);

                }
            }
            return foods;
        }

        private FoodList selectwherename(string name)
        {
            FoodList foods = new FoodList();
            using (var db = new SQLite.SQLiteConnection(DBPath))
            {
                if (name[name.Length - 1] == 's')
                {
                    name = name.TrimEnd('s');
                }
                var query = db.Table<Food_db>().Where(
                    c => c.Name.Contains(name)).OrderBy(c => c.Ig).Reverse();

                foreach (var _food in query)
                {
                    Food food = new Food()
                    {
                        Name = _food.Name,
                        Type = _food.Type,
                        Ig = _food.Ig,
                        Color = _food.Color
                    };
                    foods.Add(food);

                }
            }
            return foods;
        }

        private FoodList selectwherelevel(string ig)
        {
            FoodList foods = new FoodList();
            using (var db = new SQLite.SQLiteConnection(DBPath))
            {

                var query = db.Table<Food_db>().Where(
                    c => c.Color.Equals(ig)).OrderBy(c => c.Ig).Reverse();
                foreach (var _food in query)
                {
                    Food food = new Food()
                    {
                        Name = _food.Name,
                        Type = _food.Type,
                        Ig = _food.Ig,
                        Color = _food.Color
                    };
                    foods.Add(food);

                }
            }
            return foods;
        }
    }
}


