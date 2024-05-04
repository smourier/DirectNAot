#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-regpintypes
[StructLayout(LayoutKind.Sequential)]
public partial struct REGPINTYPES
{
    public nint clsMajorType;
    public nint clsMinorType;
}
