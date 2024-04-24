namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/nn-d2d1-id2d1geometrygroup
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("2cd906a6-12e2-11dc-9fed-001143a055f9")]
public partial interface ID2D1GeometryGroup : ID2D1Geometry
{
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1geometrygroup-getfillmode
    [PreserveSig]
    D2D1_FILL_MODE GetFillMode();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1geometrygroup-getsourcegeometrycount
    [PreserveSig]
    uint GetSourceGeometryCount();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1geometrygroup-getsourcegeometries
    [PreserveSig]
    void GetSourceGeometries([MarshalUsing(CountElementName = nameof(geometriesCount))] out ID2D1Geometry[] geometries, uint geometriesCount);
}
