namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmoutputmediaprops
[GeneratedComInterface, Guid("96406bd7-2b2b-11d3-b36b-00c04f6108ff")]
public partial interface IWMOutputMediaProps : IWMMediaProps
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmoutputmediaprops-getstreamgroupname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamGroupName(out PWSTR pwszName, ref ushort pcchName);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmoutputmediaprops-getconnectionname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetConnectionName(out PWSTR pwszName, ref ushort pcchName);
}
