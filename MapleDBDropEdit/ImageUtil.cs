using System;
using System.Drawing;
using System.Runtime.InteropServices; // Required for DestroyIcon

namespace MapleDBDropEdit
{
    static class ImageUtil
    {
        [DllImport("user32.dll")]
        private static extern bool DestroyIcon(IntPtr handle);

        public static Icon ConvertBitmapToIcon(Bitmap bitmap)
        {
            if (bitmap == null)
            {
                throw new ArgumentNullException(nameof(bitmap));
            }

            // Get an Hicon for the bitmap
            IntPtr hIcon = bitmap.GetHicon();

            // Create a new icon from the handle
            Icon icon = (Icon)Icon.FromHandle(hIcon).Clone();

            // You can destroy the original Hicon handle if you are done with it
            // Note: The Icon object creates its own copy, so destroying the handle
            // after creating the Icon object is generally safe.
            DestroyIcon(hIcon);

            return icon;
        }
    }
}
