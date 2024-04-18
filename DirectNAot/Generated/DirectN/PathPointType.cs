namespace DirectN;

public enum PathPointType
{
    PathPointTypeStart = 0,
    PathPointTypeLine = 1,
    PathPointTypeBezier = 3,
    PathPointTypePathTypeMask = 7,
    PathPointTypeDashMode = 16,
    PathPointTypePathMarker = 32,
    PathPointTypeCloseSubpath = 128,
    PathPointTypeBezier3 = 3,
}
