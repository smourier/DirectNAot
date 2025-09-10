#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("00dcaec6-2ac0-43a9-acf9-1e36c139b10d")]
public partial interface ICLRDebugManager
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginConnection(uint dwConnectionId, PWSTR szConnectionName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetConnectionTasks(uint id, uint dwCount, [In][MarshalUsing(CountElementName = nameof(dwCount))] ICLRTask[] ppCLRTask);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndConnection(uint dwConnectionId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDacl(in ACL pacl);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDacl(out nint pacl);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsDebuggerAttached(out BOOL pbAttached);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSymbolReadingPolicy(ESymbolReadingPolicy policy);
}
