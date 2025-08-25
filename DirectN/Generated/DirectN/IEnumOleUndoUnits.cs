#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/nn-ocidl-ienumoleundounits
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("b3e7c340-ef97-11ce-9bc9-00aa00608e01")]
public partial interface IEnumOleUndoUnits
{
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ienumoleundounits-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint cElt, [In][Out][MarshalUsing(CountElementName = nameof(cElt))] nint[] rgElt, out uint pcEltFetched);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ienumoleundounits-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint cElt);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ienumoleundounits-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ienumoleundounits-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumOleUndoUnits>))] out IEnumOleUndoUnits ppEnum);
}
