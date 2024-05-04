#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_1/ns-dwrite_1-dwrite_unicode_range
[StructLayout(LayoutKind.Sequential)]
public partial struct DWRITE_UNICODE_RANGE
{
    public uint first;
    public uint last;
}
