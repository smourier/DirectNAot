#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-nccalcsize_params
public partial struct NCCALCSIZE_PARAMS
{
    public InlineArrayRECT_3 rgrc;
    public nint lppos;
}
