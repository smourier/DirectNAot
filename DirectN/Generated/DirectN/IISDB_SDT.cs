#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvbsiparser/nn-dvbsiparser-iisdb_sdt
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("3f3dc9a2-bb32-4fb9-ae9e-d856848927a3")]
public partial interface IISDB_SDT : IDVB_SDT
{
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdb_sdt-getrecordeituserdefinedflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordEITUserDefinedFlags(uint dwRecordIndex, nint /* byte array */ pbVal);
}
