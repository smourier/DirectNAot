#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamtimecodegenerator
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("9b496ce0-811b-11cf-8c77-00aa006b6814")]
public partial interface IAMTimecodeGenerator
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtimecodegenerator-gettcgmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTCGMode(int Param, out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtimecodegenerator-settcgmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTCGMode(int Param, int Value);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtimecodegenerator-put_vitcline
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_VITCLine(int Line);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtimecodegenerator-get_vitcline
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_VITCLine(out int pLine);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtimecodegenerator-settimecode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTimecode(in TIMECODE_SAMPLE pTimecodeSample);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtimecodegenerator-gettimecode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTimecode(out TIMECODE_SAMPLE pTimecodeSample);
}
