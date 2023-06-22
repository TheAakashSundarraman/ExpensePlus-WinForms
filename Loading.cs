using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpensePlus
{
    /// <summary>
    /// This is the loading screen backend code that gets called when the loading screen is shown.
    /// </summary>
    public partial class Loading : Form
    {
        /// <summary>
        /// The below region dictates all private variables for the application.
        /// These 3 private variables would be used throughout the application for dragging the application from one screen to another.
        /// </summary>
        #region private variables
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        #endregion

        /// <summary>
        /// Constructor that is used to invoke the following:
        /// Initialize components from the designer.
        /// Enable a timer so that we can show the progress bar. 
        /// </summary>
        #region Constructor
        public Loading()
        {
            InitializeComponent();
            tmrForm.Enabled = true;
        }
        #endregion

        #region Private methods
        /// <summary>
        /// This method is leveraged by the timer to show the progress bar,
        /// Note that we intentionally slow the application using a thread.sleep so that users can see the progress bar.
        /// If you remove that piece of code, progress bar becomes too quick.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrForm_Tick(object sender, EventArgs e)
        {
            tmrForm.Enabled = false;

            for (int d = 0; d < 100; d++)
            {
                Thread.Sleep(100);
                pgBar.Value = d;
            }
            Hide();
            new Login().Show();
        }
        /// <summary>
        /// This method identifies that the user has clicked on the mouse down button,
        /// once the click has occured the system sets a flag as true, this flag would only be reset after the drag event has finished.
        /// The system also identifies the users current cursor position as a Point (X,Y)
        /// and sets the dragFormPoint to this location.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Loading_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        /// <summary>
        /// Based on the flag set above, the system would go inside and perform a simple difference between what the previous location was
        /// determined the variable dragCursorPoint and the current position and find the difference.
        /// Once the diff is determined the system can now simply move the form from the previous location to the new location.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Loading_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        /// <summary>
        /// Once the user has lifted the mouse button up, the system resets the dragging variable making a safe assumption that the form movement is complete.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Loading_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        } 
        #endregion
    }
}
