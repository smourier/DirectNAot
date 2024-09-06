#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/devicetopology/nn-devicetopology-iksjacksinkinformation
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("d9bd72ed-290f-4581-9ff3-61027a8fe532")]
public partial interface IKsJackSinkInformation
{
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-iksjacksinkinformation-getjacksinkinformation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetJackSinkInformation(out KSJACK_SINK_INFORMATION pJackSinkInformation);
}
