#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("de9d91d2-70b4-4f41-836c-25fcd39626d3")]
public partial interface IWICDisplayAdaptationControl
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DoesSupportChangingMaxLuminance(in Guid pguidDstFormat, out BOOL pfIsSupported);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDisplayMaxLuminance(float fLuminanceInNits);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDisplayMaxLuminance(out float pfLuminanceInNits);
}
