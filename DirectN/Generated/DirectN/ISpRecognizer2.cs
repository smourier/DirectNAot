#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("8fc6d974-c81e-4098-93c5-0147f61ed4d3")]
public partial interface ISpRecognizer2
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EmulateRecognitionEx(ISpPhrase pPhrase, uint dwCompareFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTrainingState(BOOL fDoingTraining, BOOL fAdaptFromTrainingData);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResetAcousticModelAdaptation();
}
