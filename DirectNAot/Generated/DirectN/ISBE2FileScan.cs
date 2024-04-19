namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/sbe/nn-sbe-isbe2filescan
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("3e2bf5a5-4f96-4899-a1a3-75e8be9a5ac0")]
public partial interface ISBE2FileScan
{
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-isbe2filescan-repairfile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RepairFile(PWSTR filename);
}
