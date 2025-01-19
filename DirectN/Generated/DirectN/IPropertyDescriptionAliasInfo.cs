#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/propsys/nn-propsys-ipropertydescriptionaliasinfo
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("f67104fc-2af9-46fd-b32d-243c1404f3d1")]
public partial interface IPropertyDescriptionAliasInfo : IPropertyDescription
{
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertydescriptionaliasinfo-getsortbyalias
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSortByAlias(in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertydescriptionaliasinfo-getadditionalsortbyaliases
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAdditionalSortByAliases(in Guid riid, out nint /* void */ ppv);
}
