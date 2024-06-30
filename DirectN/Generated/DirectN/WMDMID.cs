#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/WMDM/wmdmid
public partial struct WMDMID
{
    public uint cbSize;
    public uint dwVendorID;
    public InlineArrayByte_128 pID;
    public uint SerialNumberLength;
}
