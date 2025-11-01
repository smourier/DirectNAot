#nullable enable
namespace DirectN;

public partial struct ID3DShaderCacheInstallerClient
{
    public static readonly ID3DShaderCacheInstallerClient Null = new();
    
    public nint VTablePtr;
    
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT GetInstallerName(ref nuint pNameLength, [MarshalUsing(CountElementName = nameof(pNameLength))] PWSTR pName) =>
        ((delegate* unmanaged<ID3DShaderCacheInstallerClient*,nuint*,PWSTR*, HRESULT>)(((void**)*((void**)VTablePtr))[0]))((ID3DShaderCacheInstallerClient*)VTablePtr, (nuint*)Unsafe.AsPointer(ref pNameLength), (PWSTR*)Unsafe.AsPointer(ref pName));
    
    public readonly unsafe D3D_SHADER_CACHE_APP_REGISTRATION_SCOPE GetInstallerScope() =>
        ((delegate* unmanaged<ID3DShaderCacheInstallerClient*, D3D_SHADER_CACHE_APP_REGISTRATION_SCOPE>)(((void**)*((void**)VTablePtr))[1]))((ID3DShaderCacheInstallerClient*)VTablePtr);
    
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT HandleDriverUpdate([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DShaderCacheInstaller>))] ID3DShaderCacheInstaller pInstaller) =>
        ((delegate* unmanaged<ID3DShaderCacheInstallerClient*,ID3DShaderCacheInstaller, HRESULT>)(((void**)*((void**)VTablePtr))[2]))((ID3DShaderCacheInstallerClient*)VTablePtr, pInstaller);
}
