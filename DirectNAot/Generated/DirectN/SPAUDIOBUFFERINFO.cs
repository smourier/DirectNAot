#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPAUDIOBUFFERINFO
{
    public uint ulMsMinNotification;
    public uint ulMsBufferSize;
    public uint ulMsEventBias;
}
