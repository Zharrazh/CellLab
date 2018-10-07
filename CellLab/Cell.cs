using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Controls;

namespace CellLab
{
    public class Cell :IDisposable
    {
        
        public Cell()
        {
            EnergyLabel = new Label();
            CellRect= new System.Windows.Shapes.Rectangle();
            RectToolTip = new ToolTip();
            infoWin = new InfoWin();
            Logic.MW.Field.Children.Add(EnergyLabel);
            Logic.MW.Field.Children.Add(CellRect);
            

            System.Windows.Controls.Canvas.SetZIndex(CellRect, 4);
            System.Windows.Controls.Canvas.SetZIndex(EnergyLabel, 5);
            CellRect.Stroke = Brushes.Black;
            EnergyLabel.Foreground = Brushes.White;
            EnergyLabel.FontFamily = new FontFamily("Times New Roman");
            EnergyLabel.HorizontalContentAlignment = System.Windows.HorizontalAlignment.Center;
            EnergyLabel.VerticalContentAlignment = System.Windows.VerticalAlignment.Center;

            
            genome = new int[64];
            Position = new Point();
            Energy = 100;
            lifeTime = 0;
            IsAlive = true;
            numAct = 0;
            ActPoints = 20;
            random = new Random();


            EnergyLabel.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(EnergyLabel_DoubleClick);
        }
        public Cell(Point p, bool RandomGenome = false, bool RandomRotation = false)
        {
            EnergyLabel = new Label();
            CellRect = new System.Windows.Shapes.Rectangle();
            RectToolTip = new ToolTip();
            

            Logic.MW.Field.Children.Add(EnergyLabel);
            Logic.MW.Field.Children.Add(CellRect);
            CellRect.Fill = Brushes.Blue;
            System.Windows.Controls.Canvas.SetZIndex(CellRect, 4);
            System.Windows.Controls.Canvas.SetZIndex(EnergyLabel, 5);
            CellRect.Stroke = Brushes.Black;
            EnergyLabel.Foreground = Brushes.White;
            EnergyLabel.FontFamily = new FontFamily("Courier New");
            EnergyLabel.HorizontalContentAlignment = System.Windows.HorizontalAlignment.Center;
            EnergyLabel.VerticalContentAlignment = System.Windows.VerticalAlignment.Center;
            EnergyLabel.Padding=new System.Windows.Thickness(0) ;

            genome = new int[64];
            Position = p;
            Energy = 100;
            lifeTime = 0;
            IsAlive = true;
            numAct = 0;
            ActPoints = 20;
            random = Logic.random;
            

            if (RandomGenome)
            {
                for(int i=0; i < 64; i++)
                {
                    genome[i] = random.Next(64);
                }
            }
            if (RandomRotation) Rotation = random.Next(8);

            EnergyLabel.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(EnergyLabel_DoubleClick);


        }
        bool disposed = false;
        InfoWin infoWin;
        public Label EnergyLabel;
        public System.Windows.Shapes.Rectangle CellRect;
        public ToolTip RectToolTip;
        public int[] genome;
        int energy;
        public int lifeTime;
        bool isAlive;
        Point position;
        int numAct;
        int ActPoints;
        int rotation;
        Random random;
        

        public int Rotation
        {
            get { return rotation; }
            set { rotation = value % 8; }
        }
        public int NumAct
        {
            get { return numAct; }
            set { numAct = value % 64; }
        }
        public int Energy
        {
            get {return energy;}
            set
            {
                if (value <= 0)
                {
                    isAlive = false;
                    energy = 0;
                    EnergyLabel.Visibility = System.Windows.Visibility.Collapsed;
                    CellRect.Visibility = System.Windows.Visibility.Collapsed;
                }
                else if (value >= 100) { energy = 100; isAlive = true; }
                else
                {
                    energy = value;
                    isAlive = true;
                }
                EnergyLabel.Content = Energy;
            }
        }
        public bool IsAlive
        {
            get { return isAlive; }
            set
            {
                if (value == false)
                {
                    energy = 0;
                    EnergyLabel.Visibility = System.Windows.Visibility.Collapsed;
                    CellRect.Visibility = System.Windows.Visibility.Collapsed;
                    isAlive = value;
                }
                else
                {
                    isAlive = value;
                    EnergyLabel.Visibility = System.Windows.Visibility.Visible;
                    CellRect.Visibility = System.Windows.Visibility.Visible;
                }
            }
        }
        public Point Position
        {
            
            get { return position; }
            set
            {
                Point p = value;
                p.x=p.x >= Logic.COLUMNS ? 0 :p.x;
                p.x = p.x < 0 ? Logic.COLUMNS-1 : p.x;

                p.y = p.y >= Logic.ROWS ? 0 : p.y;
                p.y = p.y < 0 ? Logic.ROWS - 1 : p.y;

                position = p;

                Draw();
            }
        }
        public void Draw() {

            EnergyLabel.FontSize = Logic.SIZE / 2;
            CellRect.Height = Logic.SIZE;
            CellRect.Width = Logic.SIZE;
            Canvas.SetBottom(CellRect, Position.y * Logic.SIZE);
            Canvas.SetLeft(CellRect, Position.x * Logic.SIZE);
            EnergyLabel.Content = Energy;
            Canvas.SetBottom(EnergyLabel, Position.y * Logic.SIZE );
            Canvas.SetLeft(EnergyLabel, Position.x * Logic.SIZE );
            EnergyLabel.Height = Logic.SIZE;
            EnergyLabel.Width = Logic.SIZE;

        }
        public void SetRect(System.Windows.Shapes.Rectangle CellRect, Label EnergyLabel, ToolTip RectToolTip)
        {
            this.CellRect = CellRect;
            this.EnergyLabel = EnergyLabel;
            this.RectToolTip = RectToolTip;
            System.Windows.Controls.Canvas.SetZIndex(CellRect, 4);
            System.Windows.Controls.Canvas.SetZIndex(EnergyLabel, 5);
            CellRect.Stroke = Brushes.Black;
            EnergyLabel.Foreground = Brushes.White;
            EnergyLabel.FontFamily = new FontFamily("Times New Roman");
            EnergyLabel.HorizontalContentAlignment = System.Windows.HorizontalAlignment.Center;
            EnergyLabel.VerticalContentAlignment = System.Windows.VerticalAlignment.Center;            
        }

        

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Logic.MW.Field.Children.Remove(EnergyLabel);
                    Logic.MW.Field.Children.Remove(CellRect);
                    EnergyLabel =null;
                    CellRect = null;
                    RectToolTip = null;
                }
                disposed = true;
            }
        }

        ~Cell()
        {

            Dispose(false);
        }

        private void EnergyLabel_DoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            infoWin = new InfoWin();
            infoWin.EnergyValue.Content = Energy;
            infoWin.XPosition.Content = Position.x;
            infoWin.YPosition.Content = Position.y;
            infoWin.LiveTimeValue.Content = lifeTime;
            infoWin.RotationValue.Content = Rotation;
            for (int i = 0; i < 64; i++)
            {
                infoWin.gensLabels[i].Content = genome[i];
            }
            infoWin.gensLabels[NumAct].BorderBrush = Brushes.Blue;
            infoWin.Refresh.Click += RefreshBtn_Click;
            infoWin.Show();
        }

        private void RefreshBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            infoWin.EnergyValue.Content = Energy;
            infoWin.XPosition.Content = Position.x;
            infoWin.YPosition.Content = Position.y;
            infoWin.LiveTimeValue.Content = lifeTime;
            infoWin.RotationValue.Content = Rotation;


            for (int i = 0; i < 64; i++)
            {
                infoWin.gensLabels[i].BorderBrush = Brushes.Black;
            }
            infoWin.gensLabels[NumAct].BorderBrush = Brushes.Blue;

        }
        public void NextAct()
        {
            ActPoints = 20;
            while (ActPoints > 0)
            {
                DoAct();
            }
            Energy--;
            lifeTime++;
        }
        private void DoAct()
        {
            if (genome[NumAct] >= 0 && genome[NumAct] < 7) RotationAct(genome[NumAct]);
            else if (genome[NumAct] >= 7 && genome[NumAct] < 18) MoveRightAct();
            else NumAct++;
        }
        private void RotationAct(int rot)
        {
            ActPoints--;
            Rotation += rot+1;
            NumAct++;
        }
        private void MoveRightAct()
        {
            Point point = DirRotation();
            ActPoints = 0;
            if (!Logic.IsCell(point)&&!Logic.IsWall(point))
            {
                Position = point;
            }
            if (Logic.IsPoison(point))
            {
                IsAlive = false;
                Logic.DeletePoison(point);
            }
            else if (Logic.IsFood(point))
            {
                Energy += Logic.FOODNUTRIATION;
                Logic.DeleteFood(point);
            }
            NumAct++;
        }
        private Point DirRotation()
        {
            Point result = new Point();
            switch (Rotation)
            {
                case 0:
                    result.x = Position.x - 1;
                    result.y = Position.y + 1;
                    break;
                case 1:
                    result.x = Position.x;
                    result.y = Position.y + 1;
                    break;
                case 2:
                    result.x = Position.x + 1;
                    result.y = Position.y + 1;
                    break;
                case 3:
                    result.x = Position.x + 1;
                    result.y = Position.y;
                    break;
                case 4:
                    result.x = Position.x + 1;
                    result.y = Position.y - 1;
                    break;
                case 5:
                    result.x = Position.x ;
                    result.y = Position.y - 1;
                    break;
                case 6:
                    result.x = Position.x-1;
                    result.y = Position.y - 1;
                    break;
                
                case 7:
                    result.x = Position.x - 1;
                    result.y = Position.y;
                    break;
                    
            }
            if (result.x >= Logic.COLUMNS) result.x = 0;
            else if (result.x < 0) result.x = Logic.COLUMNS - 1;
            if (result.y >= Logic.ROWS) result.y = 0;
            else if (result.y < 0) result.y = Logic.ROWS - 1;

            return result;
        }
    }


}
    

