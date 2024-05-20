#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSAUDIO_MIX_CAPS
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public int Reset;
        
        [FieldOffset(0)]
        public int Resolution;
    }
    
    [MarshalAs(UnmanagedType.U4)]
    public bool Mute;
    public int Minimum;
    public int Maximum;
    public _Anonymous_e__Union Anonymous;
}
