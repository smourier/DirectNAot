#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oaidl/nn-oaidl-isupporterrorinfo
[GeneratedComInterface, Guid("df0b3d60-548f-101b-8e65-08002b2bd119")]
public partial interface ISupportErrorInfo
{
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-isupporterrorinfo-interfacesupportserrorinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InterfaceSupportsErrorInfo(in Guid riid);
}
