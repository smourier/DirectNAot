namespace DirectN.Extensions;

[SupportedOSPlatform("windows6.1")]
public static class IMFSinkWriterExtensions
{
    public static IComObject<T>? GetServiceForStream<T>(this IComObject<IMFSinkWriter> obj, uint streamIndex) => GetServiceForStream<T>(obj?.Object!, streamIndex, Guid.Empty, typeof(T).GUID);
    public static IComObject<T>? GetServiceForStream<T>(this IComObject<IMFSinkWriter> obj, uint streamIndex, Guid serviceId, Guid interfaceId) => GetServiceForStream<T>(obj?.Object!, streamIndex, serviceId, interfaceId);
    public static IComObject<T>? GetServiceForStream<T>(this IMFSinkWriter obj, uint streamIndex) => GetServiceForStream<T>(obj, streamIndex, Guid.Empty, typeof(T).GUID);
    public static IComObject<T>? GetServiceForStream<T>(this IMFSinkWriter obj, uint streamIndex, Guid serviceId, Guid interfaceId)
    {
        ArgumentNullException.ThrowIfNull(obj);
        if (obj.GetServiceForStream(streamIndex, serviceId, interfaceId, out var unk).IsError)
            return null;

        return ComObject.FromPointer<T>(unk);
    }
}
