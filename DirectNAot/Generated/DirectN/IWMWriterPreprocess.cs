namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmwriterpreprocess
[GeneratedComInterface, Guid("fc54a285-38c4-45b5-aa23-85b9f7cb424b")]
public partial interface IWMWriterPreprocess
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriterpreprocess-getmaxpreprocessingpasses
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMaxPreprocessingPasses(uint dwInputNum, uint dwFlags, out uint pdwMaxNumPasses);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriterpreprocess-setnumpreprocessingpasses
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetNumPreprocessingPasses(uint dwInputNum, uint dwFlags, uint dwNumPasses);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriterpreprocess-beginpreprocessingpass
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginPreprocessingPass(uint dwInputNum, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriterpreprocess-preprocesssample
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PreprocessSample(uint dwInputNum, ulong cnsSampleTime, uint dwFlags, INSSBuffer pSample);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriterpreprocess-endpreprocessingpass
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndPreprocessingPass(uint dwInputNum, uint dwFlags);
}
