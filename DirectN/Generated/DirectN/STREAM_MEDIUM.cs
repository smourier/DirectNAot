#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mftransform/ns-mftransform-stream_medium
[StructLayout(LayoutKind.Sequential)]
public partial struct STREAM_MEDIUM
{
    public Guid gidMedium;
    public uint unMediumInstance;
}
