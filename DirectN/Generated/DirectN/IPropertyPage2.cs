#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/nn-ocidl-ipropertypage2
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("01e44665-24ac-101b-84ed-08002b2ec713")]
public partial interface IPropertyPage2 : IPropertyPage
{
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipropertypage2-editproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EditProperty(int dispID);
}
