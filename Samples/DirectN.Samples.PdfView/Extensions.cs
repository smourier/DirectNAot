﻿namespace DirectN.Samples.PdfView;

public static class Extensions
{
    public static Color ToColor(this D3DCOLORVALUE value) => Color.FromArgb(value.BA, value.BR, value.BG, value.BB);
    public static D3DCOLORVALUE ToColor(this Color value) => D3DCOLORVALUE.FromArgb(value.A, value.R, value.G, value.B);
    public static Size ToSize(this RECT value) => new(value.Width, value.Height);

    // this is to replace the As<T> on C#/WinRT object which doesn't work well under AOT once published in release...
    [return: NotNullIfNotNull(nameof(winRTObject))]
    public static IComObject<T>? AsComObject<T>(this object? winRTObject, CreateObjectFlags flags = CreateObjectFlags.UniqueInstance)
    {
        if (winRTObject == null)
            return null;

        var ptr = MarshalInspectable<object>.FromManaged(winRTObject);
        var obj = ComObject.FromPointer<T>(ptr, flags);
        return obj ?? throw new InvalidCastException($"Object of type '{winRTObject.GetType().FullName}' is not of type '{typeof(T).FullName}'.");
    }
}
