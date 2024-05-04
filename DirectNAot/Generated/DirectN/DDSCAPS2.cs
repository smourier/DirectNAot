#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddraw/ns-ddraw-ddscaps2
[StructLayout(LayoutKind.Sequential)]
public partial struct DDSCAPS2
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public uint dwCaps4;
        
        [FieldOffset(0)]
        public uint dwVolumeDepth;
    }
    
    public uint dwCaps;
    public uint dwCaps2;
    public uint dwCaps3;
    public _Anonymous_e__Union Anonymous;
}
