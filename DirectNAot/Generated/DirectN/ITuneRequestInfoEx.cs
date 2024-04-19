namespace DirectN;

[GeneratedComInterface, Guid("ee957c52-b0d0-4e78-8dd1-b87a08bfd893")]
public partial interface ITuneRequestInfoEx : ITuneRequestInfo
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateComponentListEx(ITuneRequest CurrentRequest, out nint ppCurPMT);
}
