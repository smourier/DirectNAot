#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/sbe/nn-sbe-istreambufferinitialize
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("9ce50f2d-6ba7-40fb-a034-50b1a674ec78")]
public partial interface IStreamBufferInitialize
{
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-istreambufferinitialize-sethkey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetHKEY(HKEY hkeyRoot);
    
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-istreambufferinitialize-setsids
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSIDs(uint cSIDs, ref PSID ppSID);
}
