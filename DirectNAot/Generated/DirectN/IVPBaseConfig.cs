#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vpconfig/nn-vpconfig-ivpbaseconfig
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00000000-0000-0000-0000-000000000000")]
public partial interface IVPBaseConfig
{
    // https://learn.microsoft.com/windows/win32/api/vpconfig/nf-vpconfig-ivpbaseconfig-getconnectinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetConnectInfo(ref uint pdwNumConnectInfo, nint /* optional DDVIDEOPORTCONNECT* */ pddVPConnectInfo);
    
    // https://learn.microsoft.com/windows/win32/api/vpconfig/nf-vpconfig-ivpbaseconfig-setconnectinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetConnectInfo(uint dwChosenEntry);
    
    // https://learn.microsoft.com/windows/win32/api/vpconfig/nf-vpconfig-ivpbaseconfig-getvpdatainfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVPDataInfo(ref AMVPDATAINFO pamvpDataInfo);
    
    // https://learn.microsoft.com/windows/win32/api/vpconfig/nf-vpconfig-ivpbaseconfig-getmaxpixelrate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMaxPixelRate(ref AMVPSIZE pamvpSize, ref uint pdwMaxPixelsPerSecond);
    
    // https://learn.microsoft.com/windows/win32/api/vpconfig/nf-vpconfig-ivpbaseconfig-informvpinputformats
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InformVPInputFormats(uint dwNumFormats, ref DDPIXELFORMAT pDDPixelFormats);
    
    // https://learn.microsoft.com/windows/win32/api/vpconfig/nf-vpconfig-ivpbaseconfig-getvideoformats
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVideoFormats(ref uint pdwNumFormats, nint /* optional DDPIXELFORMAT* */ pddPixelFormats);
    
    // https://learn.microsoft.com/windows/win32/api/vpconfig/nf-vpconfig-ivpbaseconfig-setvideoformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetVideoFormat(uint dwChosenEntry);
    
    // https://learn.microsoft.com/windows/win32/api/vpconfig/nf-vpconfig-ivpbaseconfig-setinvertpolarity
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetInvertPolarity();
    
    // https://learn.microsoft.com/windows/win32/api/vpconfig/nf-vpconfig-ivpbaseconfig-getoverlaysurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOverlaySurface(out IDirectDrawSurface ppddOverlaySurface);
    
    // https://learn.microsoft.com/windows/win32/api/vpconfig/nf-vpconfig-ivpbaseconfig-setdirectdrawkernelhandle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDirectDrawKernelHandle(nuint dwDDKernelHandle);
    
    // https://learn.microsoft.com/windows/win32/api/vpconfig/nf-vpconfig-ivpbaseconfig-setvideoportid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetVideoPortID(uint dwVideoPortID);
    
    // https://learn.microsoft.com/windows/win32/api/vpconfig/nf-vpconfig-ivpbaseconfig-setddsurfacekernelhandles
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDDSurfaceKernelHandles(uint cHandles, ref nuint rgDDKernelHandles);
    
    // https://learn.microsoft.com/windows/win32/api/vpconfig/nf-vpconfig-ivpbaseconfig-setsurfaceparameters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSurfaceParameters(uint dwPitch, uint dwXOrigin, uint dwYOrigin);
}
