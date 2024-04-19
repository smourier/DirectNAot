namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/nn-d2d1-id2d1resource
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("2cd90691-12e2-11dc-9fed-001143a055f9")]
public partial interface ID2D1Resource
{
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1resource-getfactory
    [PreserveSig]
    void GetFactory(out ID2D1Factory factory);
}
