#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ns-dxvahd-dxvahdsw_callbacks
[StructLayout(LayoutKind.Sequential)]
public partial struct DXVAHDSW_CALLBACKS
{
    public nint CreateDevice;
    public nint ProposeVideoPrivateFormat;
    public nint GetVideoProcessorDeviceCaps;
    public nint GetVideoProcessorOutputFormats;
    public nint GetVideoProcessorInputFormats;
    public nint GetVideoProcessorCaps;
    public nint GetVideoProcessorCustomRates;
    public nint GetVideoProcessorFilterRange;
    public nint DestroyDevice;
    public nint CreateVideoProcessor;
    public nint SetVideoProcessBltState;
    public nint GetVideoProcessBltStatePrivate;
    public nint SetVideoProcessStreamState;
    public nint GetVideoProcessStreamStatePrivate;
    public nint VideoProcessBltHD;
    public nint DestroyVideoProcessor;
}
