namespace DirectN;

[GeneratedComInterface, Guid("6c142760-a733-11ce-a521-0020af0be560")]
public partial interface IDDVideoPortContainer
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateVideoPort(uint param0, ref DDVIDEOPORTDESC param1, out IDirectDrawVideoPort param2, nint param3);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumVideoPorts(uint param0, ref DDVIDEOPORTCAPS param1, nint param2, LPDDENUMVIDEOCALLBACK param3);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVideoPortConnectInfo(uint param0, ref uint pcInfo, nint /* optional DDVIDEOPORTCONNECT */ param2);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryVideoPortStatus(uint param0, ref DDVIDEOPORTSTATUS param1);
}
