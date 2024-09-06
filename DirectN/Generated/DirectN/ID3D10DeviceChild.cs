#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/nn-d3d10-id3d10devicechild
[GeneratedComInterface, Guid("9b7e4c00-342c-4106-a19f-4f2704f689f0")]
public partial interface ID3D10DeviceChild
{
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10devicechild-getdevice
    [PreserveSig]
    void GetDevice([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D10Device>))] out ID3D10Device ppDevice);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10devicechild-getprivatedata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPrivateData(in Guid guid, ref uint pDataSize, nint /* optional void* */ pData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10devicechild-setprivatedata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPrivateData(in Guid guid, uint DataSize, nint /* optional void* */ pData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10devicechild-setprivatedatainterface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPrivateDataInterface(in Guid guid, nint pData);
}
