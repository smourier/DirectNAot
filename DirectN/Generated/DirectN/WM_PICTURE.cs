#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ns-wmsdkidl-wm_picture
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct WM_PICTURE
{
    public PWSTR pwszMIMEType;
    public byte bPictureType;
    public PWSTR pwszDescription;
    public uint dwDataLen;
    public nint pbData;
}
