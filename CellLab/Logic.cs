using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace CellLab
{
    public static class Logic
    {
        public static Random random = new Random();
        static public MainWindow MW;
        static public SettingWindow SW;
        static public int POISONS, FOODS, RADIATION, FOODNUTRIATION, MAP, SIZE, ROWS, COLUMNS;
        public static int NowPoison = 0, NowFood = 0;
        static bool[,] walls;
        public static bool[,] poisons;
        public static bool[,] foods;
        public static Cell[] cells=new Cell[64];
        public static void LoadSettings()
        {
            POISONS = (int)SW.Slider_poison.Value;
            FOODS = (int)SW.Slider_food.Value;
            FOODNUTRIATION = (int)SW.Slider_foodNutrition.Value;
            RADIATION = (int)SW.Slider_radiation.Value;
            MAP = SW.ComboBox_Map.SelectedIndex;
            SIZE = (int)MW.SizeSlider.Value;
        }
        public static void LoadMap()
        {
            string[] separators = { "\r\n", " " };
            string[] cords = Properties.Resources.Map1.Split(separators,100000000,StringSplitOptions.None);
            switch (MAP){
                case 0:
                    COLUMNS = Int32.Parse(cords[0]);
                    ROWS = Int32.Parse(cords[1]);
                    walls = new bool[COLUMNS, ROWS];
                    poisons = new bool[COLUMNS, ROWS];
                    foods = new bool[COLUMNS, ROWS];
                    for (int i = 2; i < cords.Length; i++)
                    {
                        walls[Int32.Parse(cords[i]), Int32.Parse(cords[i++])] = true;
                    }
                    break;
            }
            
        }

        public static void RedrowMap()
        {
            if (MW != null)
            {
                if (MW.rectangles == null) MW.rectangles = new System.Windows.Shapes.Rectangle[COLUMNS, ROWS];
                MW.Field.MinWidth = COLUMNS * SIZE;
                MW.Field.MinHeight = ROWS * SIZE;
                MW.Field.MaxWidth = COLUMNS * SIZE;
                MW.Field.MaxHeight = ROWS * SIZE;
                for (int x = 0; x < COLUMNS; x++)
                {
                    for (int y = 0; y < ROWS; y++)
                    {
                        if (MW.rectangles[x, y] == null)
                        {
                            MW.rectangles[x, y] = new System.Windows.Shapes.Rectangle();
                            MW.rectangles[x, y].Stroke = Brushes.Black;
                            MW.rectangles[x, y].Stroke = Brushes.Black;
                            MW.Field.Children.Add(MW.rectangles[x, y]);

                        }
                        MW.rectangles[x, y].Height = SIZE;
                        MW.rectangles[x, y].Width = SIZE;
                        Canvas.SetBottom(MW.rectangles[x, y], y * SIZE);
                        Canvas.SetLeft(MW.rectangles[x, y], x * SIZE);

                    }
                }
                
            }
            DrawWalls();
        }
        public static void DrawWalls()
        {
            for (int x = 0; x < COLUMNS; x++)
            {
                for (int y = 0; y < ROWS; y++)
                {
                    if(walls[x,y])MW.rectangles[x, y].Fill= System.Windows.Media.Brushes.Black;
                }
            }
        }
        public static void DrawPoison(Point p)
        {
            MW.rectangles[p.x, p.y].Fill = Brushes.Red;
        }
        public static void DrawFood(Point p)
        {
            MW.rectangles[p.x, p.y].Fill = Brushes.Green;
        }
        public static void DrawVoid(Point p)
        {
            MW.rectangles[p.x, p.y].Fill = Brushes.White;
        }

        public static void NewPoison()
        {
            Point point = new Point();
            while (NowPoison < POISONS)
            {
                do
                {
                    point.x = random.Next(COLUMNS);
                    point.y = random.Next(ROWS);
                }
                while (IsWall(point)||IsPoison(point)||IsFood(point)|| IsCell(point));

                poisons[point.x, point.y] = true;
                DrawPoison(point);
                NowPoison++;

            }

        }

        public static void StartFood()
        {
            NowFood = 0;
            Point point = new Point();
            for (int x = 0; x < COLUMNS; x++)
            {
                for(int y = 0; y < ROWS; y++)
                {
                    point.x = x;
                    point.y = y;
                    if (IsFood(point))
                    {
                        DrawVoid(point);
                        foods[x, y] = false;
                    }
                }
            }
            while (NowFood < FOODS)
            {
                do
                {
                    point.x = random.Next(COLUMNS);
                    point.y = random.Next(ROWS);
                }
                while (IsWall(point) || IsPoison(point) || IsFood(point) || IsCell(point));

                foods[point.x, point.y] = true;
                DrawFood(point);
                NowFood++;

            }

        }
        public static void StartPoison()
        {
            NowPoison = 0;
            Point point = new Point();
            for (int x = 0; x < COLUMNS; x++)
            {
                for (int y = 0; y < ROWS; y++)
                {
                    point.x = x;
                    point.y = y;
                    DrawVoid(point);
                    poisons[x, y] = false;
                }
            }
            Random random = new Random();
            while (NowPoison < POISONS)
            {
                do
                {
                    point.x = random.Next(COLUMNS);
                    point.y = random.Next(ROWS);
                }
                while (IsWall(point) || IsPoison(point) || IsFood(point) || IsCell(point));

                poisons[point.x, point.y] = true;
                DrawPoison(point);
                NowPoison++;

            }

        }
        public static void NewFood()
        {
            Random random = new Random();
            Point point = new Point();
            while (NowFood < FOODS)
            {
                do
                {
                    point.x = random.Next(COLUMNS);
                    point.y = random.Next(ROWS);
                }
                while (IsWall(point) || IsPoison(point) || IsFood(point)||IsCell(point));

                foods[point.x, point.y] = true;
                DrawFood(point);
                NowFood++;

            }

        }
        public static void StartGeneration()
        {
            
            Point point = new Point();

            for (int i = 0; i < 64; i++)
            {
                do
                {
                    point.x = random.Next(COLUMNS);
                    point.y = random.Next(ROWS);
                }
                while (IsWall(point) || IsPoison(point) || IsFood(point)||IsCell(point));
                if(cells[i]!=null)cells[i].Dispose();
                cells[i] = new Cell(point,true,true);
                
            }
            /*
            cells[0].Dispose();
            cells[0] = new Cell(point, false, false, true);
            *///Cоздание тестовой клеточки
            
            GC.Collect();
        }
        public static bool IsWall(Point p)
        {
            if (walls == null) return false;
            return walls[p.x, p.y];
        }

        public static bool IsPoison(Point p)
        {
            if (poisons == null) return false;
            return poisons[p.x, p.y];
        }

        public static bool IsFood(Point p)
        {
            if (foods == null) return false;
            return foods[p.x, p.y];
        }

        public static bool IsCell(Point p)
        {
            if (cells == null) return false;
            foreach(Cell c in cells)
            {
                if (c == null) { return false; }
                if (c.Position.x == p.x && c.Position.y == p.y&&c.IsAlive==true)
                {
                    return true;
                }
            }
            return false;
        }
        public static Cell WhichCell(Point p)
        {
            Cell result = null;
            for(int i = 0; i < 64; i++)
            {
                if(cells[i].Position.x==p.x&& cells[i].Position.y == p.y && cells[i].IsAlive)
                {
                    result = cells[i];
                }
            }
            return result;
        }
        public static void NextDay()
        {
            NewFood();
            NewPoison();
            for(int i = 0; i < 64; i++)
            {
                if (cells[i].IsAlive)
                {
                    cells[i].NextAct();
                }
            }
        }
        public static void DeletePoison(Point p)
        {
            NowPoison--;
            poisons[p.x, p.y] = false;
            DrawVoid(p);
        }

        public static void DeleteFood(Point p)
        {
            NowFood--;
            foods[p.x, p.y] = false;
            DrawVoid(p);
        }


    }
    public struct Point
    {
        public int x, y;
    }
}
