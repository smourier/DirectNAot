#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmcontainer/nn-wmcontainer-imfasfstreamselector
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("d01bad4a-4fa0-4a60-9349-c27e62da9d41")]
public partial interface IMFASFStreamSelector
{
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfstreamselector-getstreamcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamCount(out uint pcStreams);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfstreamselector-getoutputcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputCount(out uint pcOutputs);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfstreamselector-getoutputstreamcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputStreamCount(uint dwOutputNum, out uint pcStreams);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfstreamselector-getoutputstreamnumbers
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputStreamNumbers(uint dwOutputNum, out ushort rgwStreamNumbers);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfstreamselector-getoutputfromstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputFromStream(ushort wStreamNum, out uint pdwOutput);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfstreamselector-getoutputoverride
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputOverride(uint dwOutputNum, out ASF_SELECTION_STATUS pSelection);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfstreamselector-setoutputoverride
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOutputOverride(uint dwOutputNum, ASF_SELECTION_STATUS Selection);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfstreamselector-getoutputmutexcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputMutexCount(uint dwOutputNum, out uint pcMutexes);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfstreamselector-getoutputmutex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputMutex(uint dwOutputNum, uint dwMutexNum, out nint ppMutex);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfstreamselector-setoutputmutexselection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOutputMutexSelection(uint dwOutputNum, uint dwMutexNum, ushort wSelectedRecord);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfstreamselector-getbandwidthstepcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBandwidthStepCount(out uint pcStepCount);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfstreamselector-getbandwidthstep
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBandwidthStep(uint dwStepNum, out uint pdwBitrate, out ushort rgwStreamNumbers, out ASF_SELECTION_STATUS rgSelections);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfstreamselector-bitratetostepnumber
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BitrateToStepNumber(uint dwBitrate, out uint pdwStepNum);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfstreamselector-setstreamselectorflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStreamSelectorFlags(uint dwStreamSelectorFlags);
}
