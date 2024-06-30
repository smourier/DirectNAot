#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/WMDM/opaquecommand
public partial struct OPAQUECOMMAND
{
    public Guid guidCommand;
    public uint dwDataLen;
    public nint pData;
    public InlineArrayByte_20 abMAC;
}
