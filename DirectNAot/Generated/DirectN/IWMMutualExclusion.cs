#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmmutualexclusion
[GeneratedComInterface, Guid("96406bde-2b2b-11d3-b36b-00c04f6108ff")]
public partial interface IWMMutualExclusion : IWMStreamList
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmmutualexclusion-gettype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetType(out Guid pguidType);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmmutualexclusion-settype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetType(in Guid guidType);
}
