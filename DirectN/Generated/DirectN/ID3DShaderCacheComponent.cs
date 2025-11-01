#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("eed1bf00-f5c7-4cf7-885c-d0f9c0cb4828")]
public partial interface ID3DShaderCacheComponent
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetComponentName(out nint pName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStateObjectDatabasePath(out nint pPath);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPrecompiledCachePath(PWSTR pAdapterFamily, ref ushort pPath);
    
    [PreserveSig]
    uint GetPrecompiledShaderDatabaseCount();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPrecompiledShaderDatabases(uint ArraySize, [In][Out][MarshalUsing(CountElementName = nameof(ArraySize))] D3D_SHADER_CACHE_PSDB_PROPERTIES[] pPSDBs);
}
