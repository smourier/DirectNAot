#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ns-mfidl-mfrr_component_hash_info
[StructLayout(LayoutKind.Sequential)]
public partial struct MFRR_COMPONENT_HASH_INFO
{
    public uint ulReason;
    public InlineArrayChar_43 rgHeaderHash;
    public InlineArrayChar_43 rgPublicKeyHash;
    public InlineArraySystemChar_260 wszName;
}
