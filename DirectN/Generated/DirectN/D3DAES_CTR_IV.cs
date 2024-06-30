#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/medfound/d3daes-ctr-iv
public partial struct D3DAES_CTR_IV
{
    public ulong IV;
    public ulong Count;
}
