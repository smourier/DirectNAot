#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/ne-xpsobjectmodel-xps_font_embedding
public enum XPS_FONT_EMBEDDING
{
    XPS_FONT_EMBEDDING_NORMAL = 1,
    XPS_FONT_EMBEDDING_OBFUSCATED = 2,
    XPS_FONT_EMBEDDING_RESTRICTED = 3,
    XPS_FONT_EMBEDDING_RESTRICTED_UNOBFUSCATED = 4,
}
