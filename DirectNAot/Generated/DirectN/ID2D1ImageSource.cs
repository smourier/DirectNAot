namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_3/nn-d2d1_3-id2d1imagesource
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("c9b664e5-74a1-4378-9ac2-eefc37a3f4d8")]
public partial interface ID2D1ImageSource : ID2D1Image
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1imagesource-offerresources
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OfferResources();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1imagesource-tryreclaimresources
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TryReclaimResources([MarshalAs(UnmanagedType.U4)] out bool resourcesDiscarded);
}
