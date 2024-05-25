#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ns-richedit-endcompositionnotify
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct ENDCOMPOSITIONNOTIFY
{
    public NMHDR nmhdr;
    public ENDCOMPOSITIONNOTIFY_CODE dwCode;
}
