namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/atscpsipparser/nn-atscpsipparser-icaptionservicedescriptor
[GeneratedComInterface, Guid("40834007-6834-46f0-bd45-d5f6a6be258c")]
public partial interface ICaptionServiceDescriptor
{
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-icaptionservicedescriptor-getnumberofservices
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNumberOfServices(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-icaptionservicedescriptor-getlanguagecode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLanguageCode(byte bIndex, nint /* byte array */ LangCode);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-icaptionservicedescriptor-getcaptionservicenumber
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCaptionServiceNumber(byte bIndex, nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-icaptionservicedescriptor-getcctype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCCType(byte bIndex, nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-icaptionservicedescriptor-geteasyreader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEasyReader(byte bIndex, nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-icaptionservicedescriptor-getwideaspectratio
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWideAspectRatio(byte bIndex, nint /* byte array */ pbVal);
}
