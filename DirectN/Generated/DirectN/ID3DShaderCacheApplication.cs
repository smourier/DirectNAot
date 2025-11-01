#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("fc688ee2-1b35-4913-93be-1ca3fa7df39e")]
public partial interface ID3DShaderCacheApplication
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetExePath(out nint pExePath);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesc(out D3D_SHADER_CACHE_APPLICATION_DESC pApplicationDesc);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterComponent(PWSTR pName, PWSTR pStateObjectDBPath, uint NumPSDB, [In][MarshalUsing(CountElementName = nameof(NumPSDB))] D3D_SHADER_CACHE_PSDB_PROPERTIES[] pPSDBs, in Guid riid, out nint /* void */ ppvComponent);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveComponent([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DShaderCacheComponent>))] ID3DShaderCacheComponent pComponent);
    
    [PreserveSig]
    uint GetComponentCount();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetComponent(uint index, in Guid riid, out nint /* void */ ppvComponent);
    
    [PreserveSig]
    uint GetPrecompileTargetCount(D3D_SHADER_CACHE_TARGET_FLAGS flags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPrecompileTargets(uint ArraySize, [In][MarshalUsing(CountElementName = nameof(ArraySize))] D3D_SHADER_CACHE_COMPILER_PROPERTIES[] pArray, D3D_SHADER_CACHE_TARGET_FLAGS flags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInstallerName(out nint pInstallerName);
}
