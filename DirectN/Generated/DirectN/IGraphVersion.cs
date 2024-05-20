#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-igraphversion
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("56a868ab-0ad4-11ce-b03a-0020af0ba770")]
public partial interface IGraphVersion
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-igraphversion-queryversion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryVersion(out int pVersion);
}
