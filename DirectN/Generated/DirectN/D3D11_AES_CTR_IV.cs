﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_aes_ctr_iv
public partial struct D3D11_AES_CTR_IV
{
    public ulong IV;
    public ulong Count;
}
