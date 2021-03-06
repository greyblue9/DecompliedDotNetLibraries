﻿namespace System.Xml
{
    using System;

    internal abstract class HtmlTernaryTree
    {
        internal static byte[] htmlAttributes = new byte[] { 
            0x48, 5, 0x4d, 0, 0x52, 0, 0, 0, 0x45, 0, 0, 0, 70, 0, 0, 0, 
            0, 0, 0, 1, 0x43, 12, 40, 0, 0x4f, 7, 0, 0, 0x4d, 0x1f, 0, 0, 
            80, 0, 0, 0, 0x41, 0, 0, 0, 0x43, 0, 0, 0, 0x54, 0, 0, 0, 
            0, 0, 0, 2, 0x49, 11, 0x12, 0, 0x54, 0, 0, 0, 0x45, 0, 0, 0, 
            0, 0, 0, 1, 0x41, 0, 0, 0, 0x43, 0, 0, 0, 0x54, 0, 0, 0, 
            0x49, 0, 0, 0, 0x4f, 0, 0, 0, 0x4e, 0, 0, 0, 0, 0, 0, 1, 
            0x48, 0, 0, 0, 0x45, 0, 0, 0, 0x43, 0, 0, 0, 0x4b, 0, 0, 0, 
            0x45, 0, 0, 0, 0x44, 0, 0, 0, 0, 0, 0, 2, 0x4c, 0, 0, 0, 
            0x41, 0, 0, 0, 0x53, 0, 0, 0, 0x53, 0, 0, 0, 0x49, 0, 0, 0, 
            0x44, 0, 0, 0, 0, 0, 0, 1, 0x44, 0, 0, 0, 0x45, 0, 0, 0, 
            0x42, 0, 0, 0, 0x41, 0, 0, 0, 0x53, 0, 0, 0, 0x45, 0, 0, 0, 
            0, 0, 0, 1, 0x44, 0, 0x1c, 0, 0x45, 7, 15, 0, 0x43, 0, 0x16, 0, 
            0x4c, 0, 0, 0, 0x41, 0, 0, 0, 0x52, 0, 0, 0, 0x45, 0, 0, 0, 
            0, 0, 0, 2, 0x41, 0, 0, 0, 0x54, 0, 0, 0, 0x41, 0, 0, 0, 
            0, 0, 1, 1, 0x53, 0, 0, 0, 0x52, 0, 0, 0, 0x43, 0, 0, 0, 
            0, 0, 0, 1, 0x49, 0, 0, 0, 0x53, 0, 0, 0, 0x41, 0, 0, 0, 
            0x42, 0, 0, 0, 0x4c, 0, 0, 0, 0x45, 0, 0, 0, 0x44, 0, 0, 0, 
            0, 0, 0, 2, 70, 0, 0, 0, 0x45, 0, 0, 0, 0x52, 0, 0, 0, 
            0, 0, 0, 2, 70, 0, 0, 0, 0x4f, 0, 0, 0, 0x52, 0, 0, 0, 
            0, 0, 0, 1, 0x4e, 8, 0x30, 0, 0x4f, 0x24, 0, 0, 0x53, 30, 0x37, 0, 
            0x48, 0, 0, 0, 0x41, 0, 0, 0, 0x44, 0, 0, 0, 0x45, 0, 0, 0, 
            0, 0, 0, 2, 0x4d, 9, 0, 0, 0x55, 0, 0, 0, 0x4c, 0, 0, 0, 
            0x54, 0, 0, 0, 0x49, 0, 0, 0, 80, 0, 0, 0, 0x4c, 0, 0, 0, 
            0x45, 0, 0, 0, 0, 0, 0, 2, 0x49, 0, 6, 0, 0x53, 0, 0, 0, 
            0x4d, 0, 0, 0, 0x41, 0, 0, 0, 80, 0, 0, 0, 0, 0, 0, 2, 
            0x4c, 0, 0, 0, 0x4f, 0, 0, 0, 0x4e, 0, 0, 0, 0x47, 0, 0, 0, 
            0x44, 0, 0, 0, 0x45, 0, 0, 0, 0x53, 0, 0, 0, 0x43, 0, 0, 0, 
            0, 0, 0, 1, 0x48, 0, 9, 0, 0x52, 0, 0, 0, 0x45, 0, 0, 0, 
            70, 0, 0, 0, 0, 0, 0, 2, 0x41, 0, 0, 0, 0x4d, 0, 0, 0, 
            0x45, 0, 0, 0, 0, 0, 0, 1, 0x52, 0, 0, 0, 0x45, 0, 0, 0, 
            0x53, 0, 0, 0, 0x49, 0, 0, 0, 90, 0, 0, 0, 0x45, 0, 0, 0, 
            0, 0, 0, 2, 0x52, 14, 0x16, 0, 0x45, 0, 0, 0, 0x41, 0, 0, 0, 
            0x44, 0, 0, 0, 0x4f, 0, 0, 0, 0x4e, 0, 0, 0, 0x4c, 0, 0, 0, 
            0x59, 0, 0, 0, 0, 0, 0, 2, 0x57, 0, 0, 0, 0x52, 0, 0, 0, 
            0x41, 0, 0, 0, 80, 0, 0, 0, 0, 0, 0, 2, 80, 0, 0, 0, 
            0x52, 0, 0, 0, 0x4f, 0, 0, 0, 70, 0, 0, 0, 0x49, 0, 0, 0, 
            0x4c, 0, 0, 0, 0x45, 0, 0, 0, 0, 0, 0, 1, 0x53, 0, 12, 0, 
            0x52, 3, 0, 0, 0x43, 0, 0, 0, 0, 0, 0, 1, 0x45, 0, 0, 0, 
            0x4c, 0, 0, 0, 0x45, 0, 0, 0, 0x43, 0, 0, 0, 0x54, 0, 0, 0, 
            0x45, 0, 0, 0, 0x44, 0, 0, 0, 0, 0, 0, 2, 0x55, 0, 0, 0, 
            0x53, 0, 0, 0, 0x45, 0, 0, 0, 0x4d, 0, 0, 0, 0x41, 0, 0, 0, 
            80, 0, 0, 0, 0, 0, 0, 1
         };
        internal static byte[] htmlElements = new byte[] { 
            0x49, 4, 0x93, 0, 0x4d, 140, 0xa2, 0, 0x47, 0, 0, 0, 0, 0, 0, 11, 
            0x44, 4, 0x55, 0, 0x49, 0x47, 0x5c, 0, 0x56, 0x51, 0, 0, 0, 0, 0, 0x40, 
            0x42, 3, 0x2d, 0, 0x52, 0x15, 0x37, 0, 0, 0, 0, 8, 0x41, 0, 0, 0, 
            0x52, 4, 0, 0, 0x45, 0, 0, 0, 0x41, 0, 0, 0, 0, 0, 0, 0x4b, 
            0x44, 7, 8, 0, 0x44, 0, 0, 0, 0x52, 0, 0, 0, 0x45, 0, 0, 0, 
            0x53, 0, 0, 0, 0x53, 0, 0, 0, 0, 0, 0, 0x40, 0, 0, 0, 1, 
            80, 0, 0, 0, 80, 0, 0, 0, 0x4c, 0, 0, 0, 0x45, 0, 0, 0, 
            0x54, 0, 0, 0, 0, 0, 0, 0x40, 0x41, 0, 9, 0, 0x53, 0, 0, 0, 
            0x45, 0, 0, 0, 70, 5, 0, 0, 0x4f, 0, 0, 0, 0x4e, 0, 0, 0, 
            0x54, 0, 0, 0, 0, 0, 0, 0x48, 0, 0, 0, 0x49, 0x4c, 0, 10, 0, 
            0x4f, 0, 0, 0, 0x43, 0, 0, 0, 0x4b, 0, 0, 0, 0x51, 0, 0, 0, 
            0x55, 0, 0, 0, 0x4f, 0, 0, 0, 0x54, 0, 0, 0, 0x45, 0, 0, 0, 
            0, 0, 0, 0x41, 0x4f, 0, 0, 0, 0x44, 0, 0, 0, 0x59, 0, 0, 0, 
            0, 0, 0, 0x40, 0x43, 0, 0, 0, 0x4f, 3, 0, 0, 0x4c, 0, 0, 0, 
            0, 0, 0x16, 0x48, 0x41, 0, 13, 0, 80, 0, 0, 0, 0x54, 0, 0, 0, 
            0x49, 0, 0, 0, 0x4f, 0, 0, 0, 0x4e, 0, 0, 0, 0, 0, 0, 0x40, 
            0x55, 0, 0, 0, 0x54, 0, 0, 0, 0x54, 0, 0, 0, 0x4f, 0, 0, 0, 
            0x4e, 0, 0, 0, 0, 0, 0, 2, 0x45, 0, 0, 0, 0x4e, 0, 0, 0, 
            0x54, 0, 0, 0, 0x45, 0, 0, 0, 0x52, 0, 0, 0, 0, 0, 0, 0x40, 
            0x44, 0, 8, 0, 0, 0, 0, 0x40, 0x47, 0, 0, 0, 0x52, 0, 0, 0, 
            0x4f, 0, 0, 0, 0x55, 0, 0, 0, 80, 0, 0, 0, 0, 0, 0, 0x40, 
            0x45, 0, 0, 0, 0x4c, 0, 0, 0, 0, 0, 0, 0x41, 0x52, 0, 0, 0, 
            0, 0, 0, 0x42, 0x48, 3, 0, 0, 50, 0x1f, 0x21, 0, 0, 0, 0, 0x40, 
            70, 0, 0, 0, 0x4f, 8, 0x10, 0, 0x4e, 0, 20, 0, 0x54, 0, 0, 0, 
            0, 0, 0, 0x40, 0x54, 2, 0, 0, 0, 0, 0, 0x40, 0x4c, 0, 0, 0, 
            0, 0, 0, 0x42, 0x49, 0, 0, 0, 0x45, 0, 0, 0, 0x4c, 0, 0, 0, 
            0x44, 0, 0, 0, 0x53, 0, 0, 0, 0x45, 0, 0, 0, 0x54, 0, 0, 0, 
            0, 0, 0, 0x40, 0x52, 0, 0, 0, 0x41, 0, 0, 0, 0x4d, 0, 0, 0, 
            0x45, 0, 0, 0, 0, 0, 4, 0x4a, 0x52, 0, 0, 0, 0x4d, 0, 0, 0, 
            0, 0, 0, 0x41, 0x53, 0, 0, 0, 0x45, 0, 0, 0, 0x54, 0, 0, 0, 
            0, 0, 0, 0x40, 0x31, 0, 0, 0, 0, 0, 0, 0x40, 0x36, 2, 8, 0, 
            0, 0, 0, 0x40, 0x34, 2, 4, 0, 0, 0, 0, 0x40, 0x33, 0, 0, 0, 
            0, 0, 0, 0x40, 0x35, 0, 0, 0, 0, 0, 0, 0x40, 0x52, 2, 6, 0, 
            0, 0, 0, 0x4a, 0x45, 0, 0, 0, 0x41, 0, 0, 0, 0x44, 0, 0, 0, 
            0, 0, 0, 0x61, 0x54, 0, 0, 0, 0x4d, 0, 0, 0, 0x4c, 0, 0, 0, 
            0, 0, 0, 0x40, 70, 0, 0, 0, 0x52, 0, 0, 0, 0x41, 0, 0, 0, 
            0x4d, 0, 0, 0, 0x45, 0, 0, 0, 0, 0, 0, 0x40, 80, 4, 0x54, 0, 
            0x52, 0x4d, 0, 0, 0x45, 0, 0, 0, 0, 0, 0, 0x40, 0x4d, 5, 0x25, 0, 
            0x45, 30, 0, 0, 0x54, 0x20, 0, 0, 0x41, 0, 0, 0, 0, 0, 0, 0x48, 
            0x4c, 0, 0, 0, 0x45, 0, 20, 0, 0x47, 0, 0, 0, 0x45, 0, 0, 0, 
            0x4e, 0, 0, 0, 0x44, 0, 0, 0, 0, 0, 0, 0x40, 0x4e, 0, 7, 0, 
            0x53, 2, 0, 0, 0, 0, 0, 0x41, 80, 0, 0, 0, 0x55, 0, 0, 0, 
            0x54, 0, 0, 0, 0, 0, 0, 11, 0x53, 0, 0, 0, 0x49, 0, 0, 0, 
            0x4e, 0, 0, 0, 0x44, 0, 0, 0, 0x45, 0, 0, 0, 0x58, 0, 0, 0, 
            0, 0, 0, 0x48, 0x49, 0, 0, 0, 0x4e, 3, 0, 0, 0x4b, 0, 0, 0, 
            0, 0, 0, 0x49, 0, 0, 0, 0x40, 0x41, 0, 0, 0, 80, 0, 0, 0, 
            0, 0, 0, 0x40, 0x4e, 0, 0, 0, 0x55, 0, 0, 0, 0, 0, 0, 0x42, 
            0x4f, 3, 0, 0, 0x4c, 0x12, 0x18, 0, 0, 0, 0, 0x42, 0x4e, 0, 0, 0, 
            0x4f, 0, 0, 0, 0x53, 7, 0, 0, 0x43, 0, 0, 0, 0x52, 0, 0, 0, 
            0x49, 0, 0, 0, 80, 0, 0, 0, 0x54, 0, 0, 0, 0, 0, 0, 0x40, 
            70, 0, 0, 0, 0x52, 0, 0, 0, 0x41, 0, 0, 0, 0x4d, 0, 0, 0, 
            0x45, 0, 0, 0, 0x53, 0, 0, 0, 0, 0, 0, 0x40, 0x42, 0, 0, 0, 
            0x4a, 0, 0, 0, 0x45, 0, 0, 0, 0x43, 0, 0, 0, 0x54, 0, 0, 0, 
            0, 0, 0, 3, 80, 0, 0, 0, 0x54, 0, 0, 0, 0x49, 4, 0, 0, 
            0x4f, 0, 0, 0, 0x4e, 0, 0, 0, 0, 0, 0, 0x42, 0x47, 0, 0, 0, 
            0x52, 0, 0, 0, 0x4f, 0, 0, 0, 0x55, 0, 0, 0, 80, 0, 0, 0, 
            0, 0, 0, 0x42, 0, 0, 1, 0x40, 0x41, 0, 0, 0, 0x52, 0, 0, 0, 
            0x41, 0, 0, 0, 0x4d, 0, 0, 0, 0, 0, 0, 0x48, 0x54, 3, 0x41, 0, 
            0x44, 0x1c, 0x26, 0, 0, 0, 0, 0x42, 0x53, 8, 0, 0, 0x45, 6, 15, 0, 
            0x4c, 0, 0, 0, 0x45, 0, 0, 0, 0x43, 0, 0, 0, 0x54, 0, 0, 0, 
            0, 0, 0, 2, 0, 0, 3, 0x40, 0x51, 0, 0, 0, 0, 0, 0, 1, 
            0x43, 0, 0, 0, 0x52, 0, 0, 0, 0x49, 0, 0, 0, 80, 0, 0, 0, 
            0x54, 0, 0, 0, 0, 0, 0, 0x13, 0x54, 0, 0, 0, 0x59, 4, 0, 0, 
            0x4c, 0, 0, 0, 0x45, 0, 0, 0, 0, 0, 0, 80, 0x52, 0, 0, 0, 
            0x49, 0, 0, 0, 0x4b, 0, 0, 0, 0x45, 0, 0, 0, 0, 0, 0, 0x40, 
            0x41, 0, 5, 0, 0x42, 0, 0, 0, 0x4c, 0, 0, 0, 0x45, 0, 0, 0, 
            0, 0, 0, 0x41, 0x42, 0, 0, 0, 0x4f, 0, 0, 0, 0x44, 0, 0, 0, 
            0x59, 0, 0, 0, 0, 0, 0, 0x40, 0x48, 5, 0x13, 0, 0x45, 0x11, 0, 0, 
            0x41, 0, 0, 0, 0x44, 0, 0, 0, 0, 0, 0, 0x40, 70, 5, 0, 0, 
            0x4f, 0, 0, 0, 0x4f, 0, 0, 0, 0x54, 0, 0, 0, 0, 0, 0, 0x40, 
            0x45, 0, 0, 0, 0x58, 0, 0, 0, 0x54, 0, 0, 0, 0x41, 0, 0, 0, 
            0x52, 0, 0, 0, 0x45, 0, 0, 0, 0x41, 0, 0, 0, 0, 0, 0, 2, 
            0, 0, 0, 0x42, 0x52, 2, 0, 0, 0, 0, 0, 0x40, 0x49, 0, 0, 0, 
            0x54, 0, 0, 0, 0x4c, 0, 0, 0, 0x45, 0, 0, 0, 0, 0, 0, 0x40, 
            0x55, 0, 3, 0, 0x4c, 0, 0, 0, 0, 0, 0, 0x42, 0x58, 0, 0, 0, 
            0x4d, 0, 0, 0, 80, 0, 0, 0, 0, 0, 0, 0x40
         };

        protected HtmlTernaryTree()
        {
        }
    }
}

