using System.Runtime.InteropServices.Marshalling;

namespace DirectN.Extensions.Utilities;

[GeneratedComClass]
public partial class MFAttributes(string? name = null) :
    InterlockedComObject<IMFAttributes>(CreateAttributes()),
    IMFAttributes,
    IDictionary<Guid, object?>
{
    private static ComObject<IMFAttributes> CreateAttributes()
    {
        Functions.MFCreateAttributes(out var obj, 0).ThrowOnError();
        return new ComObject<IMFAttributes>(obj);
    }

    public string? Name { get; } = name;
    public ICollection<Guid> Keys => [.. NativeObject.EnumerateTypes().Select(x => x.Key)];
    public ICollection<object?> Values => [.. NativeObject.EnumerateValues().Select(x => x.Value)];
    public IEnumerable<KeyValuePair<string, object?>> TraceDictionary => NativeObject.GetTraceDictionary();
    object? IDictionary<Guid, object?>.this[Guid key] { get { TryGetValue(key, out var value); return value; } set => this.Set(key, value); }
    public int Count
    {
        get
        {
            NativeObject.GetCount(out var count);
            return (int)count;
        }
    }

    protected virtual void Trace(string? text = null, [CallerMemberName] string? methodName = null) => Application.TraceVerbose($"{Name}::{methodName}: {text}");

    public virtual void Add(Guid key, object? value) => this.Set(key, value);
    public virtual void Clear() => NativeObject.DeleteAllItems().ThrowOnError();
    public virtual bool ContainsKey(Guid key) => NativeObject.GetItemType(key, out var _).IsOk;
    public virtual bool Remove(Guid key) => NativeObject.DeleteItem(key).IsOk;
    public virtual bool TryGetValue(Guid key, out object? value) => NativeObject.TryGetValue(key, out value);

    bool ICollection<KeyValuePair<Guid, object?>>.IsReadOnly => false;
    IEnumerator IEnumerable.GetEnumerator() => NativeObject.EnumerateValues().GetEnumerator();
    IEnumerator<KeyValuePair<Guid, object?>> IEnumerable<KeyValuePair<Guid, object?>>.GetEnumerator() => NativeObject.EnumerateValues().GetEnumerator();
    void ICollection<KeyValuePair<Guid, object?>>.Add(KeyValuePair<Guid, object?> item) => Add(item.Key, item.Value);
    bool ICollection<KeyValuePair<Guid, object?>>.Contains(KeyValuePair<Guid, object?> item) => ContainsKey(item.Key) && NativeObject.TryGetValue(item.Key, out var value) && Equals(value, item.Value);
    bool ICollection<KeyValuePair<Guid, object?>>.Remove(KeyValuePair<Guid, object?> item) => Remove(item.Key);
    void ICollection<KeyValuePair<Guid, object?>>.CopyTo(KeyValuePair<Guid, object?>[] array, int arrayIndex)
    {
        ArgumentNullException.ThrowIfNull(array);
        var needed = array.Length - arrayIndex;
        var thisArray = NativeObject.EnumerateValues().Take(needed).ToArray();
        Array.Copy(thisArray, 0, array, arrayIndex, thisArray.Length);
    }

    HRESULT IMFAttributes.CopyAllItems(IMFAttributes pDest)
    {
        var hr = NativeObject.CopyAllItems(pDest);
        Trace($"{pDest} => {hr}");
        return hr;
    }

    HRESULT IMFAttributes.Compare(IMFAttributes? pTheirs, MF_ATTRIBUTES_MATCH_TYPE MatchType, out BOOL pbResult)
    {
        var hr = NativeObject.Compare(pTheirs, MatchType, out pbResult);
        Trace($"{pTheirs} {MatchType} {pbResult} => {hr}");
        return hr;
    }

    HRESULT IMFAttributes.CompareItem(in Guid guidKey, in PROPVARIANT Value, out BOOL pbResult)
    {
        var hr = NativeObject.CompareItem(guidKey, Value, out pbResult);
#if DEBUG
        Trace($"{guidKey} value:{PropVariant.Unwrap(Value)} result:{pbResult} => {hr}");
#else
        Trace($"{guidKey} value:{Value} result:{pbResult} => {hr}");
#endif
        return hr;
    }

    HRESULT IMFAttributes.DeleteAllItems()
    {
        var hr = NativeObject.DeleteAllItems();
        Trace($" => {hr}");
        return hr;
    }

    HRESULT IMFAttributes.DeleteItem(in Guid guidKey)
    {
        var hr = NativeObject.DeleteItem(guidKey);
        Trace($"{guidKey} => {hr}");
        return hr;
    }

    HRESULT IMFAttributes.GetAllocatedBlob(in Guid guidKey, out nint ppBuf, out uint pcbSize)
    {
        var hr = NativeObject.GetAllocatedBlob(guidKey, out ppBuf, out pcbSize);
        Trace($"{guidKey} {ppBuf} {pcbSize} => {hr}");
        return hr;
    }

    HRESULT IMFAttributes.GetAllocatedString(in Guid guidKey, out PWSTR ppwszValue, out uint pcchLength)
    {
        var hr = NativeObject.GetAllocatedString(guidKey, out ppwszValue, out pcchLength);
        Trace($"{guidKey} {ppwszValue} {pcchLength} => {hr}");
        return hr;
    }

    HRESULT IMFAttributes.GetBlob(in Guid guidKey, nint pBuf, uint cbBufSize, nint pcbBlobSize)
    {
        var hr = NativeObject.GetBlob(guidKey, pBuf, cbBufSize, pcbBlobSize);
        Trace($"{guidKey} {pBuf} {cbBufSize} {pcbBlobSize} => {hr}");
        return hr;
    }

    HRESULT IMFAttributes.GetBlobSize(in Guid guidKey, out uint pcbBlobSize)
    {
        var hr = NativeObject.GetBlobSize(guidKey, out pcbBlobSize);
        Trace($"{guidKey} {pcbBlobSize} => {hr}");
        return hr;
    }

    HRESULT IMFAttributes.GetCount(out uint pcItems)
    {
        var hr = NativeObject.GetCount(out pcItems);
        Trace($"{pcItems} => {hr}");
        return hr;
    }

    HRESULT IMFAttributes.GetDouble(in Guid guidKey, out double pfValue)
    {
        var hr = NativeObject.GetDouble(guidKey, out pfValue);
        Trace($"{guidKey} {pfValue} => {hr}");
        return hr;
    }

    HRESULT IMFAttributes.GetGUID(in Guid guidKey, out Guid pguidValue)
    {
        var hr = NativeObject.GetGUID(guidKey, out pguidValue);
        Trace($"{guidKey} {pguidValue} => {hr}");
        return hr;
    }

    HRESULT IMFAttributes.GetItem(in Guid guidKey, nint pValue)
    {
        var hr = NativeObject.GetItem(guidKey, pValue);
        Trace($"{guidKey} {pValue} => {hr}");
        return hr;
    }

    HRESULT IMFAttributes.GetItemByIndex(uint unIndex, out Guid pguidKey, nint pValue)
    {
        var hr = NativeObject.GetItemByIndex(unIndex, out pguidKey, pValue);
        Trace($"{unIndex} {pguidKey} {pValue} => {hr}");
        return hr;
    }

    HRESULT IMFAttributes.GetItemType(in Guid guidKey, out MF_ATTRIBUTE_TYPE pType)
    {
        var hr = NativeObject.GetItemType(guidKey, out pType);
        Trace($"{guidKey} {pType} => {hr}");
        return hr;
    }

    HRESULT IMFAttributes.GetString(in Guid guidKey, PWSTR pwszValue, uint cchBufSize, nint pcchLength)
    {
        var hr = NativeObject.GetString(guidKey, pwszValue, cchBufSize, pcchLength);
        Trace($"{guidKey} {pwszValue} {cchBufSize} {pcchLength} => {hr}");
        return hr;
    }

    HRESULT IMFAttributes.GetStringLength(in Guid guidKey, out uint pcchLength)
    {
        var hr = NativeObject.GetStringLength(guidKey, out pcchLength);
        Trace($"{guidKey} {pcchLength} => {hr}");
        return hr;
    }

    HRESULT IMFAttributes.GetUINT32(in Guid guidKey, out uint punValue)
    {
        var hr = NativeObject.GetUINT32(guidKey, out punValue);
        Trace($"{guidKey} {punValue} => {hr}");
        return hr;
    }

    HRESULT IMFAttributes.GetUINT64(in Guid guidKey, out ulong punValue)
    {
        var hr = NativeObject.GetUINT64(guidKey, out punValue);
        Trace($"{guidKey} {punValue} => {hr}");
        return hr;
    }

    HRESULT IMFAttributes.GetUnknown(in Guid guidKey, in Guid riid, out nint ppv)
    {
        var hr = NativeObject.GetUnknown(guidKey, riid, out ppv);
        Trace($"{guidKey} {riid} {ppv} => {hr}");
        return hr;
    }

    HRESULT IMFAttributes.LockStore()
    {
        var hr = NativeObject.LockStore();
        Trace($" => {hr}");
        return hr;
    }

    HRESULT IMFAttributes.SetBlob(in Guid guidKey, nint pBuf, uint cbBufSize)
    {
        var hr = NativeObject.SetBlob(guidKey, pBuf, cbBufSize);
        Trace($"{guidKey} value:{pBuf} {cbBufSize} => {hr}");
        return hr;
    }

    HRESULT IMFAttributes.SetDouble(in Guid guidKey, double fValue)
    {
        var hr = NativeObject.SetDouble(guidKey, fValue);
        Trace($"{guidKey} value:{fValue} => {hr}");
        return hr;
    }

    HRESULT IMFAttributes.SetGUID(in Guid guidKey, in Guid guidValue)
    {
        var hr = NativeObject.SetGUID(guidKey, guidValue);
        Trace($"{guidKey} value:{guidValue} => {hr}");
        return hr;
    }

    HRESULT IMFAttributes.SetItem(in Guid guidKey, in PROPVARIANT Value)
    {
        var hr = NativeObject.SetItem(guidKey, Value);
#if DEBUG
        Trace($"{guidKey} value:{PropVariant.Unwrap(Value)} => {hr}");
#else
        Trace($"{guidKey} value:{Value} => {hr}");
#endif
        return hr;
    }

    HRESULT IMFAttributes.SetString(in Guid guidKey, PWSTR wszValue)
    {
        var hr = NativeObject.SetString(guidKey, wszValue);
        Trace($"{guidKey} '{wszValue.ToString()}' => {hr}");
        return hr;
    }

    HRESULT IMFAttributes.SetUINT32(in Guid guidKey, uint unValue)
    {
        var hr = NativeObject.SetUINT32(guidKey, unValue);
        Trace($"{guidKey} value:{unValue} => {hr}");
        return hr;
    }

    HRESULT IMFAttributes.SetUINT64(in Guid guidKey, ulong unValue)
    {
        var hr = NativeObject.SetUINT64(guidKey, unValue);
        Trace($"{guidKey} value:{unValue} => {hr}");
        return hr;
    }

    HRESULT IMFAttributes.SetUnknown(in Guid guidKey, nint pUnknown)
    {
        var hr = NativeObject.SetUnknown(guidKey, pUnknown);
        Trace($"{guidKey} value:{pUnknown} => {hr}");
        return hr;
    }

    HRESULT IMFAttributes.UnlockStore()
    {
        var hr = NativeObject.UnlockStore();
        Trace($" => {hr}");
        return hr;
    }
}
