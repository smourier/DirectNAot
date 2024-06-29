#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mpeg2psiparser/nn-mpeg2psiparser-ipsitables
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("919f24c5-7b14-42ac-a4b0-2ae08daf00ac")]
public partial interface IPSITables
{
    // https://learn.microsoft.com/windows/win32/api/mpeg2psiparser/nf-mpeg2psiparser-ipsitables-gettable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTable(uint dwTSID, uint dwTID_PID, uint dwHashedVer, uint dwPara4, out nint ppIUnknown);
}
