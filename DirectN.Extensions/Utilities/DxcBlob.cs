namespace DirectN.Extensions.Utilities;

public class DxcBlob(IComObject<IDxcBlob> blob) : InterlockedComObject<IDxcBlob>(blob)
{
    public nuint Size => ComObject.Object.GetBufferSize();
    public nint Pointer => ComObject.Object.GetBufferPointer();
    public D3D12_SHADER_BYTECODE ShaderByteCode => new() { pShaderBytecode = Pointer, BytecodeLength = Size };

    public DXC_CP? Encoding
    {
        get
        {
            if (ComObject.Object is not IDxcBlobEncoding encoding)
                return null;

            encoding.GetEncoding(out var known, out var cp);
            if (known)
                return cp;

            return null;
        }
    }

    public string? Text
    {
        get
        {
            if (ComObject.Object is IDxcBlobUtf16 utf16)
            {
                var ptr = utf16.GetBufferPointer();
                if (ptr == 0)
                    return null;

                var size = utf16.GetStringLength();
                if (size == 0)
                    return string.Empty;

                return Marshal.PtrToStringUni(ptr, (int)size);
            }

            if (ComObject.Object is IDxcBlobUtf8 utf8)
            {
                // not sure why but GetStringPointer() returns an invalid address
                var ptr = utf8.GetBufferPointer();
                if (ptr == 0)
                    return null;

                var size = utf8.GetStringLength();
                if (size == 0)
                    return string.Empty;

                return Marshal.PtrToStringUTF8(ptr, (int)size);
            }

            if (Encoding == DXC_CP.DXC_CP_ACP)
            {
                var bp = ComObject.Object.GetBufferPointer();
                if (bp == 0)
                    return null;

                var bs = ComObject.Object.GetBufferSize();
                if (bs == 0)
                    return string.Empty;

                return Marshal.PtrToStringAnsi(bp, (int)bs);
            }
            return null;
        }
    }

    public override string ToString() => $"{Pointer.ToHex()} ({Size})";

    public byte[] GetBytes()
    {
        if (Size == 0 || Pointer == 0)
            return [];

        var size = (int)ComObject.Object.GetBufferSize();
        var bytes = new byte[size];
        Marshal.Copy(Pointer, bytes, 0, size);
        return bytes;
    }
}
