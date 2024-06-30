#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_nonlocalvidmemcaps
public partial struct DD_NONLOCALVIDMEMCAPS
{
    public uint dwSize;
    public uint dwNLVBCaps;
    public uint dwNLVBCaps2;
    public uint dwNLVBCKeyCaps;
    public uint dwNLVBFXCaps;
    public InlineArrayUInt32_8 dwNLVBRops;
}
