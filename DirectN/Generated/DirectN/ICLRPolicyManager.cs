#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("7d290010-d781-45da-a6f8-aa5d711a730e")]
public partial interface ICLRPolicyManager
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDefaultAction(EClrOperation operation, EPolicyAction action);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTimeout(EClrOperation operation, uint dwMilliseconds);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetActionOnTimeout(EClrOperation operation, EPolicyAction action);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTimeoutAndAction(EClrOperation operation, uint dwMilliseconds, EPolicyAction action);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetActionOnFailure(EClrFailure failure, EPolicyAction action);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetUnhandledExceptionPolicy(EClrUnhandledException policy);
}
