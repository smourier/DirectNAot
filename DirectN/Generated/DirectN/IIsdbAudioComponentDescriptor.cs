#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvbsiparser/nn-dvbsiparser-iisdbaudiocomponentdescriptor
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("679d2002-2425-4be4-a4c7-d6632a574f4d")]
public partial interface IIsdbAudioComponentDescriptor
{
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbaudiocomponentdescriptor-gettag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTag(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbaudiocomponentdescriptor-getlength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLength(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbaudiocomponentdescriptor-getstreamcontent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamContent(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbaudiocomponentdescriptor-getcomponenttype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetComponentType(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbaudiocomponentdescriptor-getcomponenttag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetComponentTag(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbaudiocomponentdescriptor-getstreamtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamType(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbaudiocomponentdescriptor-getsimulcastgrouptag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSimulcastGroupTag(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbaudiocomponentdescriptor-getesmultilingualflag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetESMultiLingualFlag(out BOOL pfVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbaudiocomponentdescriptor-getmaincomponentflag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMainComponentFlag(out BOOL pfVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbaudiocomponentdescriptor-getqualityindicator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetQualityIndicator(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbaudiocomponentdescriptor-getsamplingrate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSamplingRate(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbaudiocomponentdescriptor-getlanguagecode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLanguageCode(nint /* byte array */ pszCode);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbaudiocomponentdescriptor-getlanguagecode2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLanguageCode2(nint /* byte array */ pszCode);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbaudiocomponentdescriptor-gettextw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTextW(DVB_STRCONV_MODE convMode, out BSTR pbstrText);
}
