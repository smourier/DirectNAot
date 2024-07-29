#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwminputmediaprops
[GeneratedComInterface, Guid("96406bd5-2b2b-11d3-b36b-00c04f6108ff")]
public partial interface IWMInputMediaProps : IWMMediaProps
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwminputmediaprops-getconnectionname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetConnectionName([MarshalUsing(CountElementName = nameof(pcchName))] out PWSTR pwszName, ref ushort pcchName);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwminputmediaprops-getgroupname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGroupName([MarshalUsing(CountElementName = nameof(pcchName))] out PWSTR pwszName, ref ushort pcchName);
}
