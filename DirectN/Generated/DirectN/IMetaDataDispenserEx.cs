#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/rometadataapi/nn-rometadataapi-imetadatadispenserex
[GeneratedComInterface, Guid("31bcfce2-dafb-11d2-9f81-00c04f79a0a3")]
public partial interface IMetaDataDispenserEx : IMetaDataDispenser
{
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadatadispenserex-setoption
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOption(in Guid optionid, in VARIANT value);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadatadispenserex-getoption
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOption(in Guid optionid, ref VARIANT pvalue);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadatadispenserex-openscopeonitypeinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenScopeOnITypeInfo([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITypeInfo>))] ITypeInfo pITI, uint dwOpenFlags, in Guid riid, out nint ppIUnk);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadatadispenserex-getcorsystemdirectory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCORSystemDirectory([MarshalUsing(CountElementName = nameof(cchBuffer))] PWSTR szBuffer, uint cchBuffer, ref uint pchBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadatadispenserex-findassembly
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindAssembly(PWSTR szAppBase, PWSTR szPrivateBin, PWSTR szGlobalBin, PWSTR szAssemblyName, PWSTR szName, uint cchName, ref uint pcName);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadatadispenserex-findassemblymodule
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindAssemblyModule(PWSTR szAppBase, PWSTR szPrivateBin, PWSTR szGlobalBin, PWSTR szAssemblyName, PWSTR szModuleName, [MarshalUsing(CountElementName = nameof(cchName))] PWSTR szName, uint cchName, ref uint pcName);
}
