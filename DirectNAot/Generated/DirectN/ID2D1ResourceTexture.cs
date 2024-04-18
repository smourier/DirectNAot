namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nn-d2d1effectauthor-id2d1resourcetexture
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("688d15c3-02b0-438d-b13a-d1b44c32c39a")]
public partial interface ID2D1ResourceTexture
{
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1resourcetexture-update
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Update(nint/* nint */ minimumExtents, nint/* nint */ maximimumExtents, nint/* nint */ strides, uint dimensions, nint /* byte array */ data, uint dataCount);
}
