namespace DirectN;

[SupportedOSPlatform("windows6.1")]
public static class ID3D11Texture2DExtensions
{
    public static D3D11_TEXTURE2D_DESC GetDesc(this IComObject<ID3D11Texture2D> texture) => GetDesc(texture?.Object!);
    public static D3D11_TEXTURE2D_DESC GetDesc(this ID3D11Texture2D texture)
    {
        ArgumentNullException.ThrowIfNull(texture);
        texture.GetDesc(out var desc);
        return desc;
    }
}
