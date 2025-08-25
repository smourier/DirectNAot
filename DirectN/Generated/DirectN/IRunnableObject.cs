#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidl/nn-objidl-irunnableobject
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00000126-0000-0000-c000-000000000046")]
public partial interface IRunnableObject
{
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-irunnableobject-getrunningclass
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRunningClass(out Guid lpClsid);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-irunnableobject-run
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Run([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBindCtx>))] IBindCtx pbc);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-irunnableobject-isrunning
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    BOOL IsRunning();
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-irunnableobject-lockrunning
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LockRunning(BOOL fLock, BOOL fLastUnlockCloses);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-irunnableobject-setcontainedobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetContainedObject(BOOL fContained);
}
