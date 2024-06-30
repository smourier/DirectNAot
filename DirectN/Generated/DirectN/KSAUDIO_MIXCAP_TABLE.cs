#nullable enable
namespace DirectN;

public partial struct KSAUDIO_MIXCAP_TABLE
{
    public uint InputChannels;
    public uint OutputChannels;
    public InlineArrayKSAUDIO_MIX_CAPS_1 Capabilities; // variable-length array placeholder
}
