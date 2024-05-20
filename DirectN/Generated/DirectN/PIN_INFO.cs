#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-pin_info
[StructLayout(LayoutKind.Sequential)]
public partial struct PIN_INFO
{
    public nint pFilter;
    public PIN_DIRECTION dir;
    public InlineArraySystemChar_128 achName;
}
