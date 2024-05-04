#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvbsiparser/nn-dvbsiparser-idvbsiparser2
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("0ac5525f-f816-42f4-93ba-4c0f32f46e54")]
public partial interface IDvbSiParser2 : IDvbSiParser
{
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbsiparser2-geteit2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEIT2(byte tableId, nint /* optional ushort* */ pwServiceId, nint /* optional byte* */ pbSegment, out IDVB_EIT2 ppEIT);
}
