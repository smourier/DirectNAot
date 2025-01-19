#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/propsys/nn-propsys-ipropertyenumtype2
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("9b6e051c-5ddd-4321-9070-fe2acb55e794")]
public partial interface IPropertyEnumType2 : IPropertyEnumType
{
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertyenumtype2-getimagereference
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetImageReference(out PWSTR ppszImageRes);
}
