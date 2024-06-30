#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfapi/ns-mfapi-facecharacterization
public partial struct FaceCharacterization
{
    public uint BlinkScoreLeft;
    public uint BlinkScoreRight;
    public uint FacialExpression;
    public uint FacialExpressionScore;
}
