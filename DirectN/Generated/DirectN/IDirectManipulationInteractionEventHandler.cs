#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/directmanipulation/nn-directmanipulation-idirectmanipulationinteractioneventhandler
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("e43f45b8-42b4-403e-b1f2-273b8f510830")]
public partial interface IDirectManipulationInteractionEventHandler
{
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationinteractioneventhandler-oninteraction
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnInteraction(IDirectManipulationViewport2 viewport, DIRECTMANIPULATION_INTERACTION_TYPE interaction);
}
