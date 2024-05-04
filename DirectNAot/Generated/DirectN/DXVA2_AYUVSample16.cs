#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva2api/ns-dxva2api-dxva2_ayuvsample16
[StructLayout(LayoutKind.Sequential)]
public partial struct DXVA2_AYUVSample16
{
    public ushort Cr;
    public ushort Cb;
    public ushort Y;
    public ushort Alpha;
}
