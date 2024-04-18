namespace DirectN;

[GeneratedComInterface, Guid("b36d93e0-2b43-11cf-a2de-00aa00b93356")]
public partial interface IDirectDrawVideoPort
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Flip(IDirectDrawSurface param0, uint param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetBandwidthInfo(ref DDPIXELFORMAT param0, uint param1, uint param2, uint param3, ref DDVIDEOPORTBANDWIDTH param4);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetColorControls(ref DDCOLORCONTROL param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetInputFormats(ref uint lpNumFormats, nint/* nint */ param1, uint param2);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetOutputFormats(ref DDPIXELFORMAT param0, ref uint lpNumFormats, nint/* nint */ param2, uint param3);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFieldPolarity([MarshalAs(UnmanagedType.U4)] ref bool param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetVideoLine(ref uint param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetVideoSignalStatus(ref uint param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetColorControls(ref DDCOLORCONTROL param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetTargetSurface(IDirectDrawSurface param0, uint param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT StartVideo(ref DDVIDEOPORTINFO param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT StopVideo();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT UpdateVideo(ref DDVIDEOPORTINFO param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT WaitForSync(uint param0, uint param1, uint param2);
}
