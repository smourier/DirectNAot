#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iampushsource
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("f185fe76-e64e-11d2-b76e-00c04fb6bd3d")]
public partial interface IAMPushSource : IAMLatency
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iampushsource-getpushsourceflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPushSourceFlags(out uint pFlags);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iampushsource-setpushsourceflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPushSourceFlags(uint Flags);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iampushsource-setstreamoffset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStreamOffset(long rtOffset);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iampushsource-getstreamoffset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamOffset(out long prtOffset);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iampushsource-getmaxstreamoffset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMaxStreamOffset(out long prtMaxOffset);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iampushsource-setmaxstreamoffset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMaxStreamOffset(long rtMaxOffset);
}
