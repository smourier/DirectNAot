#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_2/ns-dxgi1_2-dxgi_outdupl_frame_info
public partial struct DXGI_OUTDUPL_FRAME_INFO
{
    public long LastPresentTime;
    public long LastMouseUpdateTime;
    public uint AccumulatedFrames;
    public BOOL RectsCoalesced;
    public BOOL ProtectedContentMaskedOut;
    public DXGI_OUTDUPL_POINTER_POSITION PointerPosition;
    public uint TotalMetadataBufferSize;
    public uint PointerShapeBufferSize;
}
