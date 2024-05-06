#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmeapi/ns-mmeapi-midievent
[StructLayout(LayoutKind.Sequential)]
public partial struct MIDIEVENT
{
    public uint dwDeltaTime;
    public uint dwStreamID;
    public uint dwEvent;
    public InlineArrayUInt32_1 dwParms; // variable-length array placeholder
}
