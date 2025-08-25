#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/nn-ocidl-ioleundounit
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("894ad3b0-ef97-11ce-9bc9-00aa00608e01")]
public partial interface IOleUndoUnit
{
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ioleundounit-do
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Do([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOleUndoManager>))] IOleUndoManager pUndoManager);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ioleundounit-getdescription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDescription(out BSTR pBstr);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ioleundounit-getunittype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUnitType(out Guid pClsid, out int plID);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ioleundounit-onnextadd
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnNextAdd();
}
