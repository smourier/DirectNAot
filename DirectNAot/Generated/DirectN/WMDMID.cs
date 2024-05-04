#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/WMDM/wmdmid
[StructLayout(LayoutKind.Sequential)]
public partial struct WMDMID
{
    public uint cbSize;
    public uint dwVendorID;
    public InlineArrayByte128 pID;
    public uint SerialNumberLength;
}
