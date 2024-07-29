#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/directmanipulation/nn-directmanipulation-idirectmanipulationcompositor2
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("d38c7822-f1cb-43cb-b4b9-ac0c767a412e")]
public partial interface IDirectManipulationCompositor2 : IDirectManipulationCompositor
{
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationcompositor2-addcontentwithcrossprocesschaining
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddContentWithCrossProcessChaining(IDirectManipulationPrimaryContent content, nint device, nint parentVisual, nint childVisual);
}
