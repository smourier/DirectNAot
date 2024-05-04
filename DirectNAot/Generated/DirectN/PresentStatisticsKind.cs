#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/presentationtypes/ne-presentationtypes-presentstatisticskind
public enum PresentStatisticsKind
{
    PresentStatisticsKind_PresentStatus = 1,
    PresentStatisticsKind_CompositionFrame = 2,
    PresentStatisticsKind_IndependentFlipFrame = 3,
}
