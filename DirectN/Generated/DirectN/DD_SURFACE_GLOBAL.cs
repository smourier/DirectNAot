#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_surface_global
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_SURFACE_GLOBAL
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        public uint dwBlockSizeY;
        
        [FieldOffset(0)]
        public int lSlicePitch;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        public nint lpVidMemHeap;
        
        [FieldOffset(0)]
        public uint dwBlockSizeX;
        
        [FieldOffset(0)]
        public uint dwUserMemSize;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous3_e__Union
    {
        [FieldOffset(0)]
        public int lPitch;
        
        [FieldOffset(0)]
        public uint dwLinearSize;
    }
    
    public _Anonymous1_e__Union Anonymous1;
    public _Anonymous2_e__Union Anonymous2;
    public nuint fpVidMem;
    public _Anonymous3_e__Union Anonymous3;
    public int yHint;
    public int xHint;
    public uint wHeight;
    public uint wWidth;
    public nuint dwReserved1;
    public DDPIXELFORMAT ddpfSurface;
    public nuint fpHeapOffset;
    public HANDLE hCreatorProcess;
}
