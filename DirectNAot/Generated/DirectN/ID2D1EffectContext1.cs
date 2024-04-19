namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1effectauthor_1/nn-d2d1effectauthor_1-id2d1effectcontext1
[GeneratedComInterface, Guid("84ab595a-fc81-4546-bacd-e8ef4d8abe7a")]
public partial interface ID2D1EffectContext1 : ID2D1EffectContext
{
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor_1/nf-d2d1effectauthor_1-id2d1effectcontext1-createlookuptable3d
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateLookupTable3D(D2D1_BUFFER_PRECISION precision, in uint extents, nint /* byte array */ data, uint dataCount, in uint strides, out ID2D1LookupTable3D lookupTable);
}
