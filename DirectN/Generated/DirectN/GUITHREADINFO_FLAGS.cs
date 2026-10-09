#nullable enable
namespace DirectN;

[Flags]
public enum GUITHREADINFO_FLAGS : uint
{
    GUI_CARETBLINKING = 1,
    GUI_INMENUMODE = 4,
    GUI_INMOVESIZE = 2,
    GUI_POPUPMENUMODE = 16,
    GUI_SYSTEMMENUMODE = 8,
}
