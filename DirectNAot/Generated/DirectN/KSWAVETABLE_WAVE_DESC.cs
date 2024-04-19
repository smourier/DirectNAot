namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSWAVETABLE_WAVE_DESC
{
    public KSIDENTIFIER Identifier;
    public uint Size;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool Looped;
    public uint LoopPoint;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool InROM;
    public KSDATAFORMAT Format;
}
