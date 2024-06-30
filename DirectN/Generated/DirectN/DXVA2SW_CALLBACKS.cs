#nullable enable
namespace DirectN;

public partial struct DXVA2SW_CALLBACKS
{
    public uint Size;
    public nint GetVideoProcessorRenderTargetCount;
    public nint GetVideoProcessorRenderTargets;
    public nint GetVideoProcessorCaps;
    public nint GetVideoProcessorSubStreamFormatCount;
    public nint GetVideoProcessorSubStreamFormats;
    public nint GetProcAmpRange;
    public nint GetFilterPropertyRange;
    public nint CreateVideoProcessDevice;
    public nint DestroyVideoProcessDevice;
    public nint VideoProcessBeginFrame;
    public nint VideoProcessEndFrame;
    public nint VideoProcessSetRenderTarget;
    public nint VideoProcessBlt;
}
