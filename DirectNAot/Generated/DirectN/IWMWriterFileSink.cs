namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmwriterfilesink
[GeneratedComInterface, Guid("96406be5-2b2b-11d3-b36b-00c04f6108ff")]
public partial interface IWMWriterFileSink : IWMWriterSink
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriterfilesink-open
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Open(PWSTR pwszFilename);
}
