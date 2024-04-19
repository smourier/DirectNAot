namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_2/nn-d2d1_2-id2d1devicecontext1
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("d37f57e4-6908-459f-a199-e72f24f79987")]
public partial interface ID2D1DeviceContext1 : ID2D1DeviceContext
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_2/nf-d2d1_2-id2d1devicecontext1-createfilledgeometryrealization
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFilledGeometryRealization(ID2D1Geometry geometry, float flatteningTolerance, out ID2D1GeometryRealization geometryRealization);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_2/nf-d2d1_2-id2d1devicecontext1-createstrokedgeometryrealization
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateStrokedGeometryRealization(ID2D1Geometry geometry, float flatteningTolerance, float strokeWidth, ID2D1StrokeStyle strokeStyle, out ID2D1GeometryRealization geometryRealization);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_2/nf-d2d1_2-id2d1devicecontext1-drawgeometryrealization
    [PreserveSig]
    void DrawGeometryRealization(ID2D1GeometryRealization geometryRealization, ID2D1Brush brush);
}
