#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imftimecodetranslate
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("ab9d8661-f7e8-4ef4-9861-89f334f94e74")]
public partial interface IMFTimecodeTranslate
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftimecodetranslate-beginconverttimecodetohns
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginConvertTimecodeToHNS(in PROPVARIANT pPropVarTimecode, IMFAsyncCallback pCallback, nint punkState);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftimecodetranslate-endconverttimecodetohns
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndConvertTimecodeToHNS(IMFAsyncResult pResult, out long phnsTime);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftimecodetranslate-beginconverthnstotimecode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginConvertHNSToTimecode(long hnsTime, IMFAsyncCallback pCallback, nint punkState);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftimecodetranslate-endconverthnstotimecode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndConvertHNSToTimecode(IMFAsyncResult pResult, out PROPVARIANT pPropVarTimecode);
}
