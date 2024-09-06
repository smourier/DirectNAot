#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-idvrgb219
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("58473a19-2bc8-4663-8012-25f81babddd1")]
public partial interface IDVRGB219
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvrgb219-setrgb219
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRGB219(BOOL bState);
}
