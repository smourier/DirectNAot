namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/nn-bdaiface-iccsubstreamfiltering
[GeneratedComInterface, Guid("4b2bd7ea-8347-467b-8dbf-62f784929cc3")]
public partial interface ICCSubStreamFiltering
{
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-iccsubstreamfiltering-get_substreamtypes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SubstreamTypes(out int pTypes);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-iccsubstreamfiltering-put_substreamtypes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SubstreamTypes(int Types);
}
