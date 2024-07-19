namespace DirectN.Extensions;

[SupportedOSPlatform("windows6.1")]
public static class DWriteFunctions
{
    public static IComObject<IDWriteFactory> DWriteCoreCreateFactory(DWRITE_FACTORY_TYPE type = DWRITE_FACTORY_TYPE.DWRITE_FACTORY_TYPE_SHARED) => DWriteCoreCreateFactory<IDWriteFactory>(type);
    public static IComObject<T> DWriteCoreCreateFactory<T>(DWRITE_FACTORY_TYPE type = DWRITE_FACTORY_TYPE.DWRITE_FACTORY_TYPE_SHARED) where T : IDWriteFactory
    {
        Functions.DWriteCoreCreateFactory(type, typeof(T).GUID, out var unk).ThrowOnError();
        return ComObject.FromPointer<T>(unk)!;
    }

    public static IComObject<IDWriteFactory> DWriteCreateFactory(DWRITE_FACTORY_TYPE type = DWRITE_FACTORY_TYPE.DWRITE_FACTORY_TYPE_SHARED) => DWriteCreateFactory<IDWriteFactory>(type);
    public static IComObject<T> DWriteCreateFactory<T>(DWRITE_FACTORY_TYPE type = DWRITE_FACTORY_TYPE.DWRITE_FACTORY_TYPE_SHARED) where T : IDWriteFactory
    {
        Functions.DWriteCreateFactory(type, typeof(T).GUID, out var unk).ThrowOnError();
        return ComObject.FromPointer<T>(unk)!;
    }

    public static IComObject<IDWriteFactory5>? DWriteCreateFactory5(DWRITE_FACTORY_TYPE type = DWRITE_FACTORY_TYPE.DWRITE_FACTORY_TYPE_SHARED) => DWriteCreateFactory5<IDWriteFactory5>(type);
    public static IComObject<T>? DWriteCreateFactory5<T>(DWRITE_FACTORY_TYPE type = DWRITE_FACTORY_TYPE.DWRITE_FACTORY_TYPE_SHARED) where T : IDWriteFactory5
    {
        Functions.DWriteCreateFactory(type, typeof(T).GUID, out var unk);
        if (unk == 0)
            return null;  // win8

        return ComObject.FromPointer<T>(unk)!;
    }
}
