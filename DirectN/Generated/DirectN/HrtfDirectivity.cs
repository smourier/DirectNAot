#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/hrtfapoapi/ns-hrtfapoapi-hrtfdirectivity
public partial struct HrtfDirectivity
{
    public HrtfDirectivityType type;
    public float scaling;
}
