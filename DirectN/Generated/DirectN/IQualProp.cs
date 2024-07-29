#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/amvideo/nn-amvideo-iqualprop
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("1bd0ecb0-f8e2-11ce-aac6-0020af0b99a3")]
public partial interface IQualProp
{
    // https://learn.microsoft.com/windows/win32/api/amvideo/nf-amvideo-iqualprop-get_framesdroppedinrenderer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_FramesDroppedInRenderer(out int pcFrames);
    
    // https://learn.microsoft.com/windows/win32/api/amvideo/nf-amvideo-iqualprop-get_framesdrawn
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_FramesDrawn(out int pcFramesDrawn);
    
    // https://learn.microsoft.com/windows/win32/api/amvideo/nf-amvideo-iqualprop-get_avgframerate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AvgFrameRate(out int piAvgFrameRate);
    
    // https://learn.microsoft.com/windows/win32/api/amvideo/nf-amvideo-iqualprop-get_jitter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Jitter(out int iJitter);
    
    // https://learn.microsoft.com/windows/win32/api/amvideo/nf-amvideo-iqualprop-get_avgsyncoffset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AvgSyncOffset(out int piAvg);
    
    // https://learn.microsoft.com/windows/win32/api/amvideo/nf-amvideo-iqualprop-get_devsyncoffset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DevSyncOffset(out int piDev);
}
