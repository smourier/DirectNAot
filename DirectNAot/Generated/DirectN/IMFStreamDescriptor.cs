namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfstreamdescriptor
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("56c03d9c-9dbb-45f5-ab4b-d80f47c05938")]
public partial interface IMFStreamDescriptor : IMFAttributes
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfstreamdescriptor-getstreamidentifier
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamIdentifier(out uint pdwStreamIdentifier);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfstreamdescriptor-getmediatypehandler
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMediaTypeHandler(out IMFMediaTypeHandler ppMediaTypeHandler);
}
