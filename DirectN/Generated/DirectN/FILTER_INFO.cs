#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-filter_info
public partial struct FILTER_INFO
{
    public InlineArraySystemChar_128 achName;
    public nint pGraph;
}
