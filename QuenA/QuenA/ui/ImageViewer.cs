using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuenA.ui
{
    public partial class ImageViewer : Form
    {
        public ImageViewer(Image image)
        {
            InitializeComponent();
            
            Rectangle screenRectangle=RectangleToScreen(this.ClientRectangle);
            int titleHeight = screenRectangle.Top - this.Top;

            this.Width = image.Width;
            this.Height = image.Height + titleHeight;
            pictureBox.Image = image;
        }

        /// <summary>
        /// Closes the image being viewed when the image is double clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_DoubleClick(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
