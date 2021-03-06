﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace AeroSuite
{
    /// <summary>
    /// Provides a method for extracting images from the system via LoadImage
    /// </summary>
    public static class IconExtractor
    {
        /// <summary>
        /// Loads the icon.
        /// </summary>
        /// <param name="type">The type of icon.</param>
        /// <param name="size">The size.</param>
        /// <returns>The icon.</returns>
        /// <exception cref="System.PlatformNotSupportedException"></exception>
        public static Icon LoadIcon(IconType type, Size size)
        {
            IntPtr hIcon = NativeMethods.LoadImage(IntPtr.Zero, "#" + (int)type, 1, size.Width, size.Height, 0);
            return hIcon == IntPtr.Zero ? null : Icon.FromHandle(hIcon);
        }

        public enum IconType
        {
            Warning = 101,
            Help = 102,
            Error = 103,
            Info = 104,
            Shield = 106
        }
    }
}
