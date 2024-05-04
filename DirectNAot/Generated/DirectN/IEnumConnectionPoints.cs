#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/nn-ocidl-ienumconnectionpoints
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("b196b285-bab4-101a-b69c-00aa00341d07")]
public partial interface IEnumConnectionPoints
{
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ienumconnectionpoints-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint cConnections, [MarshalUsing(CountElementName = nameof(cConnections))] out IConnectionPoint[] ppCP, out uint pcFetched);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ienumconnectionpoints-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint cConnections);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ienumconnectionpoints-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ienumconnectionpoints-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone(out IEnumConnectionPoints ppEnum);
}
