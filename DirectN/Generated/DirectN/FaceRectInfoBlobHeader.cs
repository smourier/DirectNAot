#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfapi/ns-mfapi-facerectinfoblobheader
[StructLayout(LayoutKind.Sequential)]
public partial struct FaceRectInfoBlobHeader
{
    public uint Size;
    public uint Count;
}
