﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_buffer_srv
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_BUFFER_SRV
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        public uint FirstElement;
        
        [FieldOffset(0)]
        public uint ElementOffset;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        public uint NumElements;
        
        [FieldOffset(0)]
        public uint ElementWidth;
    }
    
    public _Anonymous1_e__Union Anonymous1;
    public _Anonymous2_e__Union Anonymous2;
}
