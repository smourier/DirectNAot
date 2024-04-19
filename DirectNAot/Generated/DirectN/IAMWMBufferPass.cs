namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dshowasf/nn-dshowasf-iamwmbufferpass
[GeneratedComInterface, Guid("6dd816d7-e740-4123-9e24-2444412644d8")]
public partial interface IAMWMBufferPass
{
    // https://learn.microsoft.com/windows/win32/api/dshowasf/nf-dshowasf-iamwmbufferpass-setnotify
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetNotify(IAMWMBufferPassCallback pCallback);
}
