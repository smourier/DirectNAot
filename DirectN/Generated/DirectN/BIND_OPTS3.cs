#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidl/ns-objidl-bind_opts3~r1
public partial struct BIND_OPTS3
{
    public BIND_OPTS2 Base;
    public HWND hwnd;
}
