namespace DirectN;

[SupportedOSPlatform("windows6.1")]
public static class ID2D1PathGeometryExtensions
{
    public static IComObject<ID2D1SimplifiedGeometrySink> Open(this IComObject<ID2D1PathGeometry> geometry) => Open<ID2D1SimplifiedGeometrySink>(geometry?.Object!);
    public static IComObject<T> Open<T>(this IComObject<ID2D1PathGeometry> geometry) where T : ID2D1SimplifiedGeometrySink => Open<T>(geometry?.Object!);
    public static IComObject<T> Open<T>(this ID2D1PathGeometry geometry) where T : ID2D1SimplifiedGeometrySink
    {
        ArgumentNullException.ThrowIfNull(geometry);
        geometry.Open(out var sink).ThrowOnError();
        return new ComObject<T>((T)sink);
    }

    public static void Stream(this IComObject<ID2D1PathGeometry> geometry, IComObject<ID2D1GeometrySink> geometrySink) => Stream(geometry?.Object!, geometrySink?.Object!);
    public static void Stream(this ID2D1PathGeometry geometry, ID2D1GeometrySink geometrySink)
    {
        ArgumentNullException.ThrowIfNull(geometry);
        ArgumentNullException.ThrowIfNull(geometrySink);
        geometry.Stream(geometrySink).ThrowOnError();
    }

    public static uint GetSegmentCount(this IComObject<ID2D1PathGeometry> geometry) => GetSegmentCount(geometry?.Object!);
    public static uint GetSegmentCount(this ID2D1PathGeometry geometry)
    {
        ArgumentNullException.ThrowIfNull(geometry);
        geometry.GetSegmentCount(out var count).ThrowOnError();
        return count;
    }

    public static uint GetFigureCount(this IComObject<ID2D1PathGeometry> geometry) => GetFigureCount(geometry?.Object!);
    public static uint GetFigureCount(this ID2D1PathGeometry geometry)
    {
        ArgumentNullException.ThrowIfNull(geometry);
        geometry.GetFigureCount(out var count).ThrowOnError();
        return count;
    }

    [SupportedOSPlatform("windows8.0")]
    public static D2D1_POINT_DESCRIPTION ComputePointAndSegmentAtLength(this IComObject<ID2D1PathGeometry1> geometry, float length, uint startSegment, float flatteningTolerance, D2D_MATRIX_3X2_F? worldTransform = null) => ComputePointAndSegmentAtLength(geometry?.Object!, length, startSegment, flatteningTolerance, worldTransform);

    [SupportedOSPlatform("windows8.0")]
    public static D2D1_POINT_DESCRIPTION ComputePointAndSegmentAtLength(this ID2D1PathGeometry1 geometry, float length, uint startSegment, float flatteningTolerance, D2D_MATRIX_3X2_F? worldTransform = null)
    {
        ArgumentNullException.ThrowIfNull(geometry);
        geometry.ComputePointAndSegmentAtLength(length, startSegment, worldTransform.CopyToPointer(), flatteningTolerance, out var desc).ThrowOnError();
        return desc;
    }
}
