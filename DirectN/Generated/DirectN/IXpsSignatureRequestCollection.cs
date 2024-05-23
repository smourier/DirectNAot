#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nn-xpsdigitalsignature-ixpssignaturerequestcollection
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("f0253e68-9f19-412e-9b4f-54d3b0ac6cd9")]
public partial interface IXpsSignatureRequestCollection
{
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignaturerequestcollection-getcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCount(out uint count);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignaturerequestcollection-getat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAt(uint index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsSignatureRequest>))] out IXpsSignatureRequest signatureRequest);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignaturerequestcollection-removeat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveAt(uint index);
}
