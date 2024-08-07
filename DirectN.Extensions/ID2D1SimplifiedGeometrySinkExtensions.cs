﻿namespace DirectN.Extensions;

[SupportedOSPlatform("windows6.1")]
public static class ID2D1SimplifiedGeometrySinkExtensions
{
    public static void AddBeziers(this IComObject<ID2D1SimplifiedGeometrySink> sink, params D2D1_BEZIER_SEGMENT[] segments) => AddBeziers(sink?.Object!, segments);
    public static void AddBeziers(this IComObject<ID2D1SimplifiedGeometrySink> sink, IEnumerable<D2D1_BEZIER_SEGMENT> segments) => AddBeziers(sink?.Object!, segments);
    public static void AddBeziers(this ID2D1SimplifiedGeometrySink sink, IEnumerable<D2D1_BEZIER_SEGMENT> segments)
    {
        ArgumentNullException.ThrowIfNull(sink);
        ArgumentNullException.ThrowIfNull(segments);
        var array = segments.ToArray();
        if (array.Length == 0)
            throw new ArgumentException(null, nameof(segments));

        sink.AddBeziers(array, array.Length());
    }

    public static void AddBezier(this IComObject<ID2D1SimplifiedGeometrySink> sink, D2D1_BEZIER_SEGMENT segment) => AddBezier(sink?.Object!, segment);
    public static void AddBezier(this ID2D1SimplifiedGeometrySink sink, D2D1_BEZIER_SEGMENT segment)
    {
        ArgumentNullException.ThrowIfNull(sink);
        if (sink is ID2D1GeometrySink gsink)
        {
            gsink.AddBezier(segment);
        }
        else
        {
            sink.AddBeziers([segment], 1);
        }
    }

    public static void AddLines(this IComObject<ID2D1SimplifiedGeometrySink> sink, params D2D_POINT_2F[] points) => AddLines(sink?.Object!, points);
    public static void AddLines(this IComObject<ID2D1SimplifiedGeometrySink> sink, IEnumerable<D2D_POINT_2F> points) => AddLines(sink?.Object!, points);
    public static void AddLines(this ID2D1SimplifiedGeometrySink sink, IEnumerable<D2D_POINT_2F> points)
    {
        ArgumentNullException.ThrowIfNull(sink);
        ArgumentNullException.ThrowIfNull(points);
        var array = points.ToArray();
        if (array.Length == 0)
            throw new ArgumentException(null, nameof(points));

        sink.AddLines(array, array.Length());
    }

    public static void AddLine(this IComObject<ID2D1SimplifiedGeometrySink> sink, D2D_POINT_2F point) => AddLine(sink?.Object!, point);
    public static void AddLine(this ID2D1SimplifiedGeometrySink sink, D2D_POINT_2F point)
    {
        ArgumentNullException.ThrowIfNull(sink);
        if (sink is ID2D1GeometrySink gsink)
        {
            gsink.AddLine(point);
        }
        else
        {
            sink.AddLines([point], 1);
        }
    }

    public static void BeginFigure(this IComObject<ID2D1SimplifiedGeometrySink> sink, D2D_POINT_2F startPoint, D2D1_FIGURE_BEGIN figureBegin = D2D1_FIGURE_BEGIN.D2D1_FIGURE_BEGIN_FILLED) => BeginFigure(sink?.Object!, startPoint, figureBegin);
    public static void BeginFigure(this ID2D1SimplifiedGeometrySink sink, D2D_POINT_2F startPoint, D2D1_FIGURE_BEGIN figureBegin = D2D1_FIGURE_BEGIN.D2D1_FIGURE_BEGIN_FILLED)
    {
        ArgumentNullException.ThrowIfNull(sink);
        sink.BeginFigure(startPoint, figureBegin);
    }

    public static void EndFigure(this IComObject<ID2D1SimplifiedGeometrySink> sink, D2D1_FIGURE_END figureEnd = D2D1_FIGURE_END.D2D1_FIGURE_END_OPEN) => EndFigure(sink?.Object!, figureEnd);
    public static void EndFigure(this ID2D1SimplifiedGeometrySink sink, D2D1_FIGURE_END figureEnd = D2D1_FIGURE_END.D2D1_FIGURE_END_OPEN)
    {
        ArgumentNullException.ThrowIfNull(sink);
        sink.EndFigure(figureEnd);
    }

    public static void Close(this IComObject<ID2D1SimplifiedGeometrySink> sink) => Close(sink?.Object!);
    public static void Close(this ID2D1SimplifiedGeometrySink sink)
    {
        ArgumentNullException.ThrowIfNull(sink);
        sink.Close().ThrowOnError();
    }

    public static void SetFillMode(this IComObject<ID2D1SimplifiedGeometrySink> sink, D2D1_FILL_MODE fillMode = D2D1_FILL_MODE.D2D1_FILL_MODE_ALTERNATE) => SetFillMode(sink?.Object!, fillMode);
    public static void SetFillMode(this ID2D1SimplifiedGeometrySink sink, D2D1_FILL_MODE fillMode = D2D1_FILL_MODE.D2D1_FILL_MODE_ALTERNATE)
    {
        ArgumentNullException.ThrowIfNull(sink);
        sink.SetFillMode(fillMode);
    }

    public static void SetSegmentFlags(this IComObject<ID2D1SimplifiedGeometrySink> sink, D2D1_PATH_SEGMENT vertexFlags = D2D1_PATH_SEGMENT.D2D1_PATH_SEGMENT_NONE) => SetSegmentFlags(sink?.Object!, vertexFlags);
    public static void SetSegmentFlags(this ID2D1SimplifiedGeometrySink sink, D2D1_PATH_SEGMENT vertexFlags = D2D1_PATH_SEGMENT.D2D1_PATH_SEGMENT_NONE)
    {
        ArgumentNullException.ThrowIfNull(sink);
        sink.SetSegmentFlags(vertexFlags);
    }
}