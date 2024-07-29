#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/nn-bdaiface-ibda_guidedatadeliveryservice
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("c0afcb73-23e7-4bc6-bafa-fdc167b4719f")]
public partial interface IBDA_GuideDataDeliveryService
{
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_guidedatadeliveryservice-getguidedatatype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGuideDataType(out Guid pguidDataType);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_guidedatadeliveryservice-getguidedata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGuideData(ref uint pulcbBufferLen, nint /* byte array */ pbBuffer, out uint pulGuideDataPercentageProgress);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_guidedatadeliveryservice-requestguidedataupdate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RequestGuideDataUpdate();
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_guidedatadeliveryservice-gettunexmlfromserviceidx
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTuneXmlFromServiceIdx(ulong ul64ServiceIdx, out BSTR pbstrTuneXml);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_guidedatadeliveryservice-getservices
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetServices(ref uint pulcbBufferLen, nint /* byte array */ pbBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_guidedatadeliveryservice-getserviceinfofromtunexml
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetServiceInfoFromTuneXml(BSTR bstrTuneXml, out BSTR pbstrServiceDescription);
}
