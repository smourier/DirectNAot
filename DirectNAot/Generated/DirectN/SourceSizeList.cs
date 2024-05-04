#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/ne-segment-sourcesizelist
public enum SourceSizeList
{
    sslFullSize = 0,
    sslClipByOverScan = 1,
    sslClipByClipRect = 2,
}
