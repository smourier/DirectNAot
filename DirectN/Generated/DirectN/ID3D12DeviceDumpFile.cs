#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("db82bfed-784d-40ea-aebf-08bcd7f0a9e4")]
public partial interface ID3D12DeviceDumpFile
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ConfigureDumpFile(D3D12_DUMP_FILE_DRIVER_OPTIONS driverOptions);
    
    [PreserveSig]
    void SetDumpFileCallbacks(D3D12_DUMPFILEBEGINCALLBACK pBeginCallback, D3D12_DUMPFILEENDCALLBACK pEndCallback);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddBlobToDumpFile(nint pBlob, uint sizeBytes, ulong metadata);
    
    [PreserveSig]
    void RetainDumpFile(BOOL retain);
    
    [PreserveSig]
    D3D12_DEVICE_ERROR_CODE GetDeviceErrorCode();
}
