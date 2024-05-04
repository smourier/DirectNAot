#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/presentation/ns-presentation-compositionframedisplayinstance
[StructLayout(LayoutKind.Sequential)]
public partial struct CompositionFrameDisplayInstance
{
    public LUID displayAdapterLUID;
    public uint displayVidPnSourceId;
    public uint displayUniqueId;
    public LUID renderAdapterLUID;
    public CompositionFrameInstanceKind instanceKind;
    public PresentationTransform finalTransform;
    public byte requiredCrossAdapterCopy;
    public DXGI_COLOR_SPACE_TYPE colorSpace;
}
