#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfcontentprotectiondevice
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("e6257174-a060-4c9a-a088-3b1b471cad28")]
public partial interface IMFContentProtectionDevice
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfcontentprotectiondevice-invokefunction
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InvokeFunction(uint FunctionId, uint InputBufferByteCount, nint /* byte array */ InputBuffer, ref uint OutputBufferByteCount, nint /* byte array */ OutputBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfcontentprotectiondevice-getprivatedatabytecount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPrivateDataByteCount(out uint PrivateInputByteCount, out uint PrivateOutputByteCount);
}
