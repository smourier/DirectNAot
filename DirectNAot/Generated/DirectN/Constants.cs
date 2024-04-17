namespace DirectN;

public partial class Constants
{
    public const uint DXGI_CREATE_FACTORY_DEBUG = 1;
    
    public static readonly Guid DXGI_DEBUG_ALL = new("e48ae283-da80-490b-87e6-43e9a9cfda08");
    
    public static readonly Guid DXGI_DEBUG_APP = new("06cd6e01-4219-4ebd-8709-27ed23360c62");
    
    public const uint DXGI_DEBUG_BINARY_VERSION = 1;
    
    public static readonly Guid DXGI_DEBUG_DX = new("35cdd7fc-13b2-421d-a5d7-7e4451287d64");
    
    public static readonly Guid DXGI_DEBUG_DXGI = new("25cddaa4-b1c6-47e1-ac3e-98875b5a2e2a");
    
    public const uint DXGI_ENUM_MODES_DISABLED_STEREO = 8;
    
    public const uint DXGI_ENUM_MODES_INTERLACED = 1;
    
    public const uint DXGI_ENUM_MODES_SCALING = 2;
    
    public const uint DXGI_ENUM_MODES_STEREO = 4;
    
    [MarshalAs(UnmanagedType.Error)]
    public static readonly HRESULT DXGI_ERROR_ACCESS_DENIED = -2005270485;
    
    [MarshalAs(UnmanagedType.Error)]
    public static readonly HRESULT DXGI_ERROR_ACCESS_LOST = -2005270490;
    
    [MarshalAs(UnmanagedType.Error)]
    public static readonly HRESULT DXGI_ERROR_ALREADY_EXISTS = -2005270474;
    
    [MarshalAs(UnmanagedType.Error)]
    public static readonly HRESULT DXGI_ERROR_CACHE_CORRUPT = -2005270477;
    
    [MarshalAs(UnmanagedType.Error)]
    public static readonly HRESULT DXGI_ERROR_CACHE_FULL = -2005270476;
    
    [MarshalAs(UnmanagedType.Error)]
    public static readonly HRESULT DXGI_ERROR_CACHE_HASH_COLLISION = -2005270475;
    
    [MarshalAs(UnmanagedType.Error)]
    public static readonly HRESULT DXGI_ERROR_CANNOT_PROTECT_CONTENT = -2005270486;
    
    [MarshalAs(UnmanagedType.Error)]
    public static readonly HRESULT DXGI_ERROR_DEVICE_HUNG = -2005270522;
    
    [MarshalAs(UnmanagedType.Error)]
    public static readonly HRESULT DXGI_ERROR_DEVICE_REMOVED = -2005270523;
    
    [MarshalAs(UnmanagedType.Error)]
    public static readonly HRESULT DXGI_ERROR_DEVICE_RESET = -2005270521;
    
    [MarshalAs(UnmanagedType.Error)]
    public static readonly HRESULT DXGI_ERROR_DRIVER_INTERNAL_ERROR = -2005270496;
    
    [MarshalAs(UnmanagedType.Error)]
    public static readonly HRESULT DXGI_ERROR_DYNAMIC_CODE_POLICY_VIOLATION = -2005270479;
    
    [MarshalAs(UnmanagedType.Error)]
    public static readonly HRESULT DXGI_ERROR_FRAME_STATISTICS_DISJOINT = -2005270517;
    
    [MarshalAs(UnmanagedType.Error)]
    public static readonly HRESULT DXGI_ERROR_GRAPHICS_VIDPN_SOURCE_IN_USE = -2005270516;
    
    [MarshalAs(UnmanagedType.Error)]
    public static readonly HRESULT DXGI_ERROR_HW_PROTECTION_OUTOFMEMORY = -2005270480;
    
    [MarshalAs(UnmanagedType.Error)]
    public static readonly HRESULT DXGI_ERROR_INVALID_CALL = -2005270527;
    
    [MarshalAs(UnmanagedType.Error)]
    public static readonly HRESULT DXGI_ERROR_MODE_CHANGE_IN_PROGRESS = -2005270491;
    
    [MarshalAs(UnmanagedType.Error)]
    public static readonly HRESULT DXGI_ERROR_MORE_DATA = -2005270525;
    
    [MarshalAs(UnmanagedType.Error)]
    public static readonly HRESULT DXGI_ERROR_MPO_UNPINNED = -2005270428;
    
    [MarshalAs(UnmanagedType.Error)]
    public static readonly HRESULT DXGI_ERROR_NAME_ALREADY_EXISTS = -2005270484;
    
    [MarshalAs(UnmanagedType.Error)]
    public static readonly HRESULT DXGI_ERROR_NON_COMPOSITED_UI = -2005270478;
    
    [MarshalAs(UnmanagedType.Error)]
    public static readonly HRESULT DXGI_ERROR_NONEXCLUSIVE = -2005270495;
    
    [MarshalAs(UnmanagedType.Error)]
    public static readonly HRESULT DXGI_ERROR_NOT_CURRENT = -2005270482;
    
    [MarshalAs(UnmanagedType.Error)]
    public static readonly HRESULT DXGI_ERROR_NOT_CURRENTLY_AVAILABLE = -2005270494;
    
    [MarshalAs(UnmanagedType.Error)]
    public static readonly HRESULT DXGI_ERROR_NOT_FOUND = -2005270526;
    
    [MarshalAs(UnmanagedType.Error)]
    public static readonly HRESULT DXGI_ERROR_REMOTE_CLIENT_DISCONNECTED = -2005270493;
    
    [MarshalAs(UnmanagedType.Error)]
    public static readonly HRESULT DXGI_ERROR_REMOTE_OUTOFMEMORY = -2005270492;
    
    [MarshalAs(UnmanagedType.Error)]
    public static readonly HRESULT DXGI_ERROR_RESTRICT_TO_OUTPUT_STALE = -2005270487;
    
    [MarshalAs(UnmanagedType.Error)]
    public static readonly HRESULT DXGI_ERROR_SDK_COMPONENT_MISSING = -2005270483;
    
    [MarshalAs(UnmanagedType.Error)]
    public static readonly HRESULT DXGI_ERROR_SESSION_DISCONNECTED = -2005270488;
    
    [MarshalAs(UnmanagedType.Error)]
    public static readonly HRESULT DXGI_ERROR_UNSUPPORTED = -2005270524;
    
    [MarshalAs(UnmanagedType.Error)]
    public static readonly HRESULT DXGI_ERROR_WAIT_TIMEOUT = -2005270489;
    
    [MarshalAs(UnmanagedType.Error)]
    public static readonly HRESULT DXGI_ERROR_WAS_STILL_DRAWING = -2005270518;
    
    public const uint DXGI_INFO_QUEUE_DEFAULT_MESSAGE_COUNT_LIMIT = 1024;
    
    public const uint DXGI_INFO_QUEUE_MESSAGE_ID_STRING_FROM_APPLICATION = 0;
    
    public const uint DXGI_MAP_DISCARD = 4;
    
    public const uint DXGI_MAP_READ = 1;
    
    public const uint DXGI_MAP_WRITE = 2;
    
    public const uint DXGI_MAX_SWAP_CHAIN_BUFFERS = 16;
    
    public const uint DXGI_MWA_NO_ALT_ENTER = 2;
    
    public const uint DXGI_MWA_NO_PRINT_SCREEN = 4;
    
    public const uint DXGI_MWA_NO_WINDOW_CHANGES = 1;
    
    public const uint DXGI_MWA_VALID = 7;
    
    public const uint DXGI_PRESENT_ALLOW_TEARING = 512;
    
    public const uint DXGI_PRESENT_DO_NOT_SEQUENCE = 2;
    
    public const uint DXGI_PRESENT_DO_NOT_WAIT = 8;
    
    public const uint DXGI_PRESENT_RESTART = 4;
    
    public const uint DXGI_PRESENT_RESTRICT_TO_OUTPUT = 64;
    
    public const uint DXGI_PRESENT_STEREO_PREFER_RIGHT = 16;
    
    public const uint DXGI_PRESENT_STEREO_TEMPORARY_MONO = 32;
    
    public const uint DXGI_PRESENT_TEST = 1;
    
    public const uint DXGI_PRESENT_USE_DURATION = 256;
    
    public const uint DXGI_RESOURCE_PRIORITY_HIGH = 2684354560;
    
    public const uint DXGI_RESOURCE_PRIORITY_LOW = 1342177280;
    
    public const uint DXGI_RESOURCE_PRIORITY_MAXIMUM = 3355443200;
    
    public const uint DXGI_RESOURCE_PRIORITY_MINIMUM = 671088640;
    
    public const uint DXGI_RESOURCE_PRIORITY_NORMAL = 2013265920;
    
    public const uint DXGI_SHARED_RESOURCE_READ = 2147483648;
    
    public const uint DXGI_SHARED_RESOURCE_WRITE = 1;
}
