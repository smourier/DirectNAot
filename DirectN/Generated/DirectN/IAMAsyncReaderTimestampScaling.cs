#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamasyncreadertimestampscaling
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("cf7b26fc-9a00-485b-8147-3e789d5e8f67")]
public partial interface IAMAsyncReaderTimestampScaling
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamasyncreadertimestampscaling-gettimestampmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTimestampMode(out BOOL pfRaw);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamasyncreadertimestampscaling-settimestampmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTimestampMode(BOOL fRaw);
}
