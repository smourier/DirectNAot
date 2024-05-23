#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/nn-ocidl-ienumconnections
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("b196b287-bab4-101a-b69c-00aa00341d07")]
public partial interface IEnumConnections
{
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ienumconnections-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint cConnections, [In][Out][MarshalUsing(CountElementName = nameof(cConnections))] CONNECTDATA[] rgcd, out uint pcFetched);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ienumconnections-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint cConnections);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ienumconnections-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ienumconnections-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumConnections>))] out IEnumConnections ppEnum);
}
