#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/nn-ocidl-ipersiststreaminit
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("7fd52380-4e07-101b-ae2d-08002b2ec713")]
public partial interface IPersistStreamInit : IPersist
{
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipersiststreaminit-isdirty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsDirty();
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipersiststreaminit-load
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Load([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] IStream pStm);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipersiststreaminit-save
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Save([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] IStream pStm, BOOL fClearDirty);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipersiststreaminit-getsizemax
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSizeMax(out ulong pCbSize);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipersiststreaminit-initnew
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitNew();
}
