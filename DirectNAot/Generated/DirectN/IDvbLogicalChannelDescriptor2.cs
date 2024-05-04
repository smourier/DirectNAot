#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvbsiparser/nn-dvbsiparser-idvblogicalchanneldescriptor2
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("43aca974-4be8-4b98-bc17-9eafd788b1d7")]
public partial interface IDvbLogicalChannelDescriptor2 : IDvbLogicalChannelDescriptor
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordLogicalChannelAndVisibility(byte bRecordIndex, out ushort pwVal);
}
