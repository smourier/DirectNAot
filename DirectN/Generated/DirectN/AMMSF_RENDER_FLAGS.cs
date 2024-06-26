﻿#nullable enable
namespace DirectN;

[Flags]
public enum AMMSF_RENDER_FLAGS
{
    AMMSF_RENDERTYPEMASK = 3,
    AMMSF_RENDERTOEXISTING = 0,
    AMMSF_RENDERALLSTREAMS = 1,
    AMMSF_NORENDER = 2,
    AMMSF_NOCLOCK = 4,
    AMMSF_RUN = 8,
}
