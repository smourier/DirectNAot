#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mftransform/ns-mftransform-stream_medium
public partial struct STREAM_MEDIUM
{
    public Guid gidMedium;
    public uint unMediumInstance;
}
