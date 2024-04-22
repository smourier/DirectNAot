namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsprint/nn-xpsprint-ixpsprintjobstream
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("7a77dc5f-45d6-4dff-9307-d8cb846347ca")]
public partial interface IXpsPrintJobStream : ISequentialStream
{
    // https://learn.microsoft.com/windows/win32/api/xpsprint/nf-xpsprint-ixpsprintjobstream-close
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Close();
}
