#nullable enable
namespace DirectN;

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
    
    public BOOL Mute;
    public int Minimum;
    public int Maximum;
    public _Anonymous_e__Union Anonymous;
}
