namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-iesopenmmievent
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("ba4b6526-1a35-4635-8b56-3ec612746a8c")]
public partial interface IESOpenMmiEvent : IESEvent
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iesopenmmievent-getdialognumber
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDialogNumber(out uint pDialogRequest, out uint pDialogNumber);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iesopenmmievent-getdialogtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDialogType(out Guid guidDialogType);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iesopenmmievent-getdialogdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDialogData(out nint pbData);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iesopenmmievent-getdialogstringdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDialogStringData(out BSTR pbstrBaseUrl, out BSTR pbstrData);
}
