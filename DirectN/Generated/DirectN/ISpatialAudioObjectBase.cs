#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/spatialaudioclient/nn-spatialaudioclient-ispatialaudioobjectbase
[SupportedOSPlatform("windows10.0.15063")]
[GeneratedComInterface, Guid("cce0b8f2-8d4d-4efb-a8cf-3d6ecf1c30e0")]
public partial interface ISpatialAudioObjectBase
{
    // https://learn.microsoft.com/windows/win32/api/spatialaudioclient/nf-spatialaudioclient-ispatialaudioobjectbase-getbuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBuffer(out nint /* byte array */ buffer, out uint bufferLength);
    
    // https://learn.microsoft.com/windows/win32/api/spatialaudioclient/nf-spatialaudioclient-ispatialaudioobjectbase-setendofstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEndOfStream(uint frameCount);
    
    // https://learn.microsoft.com/windows/win32/api/spatialaudioclient/nf-spatialaudioclient-ispatialaudioobjectbase-isactive
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsActive([MarshalAs(UnmanagedType.U4)] out bool isActive);
    
    // https://learn.microsoft.com/windows/win32/api/spatialaudioclient/nf-spatialaudioclient-ispatialaudioobjectbase-getaudioobjecttype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAudioObjectType(out AudioObjectType audioObjectType);
}
