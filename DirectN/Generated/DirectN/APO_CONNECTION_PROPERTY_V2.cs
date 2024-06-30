#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioapotypes/ns-audioapotypes-apo_connection_property_v2
public partial struct APO_CONNECTION_PROPERTY_V2
{
    public APO_CONNECTION_PROPERTY property;
    public ulong u64QPCTime;
}
