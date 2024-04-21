using System.Diagnostics.CodeAnalysis;

namespace DirectNAot.Extensions.Com
{
    public abstract class UnknownObject : IUnknownObject
    {
        private ComObject? _comObject;
        private readonly bool _releaseOnDispose;

        public UnknownObject(object? comObject, bool releaseOnDispose = true)
        {
            ArgumentNullException.ThrowIfNull(comObject);
            if (comObject is not ComObject co)
                throw new ArgumentException(null, nameof(comObject));

            _comObject = co;
            _releaseOnDispose = releaseOnDispose;
        }

        public abstract Type InterfaceType { get; }
        [AllowNull]
        public ComObject Object
        {
            get
            {
                var obj = _comObject;
                ObjectDisposedException.ThrowIf(obj == null, this);
                return obj;
            }
        }

        public static object? Unwrap(object? obj)
        {
            if (obj is UnknownObject unko)
                return unko.Object;

            return obj;
        }

        public static T? Unwrap<T>(object obj)
        {
            if (obj == null)
                return default;

            if (obj is UnknownObject unko)
                return (T?)(object?)unko.Object;

            return (T)obj;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing && _releaseOnDispose)
            {
                Interlocked.Exchange(ref _comObject, null)?.FinalRelease();
            }
        }

        ~UnknownObject() { Dispose(disposing: false); }
        public void Dispose() { Dispose(disposing: true); GC.SuppressFinalize(this); }
    }

    public class UnknownObject<T>(object? comObject, bool releaseOnDispose = true) : UnknownObject((T?)comObject, releaseOnDispose), IUnknownObject<T>
    {
        [AllowNull]
        public new T Object => (T)(object?)base.Object!;
        public override Type InterfaceType => typeof(T);
    }
}
