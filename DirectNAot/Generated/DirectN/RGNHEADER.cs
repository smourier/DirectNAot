#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct RGNHEADER
{
    public RGNRANGE RangeKey;
    public RGNRANGE RangeVelocity;
    public ushort fusOptions;
    public ushort usKeyGroup;
}
