namespace DirectN.Extensions;

public static class D3D12Functions
{
    public static IComObject<ID3D12Device> D3D12CreateDevice(IComObject<object> adapter, D3D_FEATURE_LEVEL minimumFeatureLevel = D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_11_0) => D3D12CreateDevice<ID3D12Device>(adapter?.Object!, minimumFeatureLevel);
    public static IComObject<T> D3D12CreateDevice<T>(object adapter, D3D_FEATURE_LEVEL minimumFeatureLevel = D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_11_0) where T : ID3D12Device => ComObject.WithComInstance(adapter, ptr =>
    {
        Functions.D3D12CreateDevice(ptr, minimumFeatureLevel, typeof(T).GUID, out var unk).ThrowOnError();
        return ComObject.FromPointer<T>(unk)!;
    });

    public static HRESULT D3D12CheckDeviceCreate(object adapter, D3D_FEATURE_LEVEL minimumFeatureLevel = D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_11_0) => D3D12CheckDeviceCreate<ID3D12Device>(adapter, minimumFeatureLevel);
    public static HRESULT D3D12CheckDeviceCreate<T>(object adapter, D3D_FEATURE_LEVEL minimumFeatureLevel = D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_11_0) where T : ID3D12Device => ComObject.WithComInstance(adapter, ptr =>
    {
        var hr = Functions.D3D12CreateDevice(ptr, minimumFeatureLevel, typeof(T).GUID, out var unk);
        if (unk != 0)
        {
            Marshal.Release(unk);
        }
        return hr;
    });

    public static IComObject<T>? D3D12GetInterface<T>(Guid rclsid, bool throwOnError = true)
    {
        Functions.D3D12GetInterface(rclsid, typeof(T).GUID, out var unk).ThrowOnError(throwOnError);
        return ComObject.FromPointer<T>(unk);
    }

    public static IComObject<T>? D3D12GetDebugInterface<T>()
    {
        Functions.D3D12GetDebugInterface(typeof(T).GUID, out var unk);
        return ComObject.FromPointer<T>(unk);
    }

    public static unsafe IComObject<ID3DBlob> D3D12SerializeRootSignature(D3D12_ROOT_SIGNATURE_DESC rootSignature)
    {
        nint errorBlobUnk;
        var hr = Functions.D3D12SerializeRootSignature(rootSignature, D3D_ROOT_SIGNATURE_VERSION.D3D_ROOT_SIGNATURE_VERSION_1, out var blob, (nint)(&errorBlobUnk));
        if (errorBlobUnk != 0)
        {
            using var errorBlob = ComObject.FromPointer<ID3DBlob>(errorBlobUnk);
            var str = errorBlob.GetAnsiStringFromBlob();
            if (str != null)
                throw new Win32Exception(hr.Value, str);

            throw new Win32Exception(hr.Value);
        }
        return new ComObject<ID3DBlob>(blob);
    }

    public static unsafe IComObject<ID3DBlob> D3D12SerializeRootSignature(D3D12_ROOT_SIGNATURE_DESC1 rootSignature)
    {
        nint errorBlobUnk;
        var hr = Functions.D3D12SerializeRootSignature(rootSignature, D3D_ROOT_SIGNATURE_VERSION.D3D_ROOT_SIGNATURE_VERSION_1_1, out var blob, (nint)(&errorBlobUnk));
        if (errorBlobUnk != 0)
        {
            using var errorBlob = ComObject.FromPointer<ID3DBlob>(errorBlobUnk);
            var str = errorBlob.GetAnsiStringFromBlob();
            if (str != null)
                throw new Win32Exception(hr.Value, str);

            throw new Win32Exception(hr.Value);
        }
        return new ComObject<ID3DBlob>(blob);
    }

    public static unsafe IComObject<ID3DBlob> D3D12SerializeRootSignature(D3D12_VERSIONED_ROOT_SIGNATURE_DESC rootSignature)
    {
        nint errorBlobUnk;
        var hr = Functions.D3D12SerializeVersionedRootSignature(rootSignature, out var blob, (nint)(&errorBlobUnk));
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

    public static IComObject<ID3D12RootSignatureDeserializer> D3D12CreateRootSignatureDeserializer(nint srcData, nuint srcDataSizeInBytes)
    {
        Functions.D3D12CreateRootSignatureDeserializer(srcData, srcDataSizeInBytes, typeof(ID3D12RootSignatureDeserializer).GUID, out var deserializer).ThrowOnError();
        return ComObject.FromPointer<ID3D12RootSignatureDeserializer>(deserializer)!;
    }

    public static IComObject<ID3D12VersionedRootSignatureDeserializer> D3D12CreateVersionedRootSignatureDeserializer(nint srcData, nuint srcDataSizeInBytes)
    {
        Functions.D3D12CreateVersionedRootSignatureDeserializer(srcData, srcDataSizeInBytes, typeof(ID3D12VersionedRootSignatureDeserializer).GUID, out var deserializer).ThrowOnError();
        return ComObject.FromPointer<ID3D12VersionedRootSignatureDeserializer>(deserializer)!;
    }

    // works only on Windows 11 or Windows 10 with developer mode enabled
    public static void SetSDKVersion(uint version, string path, bool throwOnError = false)
    {
        using var conf = D3D12GetInterface<ID3D12SDKConfiguration>(Constants.CLSID_D3D12SDKConfiguration, throwOnError);
        conf?.Object.SetSDKVersion(version, PSTR.From(path)).ThrowOnError(throwOnError);
    }
}
