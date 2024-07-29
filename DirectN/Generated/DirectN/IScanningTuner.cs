#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-iscanningtuner
[GeneratedComInterface, Guid("1dfd0a5c-0284-11d3-9d8e-00c04f72d980")]
public partial interface IScanningTuner : ITuner
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iscanningtuner-seekup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SeekUp();
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iscanningtuner-seekdown
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SeekDown();
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iscanningtuner-scanup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ScanUp(int MillisecondsPause);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iscanningtuner-scandown
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ScanDown(int MillisecondsPause);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iscanningtuner-autoprogram
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AutoProgram();
}
