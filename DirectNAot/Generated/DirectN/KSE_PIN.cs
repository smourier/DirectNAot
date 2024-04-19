namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSE_PIN
{
    public KSIDENTIFIER Event;
    public uint PinId;
    public uint Reserved;
}
