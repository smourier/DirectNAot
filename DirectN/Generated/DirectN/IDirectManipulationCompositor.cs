#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/directmanipulation/nn-directmanipulation-idirectmanipulationcompositor
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("537a0825-0387-4efa-b62f-71eb1f085a7e")]
public partial interface IDirectManipulationCompositor
{
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationcompositor-addcontent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddContent(IDirectManipulationContent content, nint device, nint parentVisual, nint childVisual);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationcompositor-removecontent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveContent(IDirectManipulationContent content);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationcompositor-setupdatemanager
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetUpdateManager(IDirectManipulationUpdateManager updateManager);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationcompositor-flush
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Flush();
}
