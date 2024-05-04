#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSAUDIO_MIXCAP_TABLE
{
    public uint InputChannels;
    public uint OutputChannels;
    public InlineArrayKSAUDIO_MIX_CAPS1 Capabilities; // variable-length array placeholder
}
