namespace DirectN.Extensions;

public static class ID3DBlobExtensions
{
    public static nint GetBufferPointer(this IComObject<ID3DBlob> blob) => GetBufferPointer(blob?.Object!);
    public static nint GetBufferPointer(this ID3DBlob blob)
    {
        ArgumentNullException.ThrowIfNull(blob);
        return blob.GetBufferPointer();
    }

    public static uint GetBufferSize32(this IComObject<ID3DBlob> blob) => GetBufferSize32(blob?.Object!);
    public static uint GetBufferSize32(this ID3DBlob blob)
    {
        ArgumentNullException.ThrowIfNull(blob);
        return blob.GetBufferSize().ToUInt32();
    }

    public static ulong GetBufferSize64(this IComObject<ID3DBlob> blob) => GetBufferSize64(blob?.Object!);
    public static ulong GetBufferSize64(this ID3DBlob blob)
    {
        ArgumentNullException.ThrowIfNull(blob);
        return blob.GetBufferSize().ToUInt64();
    }

    public static nuint GetBufferSize(this IComObject<ID3DBlob> blob) => GetBufferSize(blob?.Object!);
    public static nuint GetBufferSize(this ID3DBlob blob)
    {
        ArgumentNullException.ThrowIfNull(blob);
        return blob.GetBufferSize();
    }

    public static string? GetAnsiStringFromBlob(this IComObject<ID3DBlob>? blob) => GetAnsiStringFromBlob(blob?.Object!);
    public static string? GetAnsiStringFromBlob(this ID3DBlob? blob)
    {
        string? str = null;
        if (blob != null)
        {
            var ptr = blob.GetBufferPointer();
            var len = blob.GetBufferSize();
            if (ptr != 0 && len > 0)
            {
                str = Marshal.PtrToStringAnsi(ptr, (int)len).Nullify();
            }
        }
        return str;
    }

    public static string? GetUTF8StringFromBlob(this IComObject<ID3DBlob>? blob) => GetUTF8StringFromBlob(blob?.Object!);
    public static string? GetUTF8StringFromBlob(this ID3DBlob? blob)
    {
        string? str = null;
        if (blob != null)
        {
            var ptr = blob.GetBufferPointer();
            var len = blob.GetBufferSize();
            if (ptr != 0 && len > 0)
            {
                str = Marshal.PtrToStringUTF8(ptr, (int)len).Nullify();
            }
        }
        return str;
    }

    public static string? GetUnicodeStringFromBlob(this IComObject<ID3DBlob>? blob) => GetUnicodeStringFromBlob(blob?.Object!);
    public static string? GetUnicodeStringFromBlob(this ID3DBlob? blob)
    {
        string? str = null;
        if (blob != null)
        {
            var ptr = blob.GetBufferPointer();
            var len = blob.GetBufferSize();
            if (ptr != 0 && len > 0)
            {
                str = Marshal.PtrToStringUni(ptr, (int)len).Nullify();
            }
        }
        return str;
    }

    public static D3D12_SHADER_BYTECODE ToD3D12_SHADER_BYTECODE(this IComObject<ID3DBlob>? blob) => ToD3D12_SHADER_BYTECODE(blob?.Object!);
    public static D3D12_SHADER_BYTECODE ToD3D12_SHADER_BYTECODE(this ID3DBlob? blob)
    {
        var bc = new D3D12_SHADER_BYTECODE();
        if (blob != null)
        {
            bc.pShaderBytecode = blob.GetBufferPointer();
            bc.BytecodeLength = blob.GetBufferSize();
        }
        return bc;
    }
}
