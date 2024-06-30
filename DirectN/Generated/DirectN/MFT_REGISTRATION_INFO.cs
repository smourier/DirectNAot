#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ns-mfidl-mft_registration_info
public partial struct MFT_REGISTRATION_INFO
{
    public Guid clsid;
    public Guid guidCategory;
    public uint uiFlags;
    public PWSTR pszName;
    public uint cInTypes;
    public nint pInTypes;
    public uint cOutTypes;
    public nint pOutTypes;
}
