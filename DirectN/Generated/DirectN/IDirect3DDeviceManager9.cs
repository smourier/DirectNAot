#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva2api/nn-dxva2api-idirect3ddevicemanager9
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("a0cade0f-06d5-4cf4-a1c7-f3cdd725aa75")]
public partial interface IDirect3DDeviceManager9
{
    // https://learn.microsoft.com/windows/win32/api/dxva2api/nf-dxva2api-idirect3ddevicemanager9-resetdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResetDevice([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DDevice9>))] IDirect3DDevice9 pDevice, uint resetToken);
    
    // https://learn.microsoft.com/windows/win32/api/dxva2api/nf-dxva2api-idirect3ddevicemanager9-opendevicehandle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenDeviceHandle(out HANDLE phDevice);
    
    // https://learn.microsoft.com/windows/win32/api/dxva2api/nf-dxva2api-idirect3ddevicemanager9-closedevicehandle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CloseDeviceHandle(HANDLE hDevice);
    
    // https://learn.microsoft.com/windows/win32/api/dxva2api/nf-dxva2api-idirect3ddevicemanager9-testdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TestDevice(HANDLE hDevice);
    
    // https://learn.microsoft.com/windows/win32/api/dxva2api/nf-dxva2api-idirect3ddevicemanager9-lockdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LockDevice(HANDLE hDevice, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DDevice9>))] out IDirect3DDevice9 ppDevice, BOOL fBlock);
    
    // https://learn.microsoft.com/windows/win32/api/dxva2api/nf-dxva2api-idirect3ddevicemanager9-unlockdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnlockDevice(HANDLE hDevice, BOOL fSaveState);
    
    // https://learn.microsoft.com/windows/win32/api/dxva2api/nf-dxva2api-idirect3ddevicemanager9-getvideoservice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVideoService(HANDLE hDevice, in Guid riid, out nint ppService);
}
