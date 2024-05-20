namespace DirectN;

[SupportedOSPlatform("windows6.1")]
public static class ID2D1GeometryExtensions
{
    public static D2D_RECT_F GetBounds(this IComObject<ID2D1Geometry> geometry) => GetBounds(geometry?.Object!);
    public static D2D_RECT_F GetBounds(this ID2D1Geometry geometry, D2D_MATRIX_3X2_F? worldTransform = null)
    {
        ArgumentNullException.ThrowIfNull(geometry);
        geometry.GetBounds(worldTransform.CopyToPointer(), out var bounds).ThrowOnError();
        return bounds;
    }

    public static D2D_RECT_F GetWidenedBounds(this IComObject<ID2D1Geometry> geometry, float strokeWidth = 1, IComObject<ID2D1StrokeStyle>? strokeStyle = null, D2D_MATRIX_3X2_F? worldTransform = null, float flatteningTolerance = Constants.D2D1_DEFAULT_FLATTENING_TOLERANCE) => GetWidenedBounds(geometry?.Object!, strokeWidth, strokeStyle?.Object!, worldTransform, flatteningTolerance);
    public static D2D_RECT_F GetWidenedBounds(this ID2D1Geometry geometry, float strokeWidth = 1, ID2D1StrokeStyle? strokeStyle = null, D2D_MATRIX_3X2_F? worldTransform = null, float flatteningTolerance = Constants.D2D1_DEFAULT_FLATTENING_TOLERANCE)
    {
        ArgumentNullException.ThrowIfNull(geometry);
        geometry.GetWidenedBounds(strokeWidth, strokeStyle, worldTransform.CopyToPointer(), flatteningTolerance, out var bounds).ThrowOnError();
        return bounds;
    }

    public static bool StrokeContainsPoint(this IComObject<ID2D1Geometry> geometry, D2D_POINT_2F point, float strokeWidth = 1, IComObject<ID2D1StrokeStyle>? strokeStyle = null, D2D_MATRIX_3X2_F? worldTransform = null, float flatteningTolerance = Constants.D2D1_DEFAULT_FLATTENING_TOLERANCE) => StrokeContainsPoint(geometry?.Object!, point, strokeWidth, strokeStyle?.Object!, worldTransform, flatteningTolerance);
    public static bool StrokeContainsPoint(this ID2D1Geometry geometry, D2D_POINT_2F point, float strokeWidth = 1, ID2D1StrokeStyle? strokeStyle = null, D2D_MATRIX_3X2_F? worldTransform = null, float flatteningTolerance = Constants.D2D1_DEFAULT_FLATTENING_TOLERANCE)
    {
        ArgumentNullException.ThrowIfNull(geometry);
        geometry.StrokeContainsPoint(point, strokeWidth, strokeStyle, worldTransform.CopyToPointer(), flatteningTolerance, out var contains).ThrowOnError();
        return contains;
    }

    public static bool FillContainsPoint(this IComObject<ID2D1Geometry> geometry, D2D_POINT_2F point, D2D_MATRIX_3X2_F? worldTransform = null, float flatteningTolerance = Constants.D2D1_DEFAULT_FLATTENING_TOLERANCE) => FillContainsPoint(geometry?.Object!, point, worldTransform, flatteningTolerance);
    public static bool FillContainsPoint(this ID2D1Geometry geometry, D2D_POINT_2F point, D2D_MATRIX_3X2_F? worldTransform = null, float flatteningTolerance = Constants.D2D1_DEFAULT_FLATTENING_TOLERANCE)
    {
        ArgumentNullException.ThrowIfNull(geometry);
        geometry.FillContainsPoint(point, worldTransform.CopyToPointer(), flatteningTolerance, out var contains).ThrowOnError();
        return contains;
    }

    public static D2D1_GEOMETRY_RELATION CompareWithGeometry(this IComObject<ID2D1Geometry> geometry, IComObject<ID2D1Geometry> inputGeometry, D2D_MATRIX_3X2_F? inputGeometryTransform = null, float flatteningTolerance = Constants.D2D1_DEFAULT_FLATTENING_TOLERANCE) => CompareWithGeometry(geometry?.Object!, inputGeometry?.Object!, inputGeometryTransform, flatteningTolerance);
    public static D2D1_GEOMETRY_RELATION CompareWithGeometry(this ID2D1Geometry geometry, ID2D1Geometry inputGeometry, D2D_MATRIX_3X2_F? inputGeometryTransform = null, float flatteningTolerance = Constants.D2D1_DEFAULT_FLATTENING_TOLERANCE)
    {
        ArgumentNullException.ThrowIfNull(geometry);
        geometry.CompareWithGeometry(inputGeometry, inputGeometryTransform.CopyToPointer(), flatteningTolerance, out var relation).ThrowOnError();
        return relation;
    }

    public static void Simplify(this IComObject<ID2D1Geometry> geometry, IComObject<ID2D1SimplifiedGeometrySink> geometrySink, D2D1_GEOMETRY_SIMPLIFICATION_OPTION simplificationOption = D2D1_GEOMETRY_SIMPLIFICATION_OPTION.D2D1_GEOMETRY_SIMPLIFICATION_OPTION_CUBICS_AND_LINES, D2D_MATRIX_3X2_F? worldTransform = null, float flatteningTolerance = Constants.D2D1_DEFAULT_FLATTENING_TOLERANCE) => Simplify(geometry?.Object!, geometrySink?.Object!, simplificationOption, worldTransform, flatteningTolerance);
    public static void Simplify(this ID2D1Geometry geometry, ID2D1SimplifiedGeometrySink geometrySink, D2D1_GEOMETRY_SIMPLIFICATION_OPTION simplificationOption = D2D1_GEOMETRY_SIMPLIFICATION_OPTION.D2D1_GEOMETRY_SIMPLIFICATION_OPTION_CUBICS_AND_LINES, D2D_MATRIX_3X2_F? worldTransform = null, float flatteningTolerance = Constants.D2D1_DEFAULT_FLATTENING_TOLERANCE)
    {
        ArgumentNullException.ThrowIfNull(geometry);
        ArgumentNullException.ThrowIfNull(geometrySink);
        geometry.Simplify(simplificationOption, worldTransform.CopyToPointer(), flatteningTolerance, geometrySink).ThrowOnError();
    }

    public static void Tessellate(this IComObject<ID2D1Geometry> geometry, IComObject<ID2D1TessellationSink> tessellationSink, D2D_MATRIX_3X2_F? worldTransform = null, float flatteningTolerance = Constants.D2D1_DEFAULT_FLATTENING_TOLERANCE) => Tessellate(geometry?.Object!, tessellationSink?.Object!, worldTransform, flatteningTolerance);
    public static void Tessellate(this ID2D1Geometry geometry, ID2D1TessellationSink tessellationSink, D2D_MATRIX_3X2_F? worldTransform = null, float flatteningTolerance = Constants.D2D1_DEFAULT_FLATTENING_TOLERANCE)
    {
        ArgumentNullException.ThrowIfNull(geometry);
        ArgumentNullException.ThrowIfNull(tessellationSink);
        geometry.Tessellate(worldTransform.CopyToPointer(), flatteningTolerance, tessellationSink).ThrowOnError();
    }

    public static void CombineWithGeometry(this IComObject<ID2D1Geometry> geometry, IComObject<ID2D1Geometry> inputGeometry, IComObject<ID2D1SimplifiedGeometrySink> geometrySink, D2D1_COMBINE_MODE combineMode = D2D1_COMBINE_MODE.D2D1_COMBINE_MODE_UNION, D2D_MATRIX_3X2_F? inputGeometryTransform = null, float flatteningTolerance = Constants.D2D1_DEFAULT_FLATTENING_TOLERANCE) => CombineWithGeometry(geometry?.Object!, inputGeometry?.Object!, geometrySink?.Object!, combineMode, inputGeometryTransform, flatteningTolerance);
    public static void CombineWithGeometry(this ID2D1Geometry geometry, ID2D1Geometry inputGeometry, ID2D1SimplifiedGeometrySink geometrySink, D2D1_COMBINE_MODE combineMode = D2D1_COMBINE_MODE.D2D1_COMBINE_MODE_UNION, D2D_MATRIX_3X2_F? inputGeometryTransform = null, float flatteningTolerance = Constants.D2D1_DEFAULT_FLATTENING_TOLERANCE)
    {
        ArgumentNullException.ThrowIfNull(geometry);
        ArgumentNullException.ThrowIfNull(inputGeometry);
        ArgumentNullException.ThrowIfNull(geometrySink);
        geometry.CombineWithGeometry(inputGeometry, combineMode, inputGeometryTransform.CopyToPointer(), flatteningTolerance, geometrySink).ThrowOnError();
    }

    public static void Outline(this IComObject<ID2D1Geometry> geometry, IComObject<ID2D1SimplifiedGeometrySink> geometrySink, D2D_MATRIX_3X2_F? worldTransform = null, float flatteningTolerance = Constants.D2D1_DEFAULT_FLATTENING_TOLERANCE) => Outline(geometry?.Object!, geometrySink?.Object!, worldTransform, flatteningTolerance);
    public static void Outline(this ID2D1Geometry geometry, ID2D1SimplifiedGeometrySink geometrySink, D2D_MATRIX_3X2_F? worldTransform = null, float flatteningTolerance = Constants.D2D1_DEFAULT_FLATTENING_TOLERANCE)
    {
        ArgumentNullException.ThrowIfNull(geometry);
        ArgumentNullException.ThrowIfNull(geometrySink);
        geometry.Outline(worldTransform.CopyToPointer(), flatteningTolerance, geometrySink).ThrowOnError();
    }

    public static D2D_RECT_F ComputeArea(this IComObject<ID2D1Geometry> geometry, D2D_MATRIX_3X2_F? worldTransform = null, float flatteningTolerance = Constants.D2D1_DEFAULT_FLATTENING_TOLERANCE) => ComputeArea(geometry?.Object!, worldTransform, flatteningTolerance);
    public static D2D_RECT_F ComputeArea(this ID2D1Geometry geometry, D2D_MATRIX_3X2_F? worldTransform = null, float flatteningTolerance = Constants.D2D1_DEFAULT_FLATTENING_TOLERANCE)
    {
        ArgumentNullException.ThrowIfNull(geometry);
        geometry.ComputeArea(worldTransform.CopyToPointer(), flatteningTolerance, out var area).ThrowOnError();
        return area;
    }

    public static D2D_RECT_F ComputeLength(this IComObject<ID2D1Geometry> geometry, D2D_MATRIX_3X2_F? worldTransform = null, float flatteningTolerance = Constants.D2D1_DEFAULT_FLATTENING_TOLERANCE) => ComputeLength(geometry?.Object!, worldTransform, flatteningTolerance);
    public static D2D_RECT_F ComputeLength(this ID2D1Geometry geometry, D2D_MATRIX_3X2_F? worldTransform = null, float flatteningTolerance = Constants.D2D1_DEFAULT_FLATTENING_TOLERANCE)
    {
        ArgumentNullException.ThrowIfNull(geometry);
        geometry.ComputeLength(worldTransform.CopyToPointer(), flatteningTolerance, out var area).ThrowOnError();
        return area;
    }

    public static Tuple<D2D_POINT_2F, D2D_POINT_2F> ComputePointAtLength(this IComObject<ID2D1Geometry> geometry, float length, D2D_MATRIX_3X2_F? worldTransform = null, float flatteningTolerance = Constants.D2D1_DEFAULT_FLATTENING_TOLERANCE) => ComputePointAtLength(geometry?.Object!, length, worldTransform, flatteningTolerance);
    public static unsafe Tuple<D2D_POINT_2F, D2D_POINT_2F> ComputePointAtLength(this ID2D1Geometry geometry, float length, D2D_MATRIX_3X2_F? worldTransform = null, float flatteningTolerance = Constants.D2D1_DEFAULT_FLATTENING_TOLERANCE)
    {
        ArgumentNullException.ThrowIfNull(geometry);
        var point = new D2D_POINT_2F();
        var unitTangentVector = new D2D_POINT_2F();
        geometry.ComputePointAtLength(length, worldTransform.CopyToPointer(), flatteningTolerance, (nint)(&point), (nint)(&unitTangentVector)).ThrowOnError();
        return new Tuple<D2D_POINT_2F, D2D_POINT_2F>(point, unitTangentVector);
    }

    public static void Widen(this IComObject<ID2D1Geometry> geometry, IComObject<ID2D1SimplifiedGeometrySink> geometrySink, float strokeWidth = 1, IComObject<ID2D1StrokeStyle>? strokeStyle = null, D2D_MATRIX_3X2_F? worldTransform = null, float flatteningTolerance = Constants.D2D1_DEFAULT_FLATTENING_TOLERANCE) => Widen(geometry?.Object!, geometrySink?.Object!, strokeWidth, strokeStyle?.Object!, worldTransform, flatteningTolerance);
    public static void Widen(this ID2D1Geometry geometry, ID2D1SimplifiedGeometrySink geometrySink, float strokeWidth = 1, ID2D1StrokeStyle? strokeStyle = null, D2D_MATRIX_3X2_F? worldTransform = null, float flatteningTolerance = Constants.D2D1_DEFAULT_FLATTENING_TOLERANCE)
    {
        ArgumentNullException.ThrowIfNull(geometry);
        ArgumentNullException.ThrowIfNull(geometrySink);
        geometry.Widen(strokeWidth, strokeStyle, worldTransform.CopyToPointer(), flatteningTolerance, geometrySink).ThrowOnError();
    }
}
