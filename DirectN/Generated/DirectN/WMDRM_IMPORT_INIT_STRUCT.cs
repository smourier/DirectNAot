#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ns-wmsdkidl-wmdrm_import_init_struct
public partial struct WMDRM_IMPORT_INIT_STRUCT
{
    public uint dwVersion;
    public uint cbEncryptedSessionKeyMessage;
    public nint pbEncryptedSessionKeyMessage;
    public uint cbEncryptedKeyMessage;
    public nint pbEncryptedKeyMessage;
}
