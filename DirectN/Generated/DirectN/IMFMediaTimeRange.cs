#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/nn-mfmediaengine-imfmediatimerange
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("db71a2fc-078a-414e-9df9-8c2531b0aa6c")]
public partial interface IMFMediaTimeRange
{
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediatimerange-getlength
    [PreserveSig]
    uint GetLength();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediatimerange-getstart
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStart(uint index, out double pStart);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediatimerange-getend
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEnd(uint index, out double pEnd);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediatimerange-containstime
    [PreserveSig]
    BOOL ContainsTime(double time);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediatimerange-addrange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddRange(double startTime, double endTime);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediatimerange-clear
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clear();
}
