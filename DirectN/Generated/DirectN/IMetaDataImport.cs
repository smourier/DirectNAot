#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/rometadataapi/nn-rometadataapi-imetadataimport
[GeneratedComInterface, Guid("7dac8207-d3ae-4c75-9b67-92801a497d44")]
public partial interface IMetaDataImport
{
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-closeenum
    [PreserveSig]
    void CloseEnum(nint hEnum);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-countenum
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CountEnum(nint hEnum, ref uint pulCount);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-resetenum
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResetEnum(nint hEnum, uint ulPos);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-enumtypedefs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumTypeDefs(out nint phEnum, ref uint rTypeDefs, uint cMax, ref uint pcTypeDefs);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-enuminterfaceimpls
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumInterfaceImpls(out nint phEnum, uint td, ref uint rImpls, uint cMax, ref uint pcImpls);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-enumtyperefs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumTypeRefs(out nint phEnum, ref uint rTypeRefs, uint cMax, ref uint pcTypeRefs);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-findtypedefbyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindTypeDefByName(PWSTR szTypeDef, uint tkEnclosingClass, ref uint ptd);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-getscopeprops
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetScopeProps([MarshalUsing(CountElementName = nameof(cchName))] PWSTR szName, uint cchName, ref uint pchName, ref Guid pmvid);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-getmodulefromscope
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetModuleFromScope(ref uint pmd);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-gettypedefprops
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTypeDefProps(uint td, [MarshalUsing(CountElementName = nameof(cchTypeDef))] PWSTR szTypeDef, uint cchTypeDef, ref uint pchTypeDef, ref uint pdwTypeDefFlags, ref uint ptkExtends);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-getinterfaceimplprops
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInterfaceImplProps(uint iiImpl, ref uint pClass, ref uint ptkIface);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-gettyperefprops
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTypeRefProps(uint tr, ref uint ptkResolutionScope, [MarshalUsing(CountElementName = nameof(cchName))] PWSTR szName, uint cchName, ref uint pchName);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-resolvetyperef
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResolveTypeRef(uint tr, in Guid riid, out nint ppIScope, ref uint ptd);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-enummembers
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumMembers(out nint phEnum, uint cl, ref uint rMembers, uint cMax, ref uint pcTokens);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-enummemberswithname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumMembersWithName(out nint phEnum, uint cl, PWSTR szName, ref uint rMembers, uint cMax, ref uint pcTokens);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-enummethods
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumMethods(out nint phEnum, uint cl, ref uint rMethods, uint cMax, ref uint pcTokens);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-enummethodswithname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumMethodsWithName(out nint phEnum, uint cl, PWSTR szName, ref uint rMethods, uint cMax, ref uint pcTokens);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-enumfields
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumFields(out nint phEnum, uint cl, ref uint rFields, uint cMax, ref uint pcTokens);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-enumfieldswithname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumFieldsWithName(out nint phEnum, uint cl, PWSTR szName, ref uint rFields, uint cMax, ref uint pcTokens);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-enumparams
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumParams(out nint phEnum, uint mb, ref uint rParams, uint cMax, ref uint pcTokens);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-enummemberrefs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumMemberRefs(out nint phEnum, uint tkParent, ref uint rMemberRefs, uint cMax, ref uint pcTokens);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-enummethodimpls
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumMethodImpls(out nint phEnum, uint td, ref uint rMethodBody, ref uint rMethodDecl, uint cMax, ref uint pcTokens);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-enumpermissionsets
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumPermissionSets(out nint phEnum, uint tk, uint dwActions, ref uint rPermission, uint cMax, ref uint pcTokens);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindMember(uint td, PWSTR szName, nint /* byte array */ pvSigBlob, uint cbSigBlob, ref uint pmb);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindMethod(uint td, PWSTR szName, nint /* byte array */ pvSigBlob, uint cbSigBlob, ref uint pmb);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindField(uint td, PWSTR szName, nint /* byte array */ pvSigBlob, uint cbSigBlob, ref uint pmb);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-findmemberref
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindMemberRef(uint td, PWSTR szName, nint /* byte array */ pvSigBlob, uint cbSigBlob, ref uint pmr);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-getmethodprops
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMethodProps(uint mb, ref uint pClass, [MarshalUsing(CountElementName = nameof(cchMethod))] PWSTR szMethod, uint cchMethod, ref uint pchMethod, ref uint pdwAttr, out nint /* byte array */ ppvSigBlob, ref uint pcbSigBlob, ref uint pulCodeRVA, ref uint pdwImplFlags);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-getmemberrefprops
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMemberRefProps(uint mr, ref uint ptk, [MarshalUsing(CountElementName = nameof(cchMember))] PWSTR szMember, uint cchMember, ref uint pchMember, out nint /* byte array */ ppvSigBlob, ref uint pbSig);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-enumproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumProperties(out nint phEnum, uint td, ref uint rProperties, uint cMax, ref uint pcProperties);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-enumevents
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumEvents(out nint phEnum, uint td, ref uint rEvents, uint cMax, ref uint pcEvents);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEventProps(uint ev, ref uint pClass, PWSTR szEvent, uint cchEvent, ref uint pchEvent, ref uint pdwEventFlags, ref uint ptkEventType, ref uint pmdAddOn, ref uint pmdRemoveOn, ref uint pmdFire, ref uint rmdOtherMethod, uint cMax, ref uint pcOtherMethod);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-enummethodsemantics
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumMethodSemantics(out nint phEnum, uint mb, ref uint rEventProp, uint cMax, ref uint pcEventProp);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-getmethodsemantics
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMethodSemantics(uint mb, uint tkEventProp, ref uint pdwSemanticsFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetClassLayout(uint td, ref uint pdwPackSize, ref COR_FIELD_OFFSET rFieldOffset, uint cMax, ref uint pcFieldOffset, ref uint pulClassSize);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-getfieldmarshal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFieldMarshal(uint tk, out nint /* byte array */ ppvNativeType, ref uint pcbNativeType);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-getrva
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRVA(uint tk, ref uint pulCodeRVA, ref uint pdwImplFlags);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-getpermissionsetprops
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPermissionSetProps(uint pm, ref uint pdwAction, out nint ppvPermission, ref uint pcbPermission);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-getsigfromtoken
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSigFromToken(uint mdSig, out nint /* byte array */ ppvSig, ref uint pcbSig);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-getmodulerefprops
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetModuleRefProps(uint mur, [MarshalUsing(CountElementName = nameof(cchName))] PWSTR szName, uint cchName, ref uint pchName);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-enummodulerefs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumModuleRefs(out nint phEnum, ref uint rModuleRefs, uint cmax, ref uint pcModuleRefs);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-gettypespecfromtoken
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTypeSpecFromToken(uint typespec, out nint /* byte array */ ppvSig, ref uint pcbSig);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-getnamefromtoken
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNameFromToken(uint tk, ref sbyte pszUtf8NamePtr);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-enumunresolvedmethods
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumUnresolvedMethods(out nint phEnum, ref uint rMethods, uint cMax, ref uint pcTokens);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-getuserstring
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUserString(uint stk, [MarshalUsing(CountElementName = nameof(cchString))] PWSTR szString, uint cchString, ref uint pchString);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-getpinvokemap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPinvokeMap(uint tk, ref uint pdwMappingFlags, [MarshalUsing(CountElementName = nameof(cchImportName))] PWSTR szImportName, uint cchImportName, ref uint pchImportName, ref uint pmrImportDLL);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-enumsignatures
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumSignatures(out nint phEnum, ref uint rSignatures, uint cmax, ref uint pcSignatures);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-enumtypespecs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumTypeSpecs(out nint phEnum, ref uint rTypeSpecs, uint cmax, ref uint pcTypeSpecs);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-enumuserstrings
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumUserStrings(out nint phEnum, ref uint rStrings, uint cmax, ref uint pcStrings);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-getparamformethodindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetParamForMethodIndex(uint md, uint ulParamSeq, ref uint ppd);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-enumcustomattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumCustomAttributes(out nint phEnum, uint tk, uint tkType, ref uint rCustomAttributes, uint cMax, ref uint pcCustomAttributes);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-getcustomattributeprops
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCustomAttributeProps(uint cv, ref uint ptkObj, ref uint ptkType, out nint ppBlob, ref uint pcbSize);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-findtyperef
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindTypeRef(uint tkResolutionScope, PWSTR szName, ref uint ptr);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-getmemberprops
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMemberProps(uint mb, ref uint pClass, [MarshalUsing(CountElementName = nameof(cchMember))] PWSTR szMember, uint cchMember, ref uint pchMember, ref uint pdwAttr, out nint /* byte array */ ppvSigBlob, ref uint pcbSigBlob, ref uint pulCodeRVA, ref uint pdwImplFlags, ref uint pdwCPlusTypeFlag, out nint ppValue, ref uint pcchValue);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-getfieldprops
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFieldProps(uint mb, ref uint pClass, [MarshalUsing(CountElementName = nameof(cchField))] PWSTR szField, uint cchField, ref uint pchField, ref uint pdwAttr, out nint /* byte array */ ppvSigBlob, ref uint pcbSigBlob, ref uint pdwCPlusTypeFlag, out nint ppValue, ref uint pcchValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyProps(uint prop, ref uint pClass, PWSTR szProperty, uint cchProperty, ref uint pchProperty, ref uint pdwPropFlags, out nint /* byte array */ ppvSig, ref uint pbSig, ref uint pdwCPlusTypeFlag, out nint ppDefaultValue, ref uint pcchDefaultValue, ref uint pmdSetter, ref uint pmdGetter, ref uint rmdOtherMethod, uint cMax, ref uint pcOtherMethod);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-getparamprops
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetParamProps(uint tk, ref uint pmd, ref uint pulSequence, [MarshalUsing(CountElementName = nameof(cchName))] PWSTR szName, uint cchName, ref uint pchName, ref uint pdwAttr, ref uint pdwCPlusTypeFlag, out nint ppValue, ref uint pcchValue);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-getcustomattributebyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCustomAttributeByName(uint tkObj, PWSTR szName, out nint ppData, ref uint pcbData);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-isvalidtoken
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    BOOL IsValidToken(uint tk);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-getnestedclassprops
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNestedClassProps(uint tdNestedClass, ref uint ptdEnclosingClass);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-getnativecallconvfromsig
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNativeCallConvFromSig(nint pvSig, uint cbSig, ref uint pCallConv);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadataimport-isglobal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsGlobal(uint pd, ref int pbGlobal);
}
