#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-clipobj
public partial struct CLIPOBJ
{
    public uint iUniq;
    public RECTL rclBounds;
    public byte iDComplexity;
    public byte iFComplexity;
    public byte iMode;
    public byte fjOptions;
}
