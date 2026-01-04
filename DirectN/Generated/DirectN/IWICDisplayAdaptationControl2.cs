#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("d7508d29-3ab7-447e-a676-4d80d7de726b")]
public partial interface IWICDisplayAdaptationControl2 : IWICDisplayAdaptationControl
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSdrWhiteLevel(float fWhiteLevelInNits);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSdrWhiteLevel(out float pfWhiteLevelInNits);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetToneMappingMode(WICBitmapToneMappingMode mode);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetToneMappingMode(out WICBitmapToneMappingMode mode);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DoesSupportToneMappingMode(WICBitmapToneMappingMode mode, out BOOL pfIsSupported);
}
