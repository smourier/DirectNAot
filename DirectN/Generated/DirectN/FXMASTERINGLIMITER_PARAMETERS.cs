#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xapofx/ns-xapofx-fxmasteringlimiter_parameters
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct FXMASTERINGLIMITER_PARAMETERS
{
    public uint Release;
    public uint Loudness;
}
