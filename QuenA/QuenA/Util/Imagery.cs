using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuenA.Util
{
    class Imagery
    {

        /// <summary>
        /// Resizes an image to the size that fits in a thumbnail slot in a form.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <returns></returns>
        public static Image resizeImageToSquareThumbnail(Image image, int thumbSize)
        {
            int longestSide = Math.Max(image.Width, image.Height);
            int resizedWidth = (thumbSize * image.Width) / longestSide;
            int resizedHeight = (thumbSize * image.Height) / longestSide;

            Image resizedThumbnail = new Bitmap(resizedWidth, resizedHeight);
            Graphics.FromImage(resizedThumbnail).DrawImage(image, 0, 0, resizedWidth, resizedHeight);
            return resizedThumbnail;
        }
    }
}
