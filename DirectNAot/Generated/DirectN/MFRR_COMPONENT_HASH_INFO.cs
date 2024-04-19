namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ns-mfidl-mfrr_component_hash_info
[StructLayout(LayoutKind.Sequential)]
public partial struct MFRR_COMPONENT_HASH_INFO
{
    public uint ulReason;
    public InlineArrayChar43 rgHeaderHash;
    public InlineArrayChar43 rgPublicKeyHash;
    public InlineArraySystemChar260 wszName;
}
