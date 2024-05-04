#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-normalizedrect
[StructLayout(LayoutKind.Sequential)]
public partial struct NORMALIZEDRECT
{
    public float left;
    public float top;
    public float right;
    public float bottom;
}
