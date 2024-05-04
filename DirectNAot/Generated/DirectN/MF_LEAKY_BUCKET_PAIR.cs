#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ns-mfidl-mf_leaky_bucket_pair
[StructLayout(LayoutKind.Sequential)]
public partial struct MF_LEAKY_BUCKET_PAIR
{
    public uint dwBitrate;
    public uint msBufferWindow;
}
