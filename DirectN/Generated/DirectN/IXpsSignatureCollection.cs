#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nn-xpsdigitalsignature-ixpssignaturecollection
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("a2d1d95d-add2-4dff-ab27-6b9c645ff322")]
public partial interface IXpsSignatureCollection
{
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignaturecollection-getcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCount(out uint count);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignaturecollection-getat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAt(uint index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsSignature>))] out IXpsSignature signature);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignaturecollection-removeat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveAt(uint index);
}
