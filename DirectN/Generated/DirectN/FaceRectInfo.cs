#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfapi/ns-mfapi-facerectinfo
public partial struct FaceRectInfo
{
    public RECT Region;
    public int confidenceLevel;
}
