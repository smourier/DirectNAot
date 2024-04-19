namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12sdkconfiguration
[GeneratedComInterface, Guid("e9eb5314-33aa-42b2-a718-d77f58b1f1c7")]
public partial interface ID3D12SDKConfiguration
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12sdkconfiguration-setsdkversion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSDKVersion(uint SDKVersion, PSTR SDKPath);
}
