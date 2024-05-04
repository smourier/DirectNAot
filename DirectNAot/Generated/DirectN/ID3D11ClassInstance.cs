#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/nn-d3d11-id3d11classinstance
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("a6cd7faa-b0b7-4a2f-9436-8662a65797cb")]
public partial interface ID3D11ClassInstance : ID3D11DeviceChild
{
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11classinstance-getclasslinkage
    [PreserveSig]
    void GetClassLinkage(out ID3D11ClassLinkage ppLinkage);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11classinstance-getdesc
    [PreserveSig]
    void GetDesc(out D3D11_CLASS_INSTANCE_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11classinstance-getinstancename
    [PreserveSig]
    void GetInstanceName([MarshalUsing(CountElementName = nameof(pBufferLength))] out PSTR[] pInstanceName, ref nuint pBufferLength);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11classinstance-gettypename
    [PreserveSig]
    void GetTypeName([MarshalUsing(CountElementName = nameof(pBufferLength))] out PSTR[] pTypeName, ref nuint pBufferLength);
}
