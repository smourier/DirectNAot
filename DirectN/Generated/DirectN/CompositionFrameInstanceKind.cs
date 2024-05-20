#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/presentation/ne-presentation-compositionframeinstancekind
public enum CompositionFrameInstanceKind
{
    CompositionFrameInstanceKind_ComposedOnScreen = 0,
    CompositionFrameInstanceKind_ScanoutOnScreen = 1,
    CompositionFrameInstanceKind_ComposedToIntermediate = 2,
}
