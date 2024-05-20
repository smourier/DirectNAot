#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/presentationtypes/ns-presentationtypes-presentationtransform
[StructLayout(LayoutKind.Sequential)]
public partial struct PresentationTransform
{
    public float M11;
    public float M12;
    public float M21;
    public float M22;
    public float M31;
    public float M32;
}
