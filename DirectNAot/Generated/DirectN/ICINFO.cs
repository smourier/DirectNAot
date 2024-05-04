#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vfw/ns-vfw-icinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct ICINFO
{
    public uint dwSize;
    public uint fccType;
    public uint fccHandler;
    public uint dwFlags;
    public uint dwVersion;
    public uint dwVersionICM;
    public InlineArraySystemChar16 szName;
    public InlineArraySystemChar128 szDescription;
    public InlineArraySystemChar128 szDriver;
}
