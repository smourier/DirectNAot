namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva2api/ns-dxva2api-dxva2_aes_ctr_iv
[StructLayout(LayoutKind.Sequential)]
public partial struct DXVA2_AES_CTR_IV
{
    public ulong IV;
    public ulong Count;
}
