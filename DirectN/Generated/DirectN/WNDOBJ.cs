﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-wndobj
public partial struct WNDOBJ
{
    public CLIPOBJ coClient;
    public nint pvConsumer;
    public RECTL rclClient;
    public nint psoOwner;
}
