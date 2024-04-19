namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSRTAUDIO_HWREGISTER_PROPERTY
{
    public KSIDENTIFIER Property;
    public nint BaseAddress;
}
