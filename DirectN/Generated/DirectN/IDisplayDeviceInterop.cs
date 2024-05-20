#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("64338358-366a-471b-bd56-dd8ef48e439b")]
public partial interface IDisplayDeviceInterop
{
    // https://learn.microsoft.com/windows/win32/api/windows.devices.display.core.interop/nf-windows-devices-display-core-interop-idisplaydeviceinterop-createsharedhandle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSharedHandle(IInspectable pObject, in SECURITY_ATTRIBUTES pSecurityAttributes, uint Access, HSTRING Name, out HANDLE pHandle);
    
    // https://learn.microsoft.com/windows/win32/api/windows.devices.display.core.interop/nf-windows-devices-display-core-interop-idisplaydeviceinterop-opensharedhandle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenSharedHandle(HANDLE NTHandle, Guid riid, out nint ppvObj);
}
