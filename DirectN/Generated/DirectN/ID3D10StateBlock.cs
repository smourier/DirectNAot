#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10effect/nn-d3d10effect-id3d10stateblock
[GeneratedComInterface, Guid("0803425a-57f5-4dd6-9465-a87570834a08")]
public partial interface ID3D10StateBlock
{
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10stateblock-capture
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Capture();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10stateblock-apply
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Apply();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10stateblock-releasealldeviceobjects
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReleaseAllDeviceObjects();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10stateblock-getdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDevice([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D10Device>))] out ID3D10Device ppDevice);
}
