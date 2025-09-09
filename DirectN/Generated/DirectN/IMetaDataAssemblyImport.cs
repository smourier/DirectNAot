#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/rometadataapi/nn-rometadataapi-imetadataassemblyimport
[GeneratedComInterface, Guid("ee62470b-e94b-424e-9b7c-2f00c9249f93")]
public partial interface IMetaDataAssemblyImport
{
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataassemblyimport-getassemblyprops
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAssemblyProps(uint mda, out nint ppbPublicKey, ref uint pcbPublicKey, ref uint pulHashAlgId, [MarshalUsing(CountElementName = nameof(cchName))] PWSTR szName, uint cchName, ref uint pchName, ref ASSEMBLYMETADATA pMetaData, ref uint pdwAssemblyFlags);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataassemblyimport-getassemblyrefprops
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAssemblyRefProps(uint mdar, out nint ppbPublicKeyOrToken, ref uint pcbPublicKeyOrToken, [MarshalUsing(CountElementName = nameof(cchName))] PWSTR szName, uint cchName, ref uint pchName, ref ASSEMBLYMETADATA pMetaData, out nint ppbHashValue, ref uint pcbHashValue, ref uint pdwAssemblyRefFlags);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataassemblyimport-getfileprops
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFileProps(uint mdf, [MarshalUsing(CountElementName = nameof(cchName))] PWSTR szName, uint cchName, ref uint pchName, out nint ppbHashValue, ref uint pcbHashValue, ref uint pdwFileFlags);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataassemblyimport-getexportedtypeprops
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetExportedTypeProps(uint mdct, [MarshalUsing(CountElementName = nameof(cchName))] PWSTR szName, uint cchName, ref uint pchName, ref uint ptkImplementation, ref uint ptkTypeDef, ref uint pdwExportedTypeFlags);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataassemblyimport-getmanifestresourceprops
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetManifestResourceProps(uint mdmr, [MarshalUsing(CountElementName = nameof(cchName))] PWSTR szName, uint cchName, ref uint pchName, ref uint ptkImplementation, ref uint pdwOffset, ref uint pdwResourceFlags);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataassemblyimport-enumassemblyrefs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumAssemblyRefs(out nint phEnum, ref uint rAssemblyRefs, uint cMax, ref uint pcTokens);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataassemblyimport-enumfiles
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumFiles(out nint phEnum, ref uint rFiles, uint cMax, ref uint pcTokens);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataassemblyimport-enumexportedtypes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumExportedTypes(out nint phEnum, ref uint rExportedTypes, uint cMax, ref uint pcTokens);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataassemblyimport-enummanifestresources
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumManifestResources(out nint phEnum, ref uint rManifestResources, uint cMax, ref uint pcTokens);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataassemblyimport-getassemblyfromscope
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAssemblyFromScope(ref uint ptkAssembly);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataassemblyimport-findexportedtypebyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindExportedTypeByName(PWSTR szName, uint mdtExportedType, ref uint ptkExportedType);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataassemblyimport-findmanifestresourcebyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindManifestResourceByName(PWSTR szName, ref uint ptkManifestResource);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataassemblyimport-closeenum
    [PreserveSig]
    void CloseEnum(nint hEnum);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataassemblyimport-findassembliesbyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindAssembliesByName(PWSTR szAppBase, PWSTR szPrivateBin, PWSTR szAssemblyName, out nint ppIUnk, uint cMax, ref uint pcAssemblies);
}
