#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_miscellaneouscallbacks
public partial struct DD_MISCELLANEOUSCALLBACKS
{
    public uint dwSize;
    public uint dwFlags;
    public nint GetAvailDriverMemory;
}
