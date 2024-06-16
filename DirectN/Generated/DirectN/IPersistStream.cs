#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidl/nn-objidl-ipersiststream
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00000109-0000-0000-c000-000000000046")]
public partial interface IPersistStream : IPersist
{
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ipersiststream-isdirty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsDirty();
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ipersiststream-load
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Load(IStream pStm);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ipersiststream-save
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Save(IStream pStm, BOOL fClearDirty);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ipersiststream-getsizemax
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSizeMax(out ulong pcbSize);
}
