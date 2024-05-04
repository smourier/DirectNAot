#nullable enable
namespace DirectN;

public enum SpeechStreamSeekPositionType : uint
{
    SSSPTRelativeToStart = 0,
    SSSPTRelativeToCurrentPosition = 1,
    SSSPTRelativeToEnd = 2,
}
