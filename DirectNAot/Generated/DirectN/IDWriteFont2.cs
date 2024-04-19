namespace DirectN;

// https://learn.microsoft.com/windows/win32/DirectWrite/idwritefont2
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("29748ed6-8c9c-4a6a-be0b-d912e8538944")]
public partial interface IDWriteFont2 : IDWriteFont1
{
    // https://learn.microsoft.com/windows/win32/DirectWrite/idwritefont2-iscolorfont
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool IsColorFont();
}
