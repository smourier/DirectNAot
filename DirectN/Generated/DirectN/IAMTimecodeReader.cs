#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamtimecodereader
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("9b496ce1-811b-11cf-8c77-00aa006b6814")]
public partial interface IAMTimecodeReader
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtimecodereader-gettcrmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTCRMode(int Param, out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtimecodereader-settcrmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTCRMode(int Param, int Value);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtimecodereader-put_vitcline
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_VITCLine(int Line);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtimecodereader-get_vitcline
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_VITCLine(out int pLine);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtimecodereader-gettimecode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTimecode(out TIMECODE_SAMPLE pTimecodeSample);
}
