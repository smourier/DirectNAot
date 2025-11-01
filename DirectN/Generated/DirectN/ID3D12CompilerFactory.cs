#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("c1ee4b59-3f59-47a5-9b4e-a855c858a878")]
public partial interface ID3D12CompilerFactory
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumerateAdapterFamilies(uint AdapterFamilyIndex, out D3D12_ADAPTER_FAMILY pAdapterFamily);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumerateAdapterFamilyABIVersions(uint AdapterFamilyIndex, ref uint pNumABIVersions, nint /* optional ulong* */ pABIVersions);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumerateAdapterFamilyCompilerVersion(uint AdapterFamilyIndex, out D3D12_VERSION_NUMBER pCompilerVersion);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetApplicationProfileVersion(in D3D12_COMPILER_TARGET pTarget, in D3D12_APPLICATION_DESC pApplicationDesc, out D3D12_VERSION_NUMBER pApplicationProfileVersion);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCompilerCacheSession([In][MarshalUsing(CountElementName = nameof(NumPaths))] D3D12_COMPILER_DATABASE_PATH[] pPaths, uint NumPaths, nint /* optional D3D12_COMPILER_TARGET* */ pTarget, nint /* optional D3D12_APPLICATION_DESC* */ pApplicationDesc, in Guid riid, out nint /* void */ ppCompilerCacheSession);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCompiler([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12CompilerCacheSession>))] ID3D12CompilerCacheSession pCompilerCacheSession, in Guid riid, out nint /* void */ ppCompiler);
}
