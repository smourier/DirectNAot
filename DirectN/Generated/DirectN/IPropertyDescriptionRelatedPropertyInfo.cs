#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/propsys/nn-propsys-ipropertydescriptionrelatedpropertyinfo
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("507393f4-2a3d-4a60-b59e-d9c75716c2dd")]
public partial interface IPropertyDescriptionRelatedPropertyInfo : IPropertyDescription
{
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertydescriptionrelatedpropertyinfo-getrelatedproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRelatedProperty(PWSTR pszRelationshipName, in Guid riid, out nint /* void */ ppv);
}
