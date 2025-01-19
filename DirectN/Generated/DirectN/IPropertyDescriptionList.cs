#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/propsys/nn-propsys-ipropertydescriptionlist
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("1f9fc1d0-c39b-4b26-817f-011967d3440e")]
public partial interface IPropertyDescriptionList
{
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertydescriptionlist-getcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCount(out uint pcElem);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertydescriptionlist-getat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAt(uint iElem, in Guid riid, out nint /* void */ ppv);
}
