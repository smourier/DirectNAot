#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/directmanipulation/nn-directmanipulation-idirectmanipulationviewport2
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("923ccaac-61e1-4385-b726-017af189882a")]
public partial interface IDirectManipulationViewport2 : IDirectManipulationViewport
{
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationviewport2-addbehavior
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddBehavior(nint behavior, out uint cookie);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationviewport2-removebehavior
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveBehavior(uint cookie);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationviewport2-removeallbehaviors
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveAllBehaviors();
}
