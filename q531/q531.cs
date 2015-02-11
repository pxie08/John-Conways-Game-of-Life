/************************************************
** q531.cs
** Battle of Life or Death
** Patrick Xie, 5/31/2011
************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace q531
{
    public partial class q531 : Form
    {
        private DoubleBufferPanel DrawingPanel = new DoubleBufferPanel();
        private Bitmap myCanvas;
        private int width;
        private int height;
        private bool mouseDown;
        List<Cell> cellList = new List<Cell>();
        List<int> newDeadIndex = new List<int>();
        List<int> newLiveIndex = new List<int>();

        public q531()
        {
            InitializeComponent();
            /*Adds Panel into form for double buffering the panel*/
            DrawingPanel.Parent = this;
            DrawingPanel.Location = new System.Drawing.Point(12, 12);
            DrawingPanel.Size = new System.Drawing.Size(400, 400);
            DrawingPanel.BackColor = System.Drawing.SystemColors.Control;
            DrawingPanel.Paint += new PaintEventHandler(DrawingPanel_Paint);
            DrawingPanel.MouseDown += new MouseEventHandler(DrawingPanel_MouseDown);
            DrawingPanel.MouseMove += new MouseEventHandler(DrawingPanel_MouseMove);
            DrawingPanel.MouseUp += new MouseEventHandler(DrawingPanel_MouseUp);
            this.Controls.Add(DrawingPanel);
            DrawingPanel.Show();
        }

        private void q531_Load(object sender, EventArgs e)
        {
            width = 30;
            height = 30;
            myCanvas = new Bitmap(width, height,
                System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            Graphics g = Graphics.FromImage(myCanvas);
            g.Clear(Color.LightGray);
            //Sets all cells in myCanvas to be a dead cell and adds to list
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    cellList.Add(new Cell(new Point(x, y), true));
                }
            }
            timer1.Interval = trackBar1.Value;
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.InterpolationMode = InterpolationMode.NearestNeighbor;// smooths the blown up pixel
            g.DrawImage(myCanvas, 0, 0, DrawingPanel.Width, DrawingPanel.Height);
        }

        private void DrawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void DrawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown && timer1.Enabled == false)
            {
                //eX and eY is coordinates of where the mouse is clicked on
                int eX = (int)Math.Round((((double)e.X * (double)width) / (double)DrawingPanel.Width));
                int eY = (int)Math.Round((((double)e.Y * (double)height) / (double)DrawingPanel.Height));
                //Sets index to return what cell is currently at coords {eX, eY}
                int index = cellList.FindIndex(
                    delegate(Cell cell)
                    {
                        return cell.getLocation().Equals(new Point(eX, eY));
                    });
                //if cell is dead sets to alive
                if (cellList[index].getDead() && toggleButton.Text == "Set Alive Cells")
                {
                    cellList[index].setDead(false);
                }
                //if cell is alive sets to dead
                else if (!cellList[index].getDead() && toggleButton.Text == "Set Dead Cells")
                {
                    cellList[index].setDead(true);
                }
                cellList[index].Draw(myCanvas);
                this.Refresh();
            }
        }

        private void DrawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (startButton.Text == "Start")
            {
                timer1.Start();
                startButton.Text = "Stop";
            }
            else if (startButton.Text == "Stop")
            {
                timer1.Stop();
                startButton.Text = "Start";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            newDeadIndex.Clear();
            newLiveIndex.Clear();
            cellList.Clear();
            Graphics g = Graphics.FromImage(myCanvas);
            g.Clear(Color.LightGray);
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    cellList.Add(new Cell(new Point(x, y), true));
                }
            }
            this.Refresh();
        }

        private void toggleButton_Click(object sender, EventArgs e)
        {
            //Allows user to add alive cells or dead cells
            if (toggleButton.Text == "Set Alive Cells")
            {
                toggleButton.Text = "Set Dead Cells";
            }
            else if (toggleButton.Text == "Set Dead Cells")
            {
                toggleButton.Text = "Set Alive Cells";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            checkBox(cellList);
            this.Refresh();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            intervalLabel.Text = trackBar1.Value.ToString();
            timer1.Interval = trackBar1.Value;
        }

        private void presetCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //creates presets from the combo box
            switch (presetCombo.SelectedIndex)
            {
                case 0:
                    cellList[465].setDead(false);
                    cellList[465].Draw(myCanvas);
                    cellList[496].setDead(false);
                    cellList[496].Draw(myCanvas);
                    cellList[524].setDead(false);
                    cellList[524].Draw(myCanvas);
                    cellList[525].setDead(false);
                    cellList[525].Draw(myCanvas);
                    cellList[526].setDead(false);
                    cellList[526].Draw(myCanvas);
                    break;
                case 1:
                    cellList[465].setDead(false);
                    cellList[465].Draw(myCanvas);
                    cellList[494].setDead(false);
                    cellList[494].Draw(myCanvas);
                    cellList[495].setDead(false);
                    cellList[495].Draw(myCanvas);
                    cellList[496].setDead(false);
                    cellList[496].Draw(myCanvas);
                    cellList[524].setDead(false);
                    cellList[524].Draw(myCanvas);
                    cellList[526].setDead(false);
                    cellList[526].Draw(myCanvas);
                    cellList[555].setDead(false);
                    cellList[555].Draw(myCanvas);
                    break;
                case 2:
                    cellList[463].setDead(false);
                    cellList[463].Draw(myCanvas);
                    cellList[465].setDead(false);
                    cellList[465].Draw(myCanvas);
                    cellList[467].setDead(false);
                    cellList[467].Draw(myCanvas);
                    cellList[493].setDead(false);
                    cellList[493].Draw(myCanvas);
                    cellList[497].setDead(false);
                    cellList[497].Draw(myCanvas);
                    cellList[523].setDead(false);
                    cellList[523].Draw(myCanvas);
                    cellList[527].setDead(false);
                    cellList[527].Draw(myCanvas);
                    cellList[553].setDead(false);
                    cellList[553].Draw(myCanvas);
                    cellList[557].setDead(false);
                    cellList[557].Draw(myCanvas);
                    cellList[583].setDead(false);
                    cellList[583].Draw(myCanvas);
                    cellList[585].setDead(false);
                    cellList[585].Draw(myCanvas);
                    cellList[587].setDead(false);
                    cellList[587].Draw(myCanvas);
                    break;
                case 3:
                    cellList[460].setDead(false);
                    cellList[460].Draw(myCanvas);
                    cellList[461].setDead(false);
                    cellList[461].Draw(myCanvas);
                    cellList[462].setDead(false);
                    cellList[462].Draw(myCanvas);
                    cellList[463].setDead(false);
                    cellList[463].Draw(myCanvas);
                    cellList[464].setDead(false);
                    cellList[464].Draw(myCanvas);
                    cellList[465].setDead(false);
                    cellList[465].Draw(myCanvas);
                    cellList[466].setDead(false);
                    cellList[466].Draw(myCanvas);
                    cellList[467].setDead(false);
                    cellList[467].Draw(myCanvas);
                    cellList[468].setDead(false);
                    cellList[468].Draw(myCanvas);
                    cellList[469].setDead(false);
                    cellList[469].Draw(myCanvas);
                    break;
                case 4:
                    cellList[464].setDead(false);
                    cellList[464].Draw(myCanvas);
                    cellList[465].setDead(false);
                    cellList[465].Draw(myCanvas);
                    cellList[466].setDead(false);
                    cellList[466].Draw(myCanvas);
                    cellList[467].setDead(false);
                    cellList[467].Draw(myCanvas);
                    cellList[493].setDead(false);
                    cellList[493].Draw(myCanvas);
                    cellList[497].setDead(false);
                    cellList[497].Draw(myCanvas);
                    cellList[527].setDead(false);
                    cellList[527].Draw(myCanvas);
                    cellList[553].setDead(false);
                    cellList[553].Draw(myCanvas);
                    cellList[556].setDead(false);
                    cellList[556].Draw(myCanvas);
                    break;
                case 5:
                    cellList[463].setDead(false);
                    cellList[463].Draw(myCanvas);
                    cellList[464].setDead(false);
                    cellList[464].Draw(myCanvas);
                    cellList[466].setDead(false);
                    cellList[466].Draw(myCanvas);
                    cellList[467].setDead(false);
                    cellList[467].Draw(myCanvas);
                    cellList[493].setDead(false);
                    cellList[493].Draw(myCanvas);
                    cellList[494].setDead(false);
                    cellList[494].Draw(myCanvas);
                    cellList[496].setDead(false);
                    cellList[496].Draw(myCanvas);
                    cellList[497].setDead(false);
                    cellList[497].Draw(myCanvas);
                    cellList[524].setDead(false);
                    cellList[524].Draw(myCanvas);
                    cellList[526].setDead(false);
                    cellList[526].Draw(myCanvas);
                    cellList[554].setDead(false);
                    cellList[554].Draw(myCanvas);
                    cellList[556].setDead(false);
                    cellList[556].Draw(myCanvas);
                    cellList[552].setDead(false);
                    cellList[552].Draw(myCanvas);
                    cellList[554].setDead(false);
                    cellList[554].Draw(myCanvas);
                    cellList[556].setDead(false);
                    cellList[556].Draw(myCanvas);
                    cellList[558].setDead(false);
                    cellList[558].Draw(myCanvas);
                    cellList[582].setDead(false);
                    cellList[582].Draw(myCanvas);
                    cellList[584].setDead(false);
                    cellList[584].Draw(myCanvas);
                    cellList[586].setDead(false);
                    cellList[586].Draw(myCanvas);
                    cellList[588].setDead(false);
                    cellList[588].Draw(myCanvas);
                    cellList[612].setDead(false);
                    cellList[612].Draw(myCanvas);
                    cellList[613].setDead(false);
                    cellList[613].Draw(myCanvas);
                    cellList[617].setDead(false);
                    cellList[617].Draw(myCanvas);
                    cellList[618].setDead(false);
                    cellList[618].Draw(myCanvas);
                    break;
                default:
                    break;
            }
            this.Refresh();
        }

        /*Checks each box for tolerance level and moves*/
        private void checkBox(List<Cell> clist)
        {
            int lcount = 0;
            int dcount = 0;
            for (int i = 0; i < clist.Count; i++)
            {
                //if getDead() = true then is a dead cell
                if (clist[i].getDead())
                {
                    //top left
                    if (clist.Contains(new Cell(new Point((clist[i].getLocation().X - 1), clist[i].getLocation().Y - 1),false)))
                    {
                        dcount++;
                    }
                    //top
                    if (clist.Contains(new Cell(new Point(clist[i].getLocation().X, clist[i].getLocation().Y - 1), false)))
                    {
                        dcount++;
                    }
                    //top right
                    if (clist.Contains(new Cell(new Point(clist[i].getLocation().X + 1, clist[i].getLocation().Y - 1), false)))
                    {
                        dcount++;
                    }
                    //left
                    if (clist.Contains(new Cell(new Point(clist[i].getLocation().X - 1, clist[i].getLocation().Y), false)))
                    {
                        dcount++;
                    }
                    //right
                    if (clist.Contains(new Cell(new Point(clist[i].getLocation().X + 1, clist[i].getLocation().Y), false)))
                    {
                        dcount++;
                    }
                    //bottom left
                    if (clist.Contains(new Cell(new Point(clist[i].getLocation().X - 1, clist[i].getLocation().Y + 1), false)))
                    {
                        dcount++;
                    }
                    //bottom
                    if (clist.Contains(new Cell(new Point(clist[i].getLocation().X, clist[i].getLocation().Y + 1), false)))
                    {
                        dcount++;
                    }
                    //bottom right
                    if (clist.Contains(new Cell(new Point(clist[i].getLocation().X + 1, clist[i].getLocation().Y + 1), false)))
                    {
                        dcount++;
                    }
                }
                if (!clist[i].getDead())
                {
                    //top left
                    if (clist.Contains(new Cell(new Point(clist[i].getLocation().X - 1, clist[i].getLocation().Y - 1), false)))
                    {
                        lcount++;
                    }
                    //top
                    if (clist.Contains(new Cell(new Point(clist[i].getLocation().X, clist[i].getLocation().Y - 1), false)))
                    {
                        lcount++;
                    }
                    //top right
                    if (clist.Contains(new Cell(new Point(clist[i].getLocation().X + 1, clist[i].getLocation().Y - 1), false)))
                    {
                        lcount++;
                    }
                    //left
                    if (clist.Contains(new Cell(new Point(clist[i].getLocation().X - 1, clist[i].getLocation().Y), false)))
                    {
                        lcount++;
                    }
                    //right
                    if (clist.Contains(new Cell(new Point(clist[i].getLocation().X + 1, clist[i].getLocation().Y), false)))
                    {
                        lcount++;
                    }
                    //bottom left
                    if (clist.Contains(new Cell(new Point(clist[i].getLocation().X - 1, clist[i].getLocation().Y + 1), false)))
                    {
                        lcount++;
                    }
                    //bottom
                    if (clist.Contains(new Cell(new Point(clist[i].getLocation().X, clist[i].getLocation().Y + 1), false)))
                    {
                        lcount++;
                    }
                    //bottom right
                    if (clist.Contains(new Cell(new Point(clist[i].getLocation().X + 1, clist[i].getLocation().Y + 1), false)))
                    {
                        lcount++;
                    }
                }
                //implementing the counts
                if (lcount <= 1 && !clist[i].getDead())
                {
                    newDeadIndex.Add(i);
                }
                if (lcount >= 4 && !clist[i].getDead())
                {
                    newDeadIndex.Add(i);
                }
                if (dcount == 3 && clist[i].getDead())
                {
                    newLiveIndex.Add(i);
                }
                lcount = 0;
                dcount = 0;
            }
            foreach (int k in newDeadIndex)
            {
                cellList[k].setDead(true);
                cellList[k].Draw(myCanvas);
            }
            foreach (int h in newLiveIndex)
            {
                cellList[h].setDead(false);
                cellList[h].Draw(myCanvas);
            }
            newDeadIndex.Clear();
            newLiveIndex.Clear();
        }
        /********End of Function************/

    }
    public class DoubleBufferPanel : Panel
    {
        public DoubleBufferPanel()
        {
            // Set the value of the double-buffering style bits to true.
            // ControlStyles.UserPaint -- allows user to control painting w/o passing off the work to the operating system
            //ControlStyles.AllPaintingInWmPaint--optimize to reduce flicker but only use it if ControlStyles.UserPaint is true
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint, true);// | evaluates all conditions even if condition 1 is true
            this.UpdateStyles();//forces style to be applied
        }
    }
    /*Cell Class*/
    public class Cell : IEquatable<Cell>
    {
        private Point location;
        private bool dead;
        //Cell construtor with point and bool 
        public Cell()
        {
            dead = true;
            location = new Point(0, 0);
        }

        public Cell(Point p, bool deadd)
        {
            location = p;
            dead = deadd;
        }
        //Draw: draws the pixel to certain color dependent on if dead or alive
        public void Draw(Bitmap canvas)
        {
            if (dead)
            {
                canvas.SetPixel(location.X, location.Y, Color.LightGray);
            }
            else if (!dead)
            {
                canvas.SetPixel(location.X, location.Y, Color.Black);
            }
        }
        //Sets cell to be dead or alive
        public void setDead(bool deadd)
        {
            dead = deadd;
        }
        //Returns point location
        public Point getLocation()
        {
            return location;
        }
        //Returns bool state
        public bool getDead()
        {
            return dead;
        }
        //Returns bool of if one cell parameter is same as other cell
        public bool Equals(Cell other)
        {
            if (location == other.location && dead == other.dead)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}