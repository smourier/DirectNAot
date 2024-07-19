namespace DirectN.Extensions;

public static class ID3D12ObjectExtensions
{
    public static void SetName(this IComObject<ID3D12Object> obj, string name) => SetName(obj?.Object!, name);
    public static void SetName(this ID3D12Object obj, string name)
    {
        obj.SetName(PWSTR.From(name));
    }

    public static void SetPrivateData(this IComObject<ID3D12Object> obj, Guid guid, uint dataSize, nint data) => SetPrivateData(obj?.Object!, guid, dataSize, data);
    public static void SetPrivateData(this ID3D12Object obj, Guid guid, uint dataSize, nint data)
    {
        obj.SetPrivateData(guid, dataSize, data).ThrowOnError();
    }

    public static void SetPrivateDataInterface(this IComObject<ID3D12Object> obj, Guid guid, nint data) => SetPrivateDataInterface(obj?.Object!, guid, data);
    public static void SetPrivateDataInterface(this ID3D12Object obj, Guid guid, nint data)
    {
        obj.SetPrivateDataInterface(guid, data).ThrowOnError();
    }

    public static IComObject<ID3D12Device> GetDevice(this IComObject<ID3D12DeviceChild> child) => GetDevice<ID3D12Device>(child?.Object!);
    public static IComObject<ID3D12Device> GetDevice(this ID3D12DeviceChild child) => GetDevice<ID3D12Device>(child);
    public static IComObject<T> GetDevice<T>(this IComObject<ID3D12DeviceChild> child) where T : ID3D12Device => GetDevice<T>(child?.Object!);
    public static IComObject<T> GetDevice<T>(this ID3D12DeviceChild child) where T : ID3D12Device
    {
        ArgumentNullException.ThrowIfNull(child);
        child.GetDevice(typeof(T).GUID, out var unk).ThrowOnError();
        return ComObject.FromPointer<T>(unk)!;
    }

    public static D3D12_HEAP_PROPERTIES GetHeapProperties(this IComObject<ID3D12Resource> resource) => GetHeapProperties(resource?.Object!);
    public static unsafe D3D12_HEAP_PROPERTIES GetHeapProperties(this ID3D12Resource resource)
    {
        ArgumentNullException.ThrowIfNull(resource);
        var props = new D3D12_HEAP_PROPERTIES();
        resource.GetHeapProperties((nint)(&props), 0);
        return props;
    }

    public static D3D12_HEAP_FLAGS GetHeapFlags(this IComObject<ID3D12Resource> resource) => GetHeapFlags(resource?.Object!);
    public static unsafe D3D12_HEAP_FLAGS GetHeapFlags(this ID3D12Resource resource)
    {
        ArgumentNullException.ThrowIfNull(resource);
        var flags = new D3D12_HEAP_FLAGS();
        resource.GetHeapProperties(0, (nint)(&flags));
        return flags;
    }

    public static ulong GetGPUVirtualAddress(this IComObject<ID3D12Resource> resource) => GetGPUVirtualAddress(resource?.Object!);
    public static ulong GetGPUVirtualAddress(this ID3D12Resource resource)
    {
        ArgumentNullException.ThrowIfNull(resource);
        return resource.GetGPUVirtualAddress();
    }

    public static D3D12_RESOURCE_DESC GetDesc(this IComObject<ID3D12Resource> resource) => GetDesc(resource?.Object!);
    public static D3D12_RESOURCE_DESC GetDesc(this ID3D12Resource resource)
    {
        ArgumentNullException.ThrowIfNull(resource);
        return resource.GetDesc();
    }

    public static nint Map(this IComObject<ID3D12Resource> resource, uint subresource, D3D12_RANGE? readRange = null) => Map(resource?.Object!, subresource, readRange);
    public static unsafe nint Map(this ID3D12Resource resource, uint subresource, D3D12_RANGE? readRange = null)
    {
        ArgumentNullException.ThrowIfNull(resource);
        nint data;
        resource.Map(subresource, readRange.CopyToPointer(), (nint)(&data)).ThrowOnError();
        return data;
    }

    public static void Unmap(this IComObject<ID3D12Resource> resource, uint subresource, D3D12_RANGE? writtenRange = null) => Unmap(resource?.Object!, subresource, writtenRange);
    public static void Unmap(this ID3D12Resource resource, uint subresource, D3D12_RANGE? writtenRange = null)
    {
        ArgumentNullException.ThrowIfNull(resource);
        resource.Unmap(subresource, writtenRange.CopyToPointer());
    }

    public static void WithMap(this IComObject<ID3D12Resource> resource, uint subresource, Action<nint> action, D3D12_RANGE? readRange = null, D3D12_RANGE? writtenRange = null) => WithMap(resource?.Object!, subresource, action, readRange, writtenRange);
    public static void WithMap(this ID3D12Resource resource, uint subresource, Action<nint> action, D3D12_RANGE? readRange = null, D3D12_RANGE? writtenRange = null)
    {
        ArgumentNullException.ThrowIfNull(resource);
        ArgumentNullException.ThrowIfNull(action);
        var ptr = resource.Map(subresource, readRange);
        try
        {
            action(ptr);
        }
        finally
        {
            resource.Unmap(subresource, writtenRange);
        }
    }

    public static T WithMap<T>(this IComObject<ID3D12Resource> resource, uint subresource, Func<nint, T> func, D3D12_RANGE? readRange = null, D3D12_RANGE? writtenRange = null) => WithMap(resource?.Object!, subresource, func, readRange, writtenRange);
    public static T WithMap<T>(this ID3D12Resource resource, uint subresource, Func<nint, T> func, D3D12_RANGE? readRange = null, D3D12_RANGE? writtenRange = null)
    {
        ArgumentNullException.ThrowIfNull(resource);
        ArgumentNullException.ThrowIfNull(func);
        var ptr = resource.Map(subresource, readRange);
        try
        {
            return func(ptr);
        }
        finally
        {
            resource.Unmap(subresource, writtenRange);
        }
    }

    public static void WriteToSubresource(this IComObject<ID3D12Resource> resource, uint subresource, nint srcData, uint srcRowPitch, uint srcDepthPitch, D3D12_BOX? dstBox = null) => WriteToSubresource(resource?.Object!, subresource, srcData, srcRowPitch, srcDepthPitch, dstBox);
    public static void WriteToSubresource(this ID3D12Resource resource, uint subresource, nint srcData, uint srcRowPitch, uint srcDepthPitch, D3D12_BOX? dstBox = null)
    {
        ArgumentNullException.ThrowIfNull(resource);
        resource.WriteToSubresource(subresource, dstBox.CopyToPointer(), srcData, srcRowPitch, srcDepthPitch).ThrowOnError();
    }

    public static void ReadFromSubresource(this IComObject<ID3D12Resource> resource, nint dstData, uint dstRowPitch, uint dstDepthPitch, uint srcSubresource, D3D12_BOX? dstBox = null) => ReadFromSubresource(resource?.Object!, dstData, dstRowPitch, dstDepthPitch, srcSubresource, dstBox);
    public static void ReadFromSubresource(this ID3D12Resource resource, nint dstData, uint dstRowPitch, uint dstDepthPitch, uint srcSubresource, D3D12_BOX? dstBox = null)
    {
        ArgumentNullException.ThrowIfNull(resource);
        resource.ReadFromSubresource(dstData, dstRowPitch, dstDepthPitch, srcSubresource, dstBox.CopyToPointer()).ThrowOnError();
    }

    public static void Reset(this IComObject<ID3D12CommandAllocator> resource) => Reset(resource?.Object!);
    public static void Reset(this ID3D12CommandAllocator allocator)
    {
        ArgumentNullException.ThrowIfNull(allocator);
        allocator.Reset().ThrowOnError();
    }
}
