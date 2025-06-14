namespace DirectN.Extensions.Utilities;

[System.Runtime.InteropServices.Marshalling.GeneratedComClass]
public partial class CommandTargetConnectionPoint : IConnectionPoint, IDisposable
{
    // we support only IDispatch as the outgoing interface, but it's pretty generic
    private readonly ConcurrentDictionary<uint, IComObject<IDispatch>> _sinks = new();
    private uint _cookie;
    internal IConnectionPointContainer? _container;

    public CommandTargetConnectionPoint(Guid interfaceId)
    {
        InterfaceId = interfaceId; ;
    }

    public Guid InterfaceId { get; }
    public override string ToString() => InterfaceId.ToString();

    public virtual unsafe void InvokeMember(int dispId, params object?[]? parameters)
    {
        Variant[]? variants = null;
        VARIANT[]? vars;
        var dp = new DISPPARAMS();
        if (parameters?.Length > 0)
        {
            variants = new Variant[parameters.Length];
            vars = new VARIANT[parameters.Length];
            for (var i = 0; i < parameters.Length; i++)
            {
                variants[i] = new Variant(parameters[i]);
                vars[i] = variants[i].Detached;
            }

            dp.cArgs = (uint)parameters.Length;
            dp.rgvarg = vars.AsPointer();
        }

        try
        {
            foreach (var kv in _sinks)
            {
                kv.Value.Object.Invoke(dispId, Guid.Empty, 0, DISPATCH_FLAGS.DISPATCH_METHOD, dp, 0, 0, 0);
            }
        }
        finally
        {
            variants.Dispose();
        }
    }

    HRESULT IConnectionPoint.Advise(nint sink, out uint cookie)
    {
        if (sink == 0)
        {
            cookie = 0;
            return Constants.E_POINTER;
        }

        var disp = ComObject.FromPointer<IDispatch>(sink);
        if (disp == null)
        {
            cookie = 0;
            return Constants.CONNECT_E_CANNOTCONNECT;
        }

        cookie = Interlocked.Increment(ref _cookie);
        _sinks[cookie] = disp;
        return Constants.S_OK;
    }

    HRESULT IConnectionPoint.EnumConnections(out IEnumConnections enumerator)
    {
        enumerator = new Connections([.. _sinks]);
        return Constants.S_OK;
    }

    HRESULT IConnectionPoint.GetConnectionInterface(out Guid interfaceId)
    {
        interfaceId = InterfaceId;
        return Constants.S_OK;
    }

    HRESULT IConnectionPoint.GetConnectionPointContainer(out IConnectionPointContainer container)
    {
        container = _container!;
        return container != null ? Constants.S_OK : Constants.E_FAIL;
    }

    HRESULT IConnectionPoint.Unadvise(uint cookie)
    {
        if (!_sinks.TryRemove(cookie, out var disp))
            return Constants.E_UNEXPECTED;

        disp?.Dispose();
        return Constants.S_OK;
    }

    [System.Runtime.InteropServices.Marshalling.GeneratedComClass]
    private sealed partial class Connections(KeyValuePair<uint, IComObject<IDispatch>>[] connections) : IEnumConnections
    {
        private int _index = -1;

        public HRESULT Clone(out IEnumConnections enumerator)
        {
            enumerator = new Connections(connections);
            return Constants.S_OK;
        }

        public HRESULT Next(uint count, CONNECTDATA[] rgcd, out uint fetched)
        {
            var max = (uint)Math.Max(0, Math.Min(connections.Length - (_index + 1), count));
            fetched = max;
            if (fetched > 0)
            {
                for (var i = _index + 1; i < fetched; i++)
                {
                    rgcd[i].dwCookie = connections[i].Key;
                    rgcd[i].pUnk = ComObject.GetOrCreateComInstance(connections[i].Value);
                    Marshal.AddRef(rgcd[i].pUnk);
                    _index++;
                }
            }
            return (fetched == count) ? Constants.S_OK : Constants.S_FALSE;
        }

        public HRESULT Reset() => _index = -1;
        public HRESULT Skip(uint count)
        {
            var max = (uint)Math.Max(0, Math.Min(connections.Length - (_index + 1), count));
            if (max > 0)
            {
                _index += (int)max;
            }
            return (max == count) ? Constants.S_OK : Constants.S_FALSE;
        }
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            foreach (var kv in _sinks)
            {
                try
                {
                    kv.Value.Dispose();
                }
                catch
                {
                    // continue
                }
            }
            // dispose managed state (managed objects)
        }

        // free unmanaged resources (unmanaged objects) and override finalizer
        // set large fields to null
    }

    public void Dispose() { Dispose(disposing: true); GC.SuppressFinalize(this); }
}

