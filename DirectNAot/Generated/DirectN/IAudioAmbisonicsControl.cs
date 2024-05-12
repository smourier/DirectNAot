#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("28724c91-df35-4856-9f76-d6a26413f3df")]
public partial interface IAudioAmbisonicsControl
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetData([In][MarshalUsing(CountElementName = nameof(cbAmbisonicsParams))] AMBISONICS_PARAMS[] pAmbisonicsParams, uint cbAmbisonicsParams);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetHeadTracking([MarshalAs(UnmanagedType.U4)] bool bEnableHeadTracking);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetHeadTracking([MarshalAs(UnmanagedType.U4)] out bool pbEnableHeadTracking);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRotation(float X, float Y, float Z, float W);
}
