#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("bbe30de1-6318-4526-ae17-776693191bb4")]
public partial interface ID3DShaderCacheInstaller
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterDriverUpdateListener();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnregisterDriverUpdateListener();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterServiceDriverUpdateTrigger(SC_HANDLE hServiceHandle);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnregisterServiceDriverUpdateTrigger(SC_HANDLE hServiceHandle);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterApplication(PWSTR pExePath, in D3D_SHADER_CACHE_APPLICATION_DESC pApplicationDesc, in Guid riid, out nint /* void */ ppvApp);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveApplication([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DShaderCacheApplication>))] ID3DShaderCacheApplication pApplication);
    
    [PreserveSig]
    uint GetApplicationCount();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetApplication(uint index, in Guid riid, out nint /* void */ ppvApp);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ClearAllState();
    
    [PreserveSig]
    uint GetMaxPrecompileTargetCount();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPrecompileTargets(nint /* optional D3D_SHADER_CACHE_APPLICATION_DESC* */ pApplicationDesc, ref uint pArraySize, [MarshalUsing(CountElementName = nameof(pArraySize))] out D3D_SHADER_CACHE_COMPILER_PROPERTIES[] pArray, D3D_SHADER_CACHE_TARGET_FLAGS flags);
}
