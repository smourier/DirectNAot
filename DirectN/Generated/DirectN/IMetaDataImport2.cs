#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/rometadataapi/nn-rometadataapi-imetadataimport2
[GeneratedComInterface, Guid("fce5efa0-8bba-4f8e-a036-8f2022b08466")]
public partial interface IMetaDataImport2 : IMetaDataImport
{
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport2-enumgenericparams
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumGenericParams(out nint phEnum, uint tk, ref uint rGenericParams, uint cMax, ref uint pcGenericParams);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport2-getgenericparamprops
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGenericParamProps(uint gp, ref uint pulParamSeq, ref uint pdwParamFlags, ref uint ptOwner, ref uint reserved, [MarshalUsing(CountElementName = nameof(cchName))] PWSTR wzname, uint cchName, ref uint pchName);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport2-getmethodspecprops
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMethodSpecProps(uint mi, ref uint tkParent, out nint /* byte array */ ppvSigBlob, ref uint pcbSigBlob);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport2-enumgenericparamconstraints
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumGenericParamConstraints(out nint phEnum, uint tk, ref uint rGenericParamConstraints, uint cMax, ref uint pcGenericParamConstraints);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport2-getgenericparamconstraintprops
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGenericParamConstraintProps(uint gpc, ref uint ptGenericParam, ref uint ptkConstraintType);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport2-getpekind
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPEKind(ref uint pdwPEKind, ref uint pdwMAchine);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport2-getversionstring
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVersionString([MarshalUsing(CountElementName = nameof(ccBufSize))] PWSTR pwzBuf, uint ccBufSize, ref uint pccBufSize);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport2-enummethodspecs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumMethodSpecs(out nint phEnum, uint tk, ref uint rMethodSpecs, uint cMax, ref uint pcMethodSpecs);
}
