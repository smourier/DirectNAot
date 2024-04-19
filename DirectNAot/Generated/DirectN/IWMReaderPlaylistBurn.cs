namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmreaderplaylistburn
[GeneratedComInterface, Guid("f28c0300-9baa-4477-a846-1744d9cbf533")]
public partial interface IWMReaderPlaylistBurn
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderplaylistburn-initplaylistburn
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitPlaylistBurn(uint cFiles, in PWSTR ppwszFilenames, IWMStatusCallback pCallback, nint pvContext);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderplaylistburn-getinitresults
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInitResults(uint cFiles, out HRESULT phrStati);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderplaylistburn-cancel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Cancel();
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderplaylistburn-endplaylistburn
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndPlaylistBurn(HRESULT hrBurnResult);
}
