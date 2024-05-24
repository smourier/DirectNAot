#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ns-mfidl-asf_flat_picture
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct ASF_FLAT_PICTURE
{
    public byte bPictureType;
    public uint dwDataLen;
}
