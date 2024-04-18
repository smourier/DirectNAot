namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_3/nn-d2d1_3-id2d1transformedimagesource
[GeneratedComInterface, Guid("7f1f79e5-2796-416c-8f55-700f911445e5")]
public partial interface ID2D1TransformedImageSource : ID2D1Image
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1transformedimagesource-getsource
    [PreserveSig]
    public void GetSource(out ID2D1ImageSource imageSource);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1transformedimagesource-getproperties
    [PreserveSig]
    public void GetProperties(out D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES properties);
}
