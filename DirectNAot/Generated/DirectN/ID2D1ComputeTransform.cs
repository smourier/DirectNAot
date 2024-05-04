namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nn-d2d1effectauthor-id2d1computetransform
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("0d85573c-01e3-4f7d-bfd9-0d60608bf3c3")]
public partial interface ID2D1ComputeTransform : ID2D1Transform
{
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1computetransform-setcomputeinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetComputeInfo(ID2D1ComputeInfo computeInfo);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1computetransform-calculatethreadgroups
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CalculateThreadgroups(in RECT outputRect, out uint dimensionX, out uint dimensionY, out uint dimensionZ);
}
