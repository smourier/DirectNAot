namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSNODEPROPERTY_AUDIO_PROPERTY
{
    public KSNODEPROPERTY NodeProperty;
    public nint AppContext;
    public uint Length;
}
