#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/qnetwork/nn-qnetwork-iamnetshowexprops
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("fa2aa8f5-8b62-11d0-a520-000000000000")]
public partial interface IAMNetShowExProps : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamnetshowexprops-get_sourceprotocol
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SourceProtocol(ref int pSourceProtocol);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamnetshowexprops-get_bandwidth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Bandwidth(ref int pBandwidth);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamnetshowexprops-get_errorcorrection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ErrorCorrection(ref BSTR pbstrErrorCorrection);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamnetshowexprops-get_codeccount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CodecCount(ref int pCodecCount);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamnetshowexprops-getcodecinstalled
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCodecInstalled(int CodecNum, ref VARIANT_BOOL pCodecInstalled);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamnetshowexprops-getcodecdescription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCodecDescription(int CodecNum, ref BSTR pbstrCodecDescription);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamnetshowexprops-getcodecurl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCodecURL(int CodecNum, ref BSTR pbstrCodecURL);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamnetshowexprops-get_creationdate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CreationDate(ref double pCreationDate);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamnetshowexprops-get_sourcelink
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SourceLink(ref BSTR pbstrSourceLink);
}
