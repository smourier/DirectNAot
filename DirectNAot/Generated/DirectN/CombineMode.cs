#nullable enable
namespace DirectN;

public enum CombineMode
{
    CombineModeReplace = 0,
    CombineModeIntersect = 1,
    CombineModeUnion = 2,
    CombineModeXor = 3,
    CombineModeExclude = 4,
    CombineModeComplement = 5,
}
