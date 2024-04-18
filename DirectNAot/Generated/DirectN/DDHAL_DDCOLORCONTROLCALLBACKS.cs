namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_DDCOLORCONTROLCALLBACKS
{
    public uint dwSize;
    public uint dwFlags;
    public nint ColorControl;
}
