#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("90f1a06c-7712-4762-86b5-7a5eba6bdb02")]
public partial interface ICLRRuntimeHost
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Start();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Stop();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetHostControl([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IHostControl>))] IHostControl pHostControl);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCLRControl([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICLRControl>))] out ICLRControl pCLRControl);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnloadAppDomain(uint dwAppDomainId, BOOL fWaitUntilDone);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ExecuteInAppDomain(uint dwAppDomainId, FExecuteInAppDomainCallback pCallback, nint cookie);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentAppDomainId(out uint pdwAppDomainId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ExecuteApplication(PWSTR pwzAppFullName, uint dwManifestPaths, in PWSTR ppwzManifestPaths, uint dwActivationData, in PWSTR ppwzActivationData, out int pReturnValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ExecuteInDefaultAppDomain(PWSTR pwzAssemblyPath, PWSTR pwzTypeName, PWSTR pwzMethodName, PWSTR pwzArgument, out uint pReturnValue);
}
