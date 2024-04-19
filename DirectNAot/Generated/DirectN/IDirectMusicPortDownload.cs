namespace DirectN;

[GeneratedComInterface, Guid("d2ac287a-b39b-11d1-8704-00600893b1bd")]
public partial interface IDirectMusicPortDownload
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBuffer(uint dwDLId, out IDirectMusicDownload ppIDMDownload);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AllocateBuffer(uint dwSize, out IDirectMusicDownload ppIDMDownload);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDLId(ref uint pdwStartDLId, uint dwCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAppend(ref uint pdwAppend);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Download(IDirectMusicDownload pIDMDownload);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Unload(IDirectMusicDownload pIDMDownload);
}
