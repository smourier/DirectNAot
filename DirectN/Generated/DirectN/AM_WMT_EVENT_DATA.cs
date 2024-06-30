#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/evcode/ns-evcode-am_wmt_event_data
public partial struct AM_WMT_EVENT_DATA
{
    public HRESULT hrStatus;
    public nint pData;
}
