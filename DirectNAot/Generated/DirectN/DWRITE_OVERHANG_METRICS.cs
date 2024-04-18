namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/ns-dwrite-dwrite_overhang_metrics
[StructLayout(LayoutKind.Sequential)]
public partial struct DWRITE_OVERHANG_METRICS
{
    public float left;
    public float top;
    public float right;
    public float bottom;
}
