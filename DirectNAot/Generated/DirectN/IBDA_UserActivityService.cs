#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/nn-bdaiface-ibda_useractivityservice
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("53b14189-e478-4b7a-a1ff-506db4b99dfe")]
public partial interface IBDA_UserActivityService
{
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_useractivityservice-setcurrenttunerusereason
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCurrentTunerUseReason(uint dwUseReason);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_useractivityservice-getuseractivityinterval
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUserActivityInterval(out uint pdwActivityInterval);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_useractivityservice-useractivitydetected
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UserActivityDetected();
}
