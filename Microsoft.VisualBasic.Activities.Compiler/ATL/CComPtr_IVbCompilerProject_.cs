﻿namespace ATL
{
    using Microsoft.VisualC;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Size=4), NativeCppClass, MiscellaneousBits(0x40), DebugInfoInPDB]
    internal struct CComPtr<IVbCompilerProject>
    {
    }
}

