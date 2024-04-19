namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ns-mfidl-asf_flat_picture
[StructLayout(LayoutKind.Sequential)]
public partial struct ASF_FLAT_PICTURE
{
    public byte bPictureType;
    public uint dwDataLen;
}
