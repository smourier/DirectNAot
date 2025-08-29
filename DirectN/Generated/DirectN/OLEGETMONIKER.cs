#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oleidl/ne-oleidl-olegetmoniker
public enum OLEGETMONIKER
{
    OLEGETMONIKER_ONLYIFTHERE = 1,
    OLEGETMONIKER_FORCEASSIGN = 2,
    OLEGETMONIKER_UNASSIGN = 3,
    OLEGETMONIKER_TEMPFORUSER = 4,
}
