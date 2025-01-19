#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/propsys/nn-propsys-ipropertydescription2
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("57d2eded-5062-400e-b107-5dae79fe57a6")]
public partial interface IPropertyDescription2 : IPropertyDescription
{
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertydescription2-getimagereferenceforvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetImageReferenceForValue(in PROPVARIANT propvar, out PWSTR ppszImageRes);
}
