#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SharpenParams
{
    public float radius;
    public float amount;
}
