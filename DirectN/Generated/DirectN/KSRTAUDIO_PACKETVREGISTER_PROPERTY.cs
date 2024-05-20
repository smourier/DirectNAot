#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSRTAUDIO_PACKETVREGISTER_PROPERTY
{
    public KSIDENTIFIER Property;
    public nint BaseAddress;
}
