#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/sbe/nn-sbe-istreambuffersink2
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("db94a660-f4fb-4bfa-bcc6-fe159a4eea93")]
public partial interface IStreamBufferSink2 : IStreamBufferSink
{
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-istreambuffersink2-unlockprofile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnlockProfile();
}
