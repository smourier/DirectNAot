#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("4862efbe-3ae5-44f8-8feb-346190ee8a34")]
public partial interface ICLRTaskManager
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateTask([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICLRTask>))] out ICLRTask pTask);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentTask([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICLRTask>))] out ICLRTask pTask);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetUILocale(uint lcid);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetLocale(uint lcid);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentTaskType(out ETaskType pTaskType);
}
