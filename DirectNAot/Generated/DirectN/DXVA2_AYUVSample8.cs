#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva2api/ns-dxva2api-dxva2_ayuvsample8
[StructLayout(LayoutKind.Sequential)]
public partial struct DXVA2_AYUVSample8
{
    public byte Cr;
    public byte Cb;
    public byte Y;
    public byte Alpha;
}
