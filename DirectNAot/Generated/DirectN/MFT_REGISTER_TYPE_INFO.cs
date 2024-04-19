namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/ns-mfobjects-mft_register_type_info
[StructLayout(LayoutKind.Sequential)]
public partial struct MFT_REGISTER_TYPE_INFO
{
    public Guid guidMajorType;
    public Guid guidSubtype;
}
