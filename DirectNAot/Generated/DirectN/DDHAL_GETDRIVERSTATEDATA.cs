﻿namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_GETDRIVERSTATEDATA
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public nuint dwhContext;
    }
    
    public uint dwFlags;
    public _Anonymous_e__Union Anonymous;
    public nint lpdwStates;
    public uint dwLength;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
}
