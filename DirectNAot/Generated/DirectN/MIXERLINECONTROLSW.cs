#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmeapi/ns-mmeapi-mixerlinecontrolsw
[StructLayout(LayoutKind.Sequential)]
public partial struct MIXERLINECONTROLSW
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public uint dwControlID;
        
        [FieldOffset(0)]
        public uint dwControlType;
    }
    
    public uint cbStruct;
    public uint dwLineID;
    public _Anonymous_e__Union Anonymous;
    public uint cControls;
    public uint cbmxctrl;
    public nint pamxctrl;
}
