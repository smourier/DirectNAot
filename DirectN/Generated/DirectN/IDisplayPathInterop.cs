#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("a6ba4205-e59e-4e71-b25b-4e436d21ee3d")]
public partial interface IDisplayPathInterop
{
    // https://learn.microsoft.com/windows/win32/api/windows.devices.display.core.interop/nf-windows-devices-display-core-interop-idisplaypathinterop-createsourcepresentationhandle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSourcePresentationHandle(out HANDLE pValue);
    
    // https://learn.microsoft.com/windows/win32/api/windows.devices.display.core.interop/nf-windows-devices-display-core-interop-idisplaypathinterop-getsourceid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSourceId(out uint pSourceId);
}
