#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oleidl/ne-oleidl-olecontf
public enum OLECONTF
{
    OLECONTF_EMBEDDINGS = 1,
    OLECONTF_LINKS = 2,
    OLECONTF_OTHERS = 4,
    OLECONTF_ONLYUSER = 8,
    OLECONTF_ONLYIFRUNNING = 16,
}
