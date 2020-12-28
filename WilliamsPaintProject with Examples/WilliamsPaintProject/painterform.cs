/**William Lee Jarboe
 * Dr. Stringfellow
 * CMPS-4143-101
 * Program 6: Drawing Tool
 * 
 * Brief:
 *      This program has the intention of demonstrating a variety of coding practices. In particular:
 *      - Grouping radiobuttons and various other controls using groupboxes
 *      - Utilizing a panel as an artistic surface
 *          - a solid understanding of 2d coordinate based graphics methods
 *      - practicing rudimentary help menus
 *      - utilizing controls and events to manipulate other controls
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WilliamsPaintProject
{
    public partial class f1PaintProject : Form
    {
        bool ShouldPaintbrush { get; set; } = false;

        Pen myPen;

        Color currentColor;
        int brushWidth;
        int mode;
        Point prev;
        bool fillit = false;


        /**public f1Paintproject()
         * formal parameters: none
         * formal returns: none
         * effective function: initializes the project.
         */
        public f1PaintProject()
        {
            InitializeComponent();
            currentColor = Color.Black;
            mode = 1;
            brushWidth = 3;
            myPen = new Pen(new SolidBrush(currentColor), brushWidth);

        }

        /**private void drawingPanel_MouseDown(object sender, MouseEventArgs e)
         * formal parameters: object sender, mouseeventargs e - default parameters called by the event sender.
         * formal returns: none
         * effective function: When the mouse gets put down, in any mode, we need to take care of it
         * by saving the X and Y of the mouse down.
         */
        private void drawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (mode == 1)
            {
                ShouldPaintbrush = true;
                prev = e.Location;
            }
            else if(mode == 2 || mode == 3 || mode == 4)
            {
                prev = e.Location;
            }
        }

        /**private void drawingPanel_MouseUp(object sender, MouseEventArgs e)
         * formal parameters: object sender, mouseeventargs e - default parameters called by the event sender.
         * formal returns: none
         * effective function: draw whatever the user has asked for by now, f the state is in 2 or 3 or 4 that means
         * we have a shape to draw. Draw the shape!
         * 
         * WARNING: I noticed a bug (or, rather, obstacle...) where if the value of the x2 and y2 is negative, it doesn't draw it to the left or above like
         * you'd expect, so i included an array of draw statements so that it always draws a rectangle, regardless of the
         * coordinates start and end points being less than or greater than one another.
         */
        private void drawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            using (Graphics graphics = drawingPanel.CreateGraphics())
            {
                if (mode == 1)
                {
                    ShouldPaintbrush = false;
                }
                else if (mode == 2)
                {

                    graphics.DrawLine(myPen, prev, e.Location);
                }
                else if (mode == 3)
                {
                    if (!fillit)
                    { 
                        if (prev.X < e.X && prev.Y < e.Y)
                        {
                            graphics.DrawRectangle(myPen, prev.X, prev.Y, e.X - prev.X, e.Y - prev.Y);
                        }
                        else if (prev.X > e.X && prev.Y < e.Y)
                        {
                            graphics.DrawRectangle(myPen, e.X, prev.Y, prev.X - e.X, e.Y - prev.Y);
                        }
                        else if (prev.X < e.X && prev.Y > e.Y)
                        {
                            graphics.DrawRectangle(myPen, prev.X, e.Y, e.X - prev.X, prev.Y - e.Y);
                        }
                        else if (prev.X > e.X && prev.Y > e.Y)
                        {
                            graphics.DrawRectangle(myPen, e.X, e.Y, prev.X - e.X, prev.Y - e.Y);
                        }
                    }
                    else
                    {
                        if (prev.X < e.X && prev.Y < e.Y)
                        {
                            graphics.FillRectangle(new SolidBrush(currentColor), prev.X, prev.Y, e.X - prev.X, e.Y - prev.Y);
                        }
                        else if (prev.X > e.X && prev.Y < e.Y)
                        {
                            graphics.FillRectangle(new SolidBrush(currentColor), e.X, prev.Y, prev.X - e.X, e.Y - prev.Y);
                        }
                        else if (prev.X < e.X && prev.Y > e.Y)
                        {
                            graphics.FillRectangle(new SolidBrush(currentColor), prev.X, e.Y, e.X - prev.X, prev.Y - e.Y);
                        }
                        else if (prev.X > e.X && prev.Y > e.Y)
                        {
                            graphics.FillRectangle(new SolidBrush(currentColor), e.X, e.Y, prev.X - e.X, prev.Y - e.Y);
                        }
                    }
                }
                else if (mode == 4)
                {
                    if (!fillit)
                    {
                        if (prev.X < e.X && prev.Y < e.Y)
                        {
                            graphics.DrawEllipse(myPen, prev.X, prev.Y, e.X - prev.X, e.Y - prev.Y);
                        }
                        else if (prev.X > e.X && prev.Y < e.Y)
                        {
                            graphics.DrawEllipse(myPen, e.X, prev.Y, prev.X - e.X, e.Y - prev.Y);
                        }
                        else if (prev.X < e.X && prev.Y > e.Y)
                        {
                            graphics.DrawEllipse(myPen, prev.X, e.Y, e.X - prev.X, prev.Y - e.Y);
                        }
                        else if (prev.X > e.X && prev.Y > e.Y)
                        {
                            graphics.DrawEllipse(myPen, e.X, e.Y, prev.X - e.X, prev.Y - e.Y);
                        }
                    }
                    else
                    {
                        if (prev.X < e.X && prev.Y < e.Y)
                        {
                            graphics.FillEllipse(new SolidBrush(currentColor), prev.X, prev.Y, e.X - prev.X, e.Y - prev.Y);
                        }
                        else if (prev.X > e.X && prev.Y < e.Y)
                        {
                            graphics.FillEllipse(new SolidBrush(currentColor), e.X, prev.Y, prev.X - e.X, e.Y - prev.Y);
                        }
                        else if (prev.X < e.X && prev.Y > e.Y)
                        {
                            graphics.FillEllipse(new SolidBrush(currentColor), prev.X, e.Y, e.X - prev.X, prev.Y - e.Y);
                        }
                        else if (prev.X > e.X && prev.Y > e.Y)
                        {
                            graphics.FillEllipse(new SolidBrush(currentColor), e.X, e.Y, prev.X - e.X, prev.Y - e.Y);
                        }
                    }
                }
            }
        }


        /**private void drawingPanel_MouseMove(object sender, MouseEventArgs e)
         * formal parameters: object sender, mouseeventargs e - default parameters called by the event sender.
         * formal returns: none
         * effective function: when mouse is moved.. it should be drawinig if it's down and set to brush!
         */
        private void drawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mode == 1)
            {
                if (ShouldPaintbrush)
                {
                    using (Graphics graphics = drawingPanel.CreateGraphics())
                    {
                        graphics.DrawLine(myPen, prev, e.Location);
                        graphics.DrawEllipse(myPen, e.X, e.Y, 1, 1);//saves strange formations from happening at extreme brush sizes.
                        prev = e.Location;
                    }
                }
            }
        }


        /**private void btnClearDrawing_Click(object sender, EventArgs e)
         * formal parameters: object sender, mouseeventargs e - default parameters called by the event sender.
         * formal returns: none
         * effective functionality: clears the board. pretty self explanatory.
         */
        private void btnClearDrawing_Click(object sender, EventArgs e)
        {
            using (Graphics graphics = drawingPanel.CreateGraphics())
            {
                graphics.Clear(Color.FromKnownColor(KnownColor.Control));
            }
        }


        /**private void updateColor(object sender, EventArgs e)
         * formal parameters: object sender, mouseeventargs e - default parameters called by the event sender.
         * formal returns: none
         * effective functionality: changes the color to match the name of one of the radio buttons.
         */
        private void updateColor(object sender, EventArgs e)
        {
            currentColor = Color.FromName(gbxColors.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text);
            updateBrush();
        }

        /**private void updateSize(object sender, EventArgs e)
         * formal parameters: object sender, mouseeventargs e - default parameters called by the event sender.
         * formal returns: none
         * effective functionailty: sets the size to whatever the user wishes.
         */
        private void updateSize(object sender, EventArgs e)
        {
            switch (gbxSizes.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text)
            {
                case "Tiny":
                    brushWidth = 1;
                    break;
                case "Small":
                    brushWidth = 3;
                    break;
                case "Medium":
                    brushWidth = 6;
                    break;
                case "Large":
                    brushWidth = 12;
                    break;
            }
            updateBrush();
        }




        /**private void updateBrush()
         * formal parameters: none
         * formal returns: none
         * effective functionality: updates the brush to be the right color and size. called after color or size is updated.
         */
        private void updateBrush()
        {
            myPen = new Pen(new SolidBrush(currentColor), brushWidth);
        }

        /**private void cbxShapes_SelectedIndexChanged(object sender, EventArgs e)
         * formal parameters: object sender, mouseeventargs e - default parameters called by the event sender.
         * formal returns: none
         * effective functionality: corrects the drawing mode to be what the user currently wants it to be.
         */
        private void cbxShapes_SelectedIndexChanged(object sender, EventArgs e)
        {
            mode = cbxShapes.SelectedIndex+1;
        }

        /**private void btnHelp_Click(object sender, EventArgs e)
         * formal parameters: object sender, mouseeventargs e - default parameters called by the event sender.
         * formal returns: none
         * effective functionality: displays the help menu!
         */
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Choose a type of drawing tool at the top left\nusing the ComboBox, a size, and a color to draw in.\n\n" +
                "Brush tool:\n\t- Click and drag to leave a trail of the desired size.\n\n" +
                "Line tool:\n\t- Click where you would like to start the line,\n\t  then drag to the endpoint of the line and release.\n\n" +
                "Rectangle tool:\n\t- Click where you would like one corner to be,\n\t  then drag and release on the opposite corner.\n\n" +
                "Ellipse tool:\n\t- Click where you would like the outermost bound\n\t  of the ellipse to be, then drag and release to the\n\t  opposite bound");
        }

        /**private void cbFill_CheckedChanged(object sender, EventArgs e)
         * formal parameters: object sender, mouseeventargs e - default parameters called by the event sender.
         * formal returns: none
         * effective functionality: will fill shapes when checked, serves as a toggle that sets itself to the value of the cbFill checkbox.
         */
        private void cbFill_CheckedChanged(object sender, EventArgs e)
        {
            fillit = cbFill.Checked;
        }
    }
}
