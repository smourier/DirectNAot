namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfpresentationdescriptor
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("03cb2711-24d7-4db6-a17f-f3a7a479a536")]
public partial interface IMFPresentationDescriptor : IMFAttributes
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfpresentationdescriptor-getstreamdescriptorcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamDescriptorCount(out uint pdwDescriptorCount);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfpresentationdescriptor-getstreamdescriptorbyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamDescriptorByIndex(uint dwIndex, [MarshalAs(UnmanagedType.U4)] out bool pfSelected, out IMFStreamDescriptor ppDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfpresentationdescriptor-selectstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SelectStream(uint dwDescriptorIndex);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfpresentationdescriptor-deselectstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeselectStream(uint dwDescriptorIndex);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfpresentationdescriptor-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone(out IMFPresentationDescriptor ppPresentationDescriptor);
}
