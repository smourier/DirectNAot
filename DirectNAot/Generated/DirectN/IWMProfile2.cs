namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmprofile2
[GeneratedComInterface, Guid("07e72d33-d94e-4be7-8843-60ae5ff7e5f5")]
public partial interface IWMProfile2 : IWMProfile
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmprofile2-getprofileid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProfileID(out Guid pguidID);
}
