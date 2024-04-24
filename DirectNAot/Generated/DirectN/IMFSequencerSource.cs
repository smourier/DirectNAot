namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfsequencersource
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("197cd219-19cb-4de1-a64c-acf2edcbe59e")]
public partial interface IMFSequencerSource
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsequencersource-appendtopology
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AppendTopology(IMFTopology pTopology, uint dwFlags, out uint pdwId);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsequencersource-deletetopology
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteTopology(uint dwId);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsequencersource-getpresentationcontext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPresentationContext(IMFPresentationDescriptor pPD, nint /* optional uint* */ pId, nint /* optional IMFTopology* */ ppTopology);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsequencersource-updatetopology
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateTopology(uint dwId, IMFTopology pTopology);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsequencersource-updatetopologyflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateTopologyFlags(uint dwId, uint dwFlags);
}
