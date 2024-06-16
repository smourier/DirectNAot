#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("1491087d-2c6b-44c8-b019-b3c929d2ada9")]
public partial interface IWMPNodeRealEstateHost
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnDesiredSizeChange(ref SIZE pSize);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnFullScreenTransition(BOOL fFullScreen);
}
