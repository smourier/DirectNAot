#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfqualityadvise
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("ec15e2e9-e36b-4f7c-8758-77d452ef4ce7")]
public partial interface IMFQualityAdvise
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfqualityadvise-setdropmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDropMode(MF_QUALITY_DROP_MODE eDropMode);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfqualityadvise-setqualitylevel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetQualityLevel(MF_QUALITY_LEVEL eQualityLevel);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfqualityadvise-getdropmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDropMode(out MF_QUALITY_DROP_MODE peDropMode);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfqualityadvise-getqualitylevel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetQualityLevel(out MF_QUALITY_LEVEL peQualityLevel);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfqualityadvise-droptime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DropTime(long hnsAmountToDrop);
}
