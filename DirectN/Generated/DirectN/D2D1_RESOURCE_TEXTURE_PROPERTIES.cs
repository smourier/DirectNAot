#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/ns-d2d1effectauthor-d2d1_resource_texture_properties
public partial struct D2D1_RESOURCE_TEXTURE_PROPERTIES
{
    public nint extents;
    public uint dimensions;
    public D2D1_BUFFER_PRECISION bufferPrecision;
    public D2D1_CHANNEL_DEPTH channelDepth;
    public D2D1_FILTER filter;
    public nint extendModes;
}
