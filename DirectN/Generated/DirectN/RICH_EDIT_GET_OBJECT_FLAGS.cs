#nullable enable
namespace DirectN;

[Flags]
public enum RICH_EDIT_GET_OBJECT_FLAGS : uint
{
    REO_GETOBJ_POLEOBJ = 1,
    REO_GETOBJ_PSTG = 2,
    REO_GETOBJ_POLESITE = 4,
    REO_GETOBJ_NO_INTERFACES = 0,
    REO_GETOBJ_ALL_INTERFACES = 7,
}
