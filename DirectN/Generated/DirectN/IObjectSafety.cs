#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("cb5bdc81-93c1-11cf-8f20-00805f2cd064")]
public partial interface IObjectSafety
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInterfaceSafetyOptions(in Guid riid, out uint pdwSupportedOptions, out uint pdwEnabledOptions);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetInterfaceSafetyOptions(in Guid riid, uint dwOptionSetMask, uint dwEnabledOptions);
}
