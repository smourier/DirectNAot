#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/nn-ocidl-ioleparentundounit
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("a1faf330-ef97-11ce-9bc9-00aa00608e01")]
public partial interface IOleParentUndoUnit : IOleUndoUnit
{
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ioleparentundounit-open
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Open([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOleParentUndoUnit>))] IOleParentUndoUnit pPUU);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ioleparentundounit-close
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Close([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOleParentUndoUnit>))] IOleParentUndoUnit pPUU, BOOL fCommit);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ioleparentundounit-add
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Add([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOleUndoUnit>))] IOleUndoUnit pUU);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ioleparentundounit-findunit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindUnit([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOleUndoUnit>))] IOleUndoUnit pUU);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ioleparentundounit-getparentstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetParentState(out uint pdwState);
}
