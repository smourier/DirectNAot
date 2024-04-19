namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPROPERTY_VIDEODECODER_STATUS2_S
{
    public KSIDENTIFIER Property;
    public uint NumberOfLines;
    public uint SignalLocked;
    public uint ChromaLock;
}
