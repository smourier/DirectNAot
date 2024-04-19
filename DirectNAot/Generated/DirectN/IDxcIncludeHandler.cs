namespace DirectN;

[GeneratedComInterface, Guid("7f61fc7d-950d-467f-b3e3-3c02fb49187c")]
public partial interface IDxcIncludeHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LoadSource(PWSTR pFilename, out IDxcBlob ppIncludeSource);
}
