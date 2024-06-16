#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/ns-dwrite-dwrite_inline_object_metrics
[StructLayout(LayoutKind.Sequential)]
public partial struct DWRITE_INLINE_OBJECT_METRICS
{
    public float width;
    public float height;
    public float baseline;
    public BOOL supportsSideways;
}
