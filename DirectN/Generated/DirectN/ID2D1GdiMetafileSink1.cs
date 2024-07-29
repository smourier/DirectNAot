#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_3/nn-d2d1_3-id2d1gdimetafilesink1
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("fd0ecb6b-91e6-411e-8655-395e760f91b4")]
public partial interface ID2D1GdiMetafileSink1 : ID2D1GdiMetafileSink
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1gdimetafilesink1-processrecord
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ProcessRecord(uint recordType, nint /* optional void* */ recordData, uint recordDataSize, uint flags);
}
