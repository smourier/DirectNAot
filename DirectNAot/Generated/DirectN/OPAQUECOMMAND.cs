#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/WMDM/opaquecommand
[StructLayout(LayoutKind.Sequential)]
public partial struct OPAQUECOMMAND
{
    public Guid guidCommand;
    public uint dwDataLen;
    public nint pData;
    public InlineArrayByte20 abMAC;
}
