#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/nn-ocidl-ioleundomanager
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("d001f200-ef97-11ce-9bc9-00aa00608e01")]
public partial interface IOleUndoManager
{
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ioleundomanager-open
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Open([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOleParentUndoUnit>))] IOleParentUndoUnit pPUU);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ioleundomanager-close
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Close([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOleParentUndoUnit>))] IOleParentUndoUnit pPUU, BOOL fCommit);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ioleundomanager-add
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Add([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOleUndoUnit>))] IOleUndoUnit pUU);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ioleundomanager-getopenparentstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOpenParentState(out uint pdwState);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ioleundomanager-discardfrom
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DiscardFrom([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOleUndoUnit>))] IOleUndoUnit pUU);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ioleundomanager-undoto
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UndoTo([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOleUndoUnit>))] IOleUndoUnit pUU);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ioleundomanager-redoto
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RedoTo([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOleUndoUnit>))] IOleUndoUnit pUU);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ioleundomanager-enumundoable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumUndoable([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumOleUndoUnits>))] out IEnumOleUndoUnits ppEnum);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ioleundomanager-enumredoable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumRedoable([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumOleUndoUnits>))] out IEnumOleUndoUnits ppEnum);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ioleundomanager-getlastundodescription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLastUndoDescription(out BSTR pBstr);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ioleundomanager-getlastredodescription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLastRedoDescription(out BSTR pBstr);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ioleundomanager-enable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Enable(BOOL fEnable);
}
