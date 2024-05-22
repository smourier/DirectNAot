﻿namespace DirectN;

public static class D3D11Functions
{
    [SupportedOSPlatform("windows6.1")]
    public static unsafe IComObject<ID3D11Device> D3D11CreateDevice(
        IDXGIAdapter adapter,
        D3D_DRIVER_TYPE driverType,
        D3D11_CREATE_DEVICE_FLAG flags,
        D3D_FEATURE_LEVEL[]? featureLevels = null,
        uint sdkVersion = Constants.D3D11_SDK_VERSION)
    {
        //featureLevels = featureLevels ?? new D3D_FEATURE_LEVEL[]
        //{
        //        D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_11_1,
        //        D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_11_0,
        //        D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_10_1,
        //        D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_10_0,
        //        D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_9_3,
        //        D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_9_2,
        //        D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_9_1
        //};

        nint devicePtr;
        Functions.D3D11CreateDevice(
            adapter,
            driverType,
            HMODULE.Null,
            flags,
            featureLevels.AsPointer(),
            featureLevels.Length(),
            sdkVersion,
            (nint)(&devicePtr),
            0,
            0).ThrowOnError();
        return ComObject.FromPointer<ID3D11Device>(devicePtr)!;
    }

    [SupportedOSPlatform("windows6.1")]
    public static unsafe IComObject<ID3D11Device> D3D11CreateDevice(
        IDXGIAdapter adapter,
        D3D_DRIVER_TYPE driverType,
        D3D11_CREATE_DEVICE_FLAG flags,
        out IComObject<ID3D11DeviceContext> deviceContext,
        D3D_FEATURE_LEVEL[]? featureLevels = null,
        uint sdkVersion = Constants.D3D11_SDK_VERSION)
    {
        //featureLevels = featureLevels ?? new D3D_FEATURE_LEVEL[]
        //{
        //        D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_11_1,
        //        D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_11_0,
        //        D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_10_1,
        //        D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_10_0,
        //        D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_9_3,
        //        D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_9_2,
        //        D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_9_1
        //};

        nint devicePtr;
        nint deviceContextPtr;
        Functions.D3D11CreateDevice(
        adapter,
        driverType,
        HMODULE.Null,
        flags,
        featureLevels.AsPointer(),
        featureLevels.Length(),
        sdkVersion,
        (nint)(&devicePtr),
        0,
        (nint)(&deviceContextPtr)).ThrowOnError();
        deviceContext = ComObject.FromPointer<ID3D11DeviceContext>(deviceContextPtr)!;
        return ComObject.FromPointer<ID3D11Device>(devicePtr)!;
    }

    public static IComObject<ID3DBlob> D3DReadFileToBlob(string filename)
    {
        ArgumentNullException.ThrowIfNull(filename);
        using var p = new Pwstr(filename);
        Functions.D3DReadFileToBlob(p, out var blob).ThrowOnError();
        return new ComObject<ID3DBlob>(blob);
    }

    public static unsafe IComObject<ID3DBlob> D3DCompileFromFile(string filename, string entrypoint, string target, uint flags1 = 0, uint flags2 = 0)
    {
        ArgumentNullException.ThrowIfNull(filename);
        ArgumentNullException.ThrowIfNull(entrypoint);
        ArgumentNullException.ThrowIfNull(target);
        using var p = new Pwstr(filename);
        using var pe = new Pstr(entrypoint);
        using var pt = new Pstr(target);
        nint errorBlobUnk;
        var hr = Functions.D3DCompileFromFile(p, 0, null, pe, pt, flags1, flags2, out var blob, (nint)(&errorBlobUnk));
        if (errorBlobUnk != 0)
        {
            using var errorBlob = ComObject.FromPointer<ID3DBlob>(errorBlobUnk);
            var str = errorBlob.GetAnsiStringFromBlob();
            if (str != null)
                throw new Win32Exception(hr.Value, str);

            throw new Win32Exception(hr.Value);
        }

        hr.ThrowOnError();
        return new ComObject<ID3DBlob>(blob);
    }

    public static unsafe IComObject<ID3DBlob> D3DCompile(byte[] srcData, string sourceName, string entrypoint, string target, uint flags1 = 0, uint flags2 = 0)
    {
        ArgumentNullException.ThrowIfNull(srcData);
        ArgumentNullException.ThrowIfNull(entrypoint);
        ArgumentNullException.ThrowIfNull(target);
        using var p = new Pstr(sourceName);
        using var pe = new Pstr(entrypoint);
        using var pt = new Pstr(target);
        nint errorBlobUnk;
        var hr = Functions.D3DCompile(srcData.AsPointer(), srcData.Length(), p, 0, null, pe, pt, flags1, flags2, out var blob, (nint)(&errorBlobUnk));
        if (errorBlobUnk != 0)
        {
            using var errorBlob = ComObject.FromPointer<ID3DBlob>(errorBlobUnk);
            var str = errorBlob.GetAnsiStringFromBlob();
            if (str != null)
                throw new Win32Exception(hr.Value, str);

            throw new Win32Exception(hr.Value);
        }

        hr.ThrowOnError();
        return new ComObject<ID3DBlob>(blob);
    }

    public static IComObject<ID3DBlob> D3DCompile(nint srcData, long srcDataSize, string sourceName, string entrypoint, string target, uint flags1 = 0, uint flags2 = 0) => D3DCompile(srcData, (nint)srcDataSize, sourceName, entrypoint, target, flags1, flags2);
    public static IComObject<ID3DBlob> D3DCompile(nint srcData, int srcDataSize, string sourceName, string entrypoint, string target, uint flags1 = 0, uint flags2 = 0) => D3DCompile(srcData, (nint)srcDataSize, sourceName, entrypoint, target, flags1, flags2);
    public static unsafe IComObject<ID3DBlob> D3DCompile(nint srcData, nuint srcDataSize, string sourceName, string entrypoint, string target, uint flags1 = 0, uint flags2 = 0)
    {
        ArgumentNullException.ThrowIfNull(entrypoint);
        ArgumentNullException.ThrowIfNull(target);
        using var p = new Pstr(sourceName);
        using var pe = new Pstr(entrypoint);
        using var pt = new Pstr(target);
        nint errorBlobUnk;
        var hr = Functions.D3DCompile(srcData, srcDataSize, p, 0, null, pe, pt, flags1, flags2, out var blob, (nint)(&errorBlobUnk));
        if (errorBlobUnk != 0)
        {
            using var errorBlob = ComObject.FromPointer<ID3DBlob>(errorBlobUnk);
            var str = errorBlob.GetAnsiStringFromBlob();
            if (str != null)
                throw new Win32Exception(hr.Value, str);

            throw new Win32Exception(hr.Value);
        }

        hr.ThrowOnError();
        return new ComObject<ID3DBlob>(blob);
    }
}