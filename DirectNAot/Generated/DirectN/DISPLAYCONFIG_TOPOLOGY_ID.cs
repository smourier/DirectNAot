namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ne-wingdi-displayconfig_topology_id
public enum DISPLAYCONFIG_TOPOLOGY_ID
{
    DISPLAYCONFIG_TOPOLOGY_INTERNAL = 1,
    DISPLAYCONFIG_TOPOLOGY_CLONE = 2,
    DISPLAYCONFIG_TOPOLOGY_EXTEND = 4,
    DISPLAYCONFIG_TOPOLOGY_EXTERNAL = 8,
}
