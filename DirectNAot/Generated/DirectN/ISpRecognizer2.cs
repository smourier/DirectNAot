namespace DirectN;

[GeneratedComInterface, Guid("8fc6d974-c81e-4098-93c5-0147f61ed4d3")]
public partial interface ISpRecognizer2
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EmulateRecognitionEx(ISpPhrase pPhrase, uint dwCompareFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTrainingState([MarshalAs(UnmanagedType.U4)] bool fDoingTraining, [MarshalAs(UnmanagedType.U4)] bool fAdaptFromTrainingData);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResetAcousticModelAdaptation();
}
