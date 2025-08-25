#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidl/nn-objidl-ipersiststorage
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("0000010a-0000-0000-c000-000000000046")]
public partial interface IPersistStorage : IPersist
{
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ipersiststorage-isdirty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsDirty();
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ipersiststorage-initnew
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitNew([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStorage>))] IStorage pStg);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ipersiststorage-load
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Load([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStorage>))] IStorage pStg);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ipersiststorage-save
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Save([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStorage>))] IStorage pStgSave, BOOL fSameAsLoad);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ipersiststorage-savecompleted
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SaveCompleted([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStorage>))] IStorage pStgNew);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ipersiststorage-handsoffstorage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT HandsOffStorage();
}
