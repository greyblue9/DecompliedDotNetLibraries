﻿namespace System.Deployment.Internal.Isolation.Manifest
{
    using System;
    using System.Runtime.InteropServices;
    using System.Security;

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("55b2dec1-d0f6-4bf4-91b1-30f73ad8e4df")]
    internal interface IMuiResourceTypeIdIntEntry
    {
        System.Deployment.Internal.Isolation.Manifest.MuiResourceTypeIdIntEntry AllData { [SecurityCritical] get; }
        object StringIds { [return: MarshalAs(UnmanagedType.Interface)] [SecurityCritical] get; }
        object IntegerIds { [return: MarshalAs(UnmanagedType.Interface)] [SecurityCritical] get; }
    }
}

