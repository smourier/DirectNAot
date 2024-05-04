#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vmr9/ns-vmr9-vmr9normalizedrect
[StructLayout(LayoutKind.Sequential)]
public partial struct VMR9NormalizedRect
{
    public float left;
    public float top;
    public float right;
    public float bottom;
}
