﻿namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DD_SETCLIPLISTDATA
{
    public nint lpDD;
    public nint lpDDSurface;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint SetClipList;
}
