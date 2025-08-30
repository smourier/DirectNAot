#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfplay/ns-mfplay-mfp_error_event
public partial struct MFP_ERROR_EVENT : IValueGet<MFP_EVENT_HEADER>
{
    public MFP_EVENT_HEADER header;
    
    readonly MFP_EVENT_HEADER IValueGet<MFP_EVENT_HEADER>.GetValue() => header;
    readonly object? IValueGet.GetValue() => header;
}
