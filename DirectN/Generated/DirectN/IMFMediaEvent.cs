#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/nn-mfobjects-imfmediaevent
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("df598932-f10c-4e39-bba2-c308f101daa3")]
public partial interface IMFMediaEvent : IMFAttributes
{
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfmediaevent-gettype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetType(out uint pmet);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfmediaevent-getextendedtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetExtendedType(out Guid pguidExtendedType);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfmediaevent-getstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStatus(out HRESULT phrStatus);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfmediaevent-getvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetValue(out PROPVARIANT pvValue);
}
