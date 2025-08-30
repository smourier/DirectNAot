#nullable enable
namespace DirectN;

public partial struct VIDEO_VDM : IValueGet<HANDLE>
{
    public HANDLE ProcessHandle;
    
    readonly HANDLE IValueGet<HANDLE>.GetValue() => ProcessHandle;
    readonly object? IValueGet.GetValue() => ProcessHandle;
}
