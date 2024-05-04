#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDSCAPSEX
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public uint dwCaps4;
        
        [FieldOffset(0)]
        public uint dwVolumeDepth;
    }
    
    public uint dwCaps2;
    public uint dwCaps3;
    public _Anonymous_e__Union Anonymous;
}
