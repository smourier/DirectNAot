namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ns-wmsdkidl-wm_leaky_bucket_pair
[StructLayout(LayoutKind.Sequential)]
public partial struct WM_LEAKY_BUCKET_PAIR
{
    public uint dwBitrate;
    public uint msBufferWindow;
}
