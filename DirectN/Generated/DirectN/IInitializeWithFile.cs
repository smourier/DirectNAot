#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/propsys/nn-propsys-iinitializewithfile
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("b7d14566-0509-4cce-a71f-0a554233bd9b")]
public partial interface IInitializeWithFile
{
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-iinitializewithfile-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(PWSTR pszFilePath, uint grfMode);
}
