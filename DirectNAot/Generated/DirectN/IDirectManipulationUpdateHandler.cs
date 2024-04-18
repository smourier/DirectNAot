namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/directmanipulation/nn-directmanipulation-idirectmanipulationupdatehandler
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("790b6337-64f8-4ff5-a269-b32bc2af27a7")]
public partial interface IDirectManipulationUpdateHandler
{
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationupdatehandler-update
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Update();
}
