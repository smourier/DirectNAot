namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ne-strmif-am_graph_config_reconnect_flags
public enum AM_GRAPH_CONFIG_RECONNECT_FLAGS
{
    AM_GRAPH_CONFIG_RECONNECT_DIRECTCONNECT = 1,
    AM_GRAPH_CONFIG_RECONNECT_CACHE_REMOVED_FILTERS = 2,
    AM_GRAPH_CONFIG_RECONNECT_USE_ONLY_CACHED_FILTERS = 4,
}
