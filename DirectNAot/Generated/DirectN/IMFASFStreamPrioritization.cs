namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmcontainer/nn-wmcontainer-imfasfstreamprioritization
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("699bdc27-bbaf-49ff-8e38-9c39c9b5e088")]
public partial interface IMFASFStreamPrioritization
{
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfstreamprioritization-getstreamcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamCount(out uint pdwStreamCount);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfstreamprioritization-getstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStream(uint dwStreamIndex, out ushort pwStreamNumber, out ushort pwStreamFlags);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfstreamprioritization-addstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddStream(ushort wStreamNumber, ushort wStreamFlags);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfstreamprioritization-removestream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveStream(uint dwStreamIndex);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfstreamprioritization-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone(out IMFASFStreamPrioritization ppIStreamPrioritization);
}
