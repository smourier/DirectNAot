#nullable enable
namespace DirectN;

public enum LineCap
{
    LineCapFlat = 0,
    LineCapSquare = 1,
    LineCapRound = 2,
    LineCapTriangle = 3,
    LineCapNoAnchor = 16,
    LineCapSquareAnchor = 17,
    LineCapRoundAnchor = 18,
    LineCapDiamondAnchor = 19,
    LineCapArrowAnchor = 20,
    LineCapCustom = 255,
    LineCapAnchorMask = 240,
}
