namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/directmanipulation/nn-directmanipulation-idirectmanipulationautoscrollbehavior
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("6d5954d4-2003-4356-9b31-d051c9ff0af7")]
public partial interface IDirectManipulationAutoScrollBehavior
{
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationautoscrollbehavior-setconfiguration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetConfiguration(DIRECTMANIPULATION_MOTION_TYPES motionTypes, DIRECTMANIPULATION_AUTOSCROLL_CONFIGURATION scrollMotion);
}
