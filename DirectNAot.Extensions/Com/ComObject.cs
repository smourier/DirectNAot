using System.Diagnostics.CodeAnalysis;

namespace DirectNAot.Extensions.Com
{
    public abstract class ComObject : IComObject
    {
        public static ComWrappers ComWrappers { get; } = new StrategyBasedComWrappers();

        private System.Runtime.InteropServices.Marshalling.ComObject? _comObject;
        private readonly bool _releaseOnDispose;

        public ComObject(object? comObject, bool releaseOnDispose = true)
        {
            ArgumentNullException.ThrowIfNull(comObject);
            if (comObject is not System.Runtime.InteropServices.Marshalling.ComObject co)
                throw new ArgumentException(null, nameof(comObject));

            _comObject = co;
            _releaseOnDispose = releaseOnDispose;
        }

        public abstract Type InterfaceType { get; }
        public bool IsDisposed => _comObject == null;

        [AllowNull]
        public System.Runtime.InteropServices.Marshalling.ComObject Object
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
            if (obj is ComObject unko)
                return unko.Object;

            return obj;
        }

        public static T? Unwrap<T>(object obj)
        {
            if (obj == null)
                return default;

            if (obj is ComObject unko)
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

        ~ComObject() { Dispose(disposing: false); }
        public void Dispose() { Dispose(disposing: true); GC.SuppressFinalize(this); }
    }

    public class ComObject<T>(object? comObject, bool releaseOnDispose = true) : ComObject((T?)comObject, releaseOnDispose), IComObject<T>
    {
        [AllowNull]
        public new T Object => (T)(object?)base.Object!;
        public override Type InterfaceType => typeof(T);

        public static IComObject<T>? CoCreate(Guid classId, CLSCTX ctx = CLSCTX.CLSCTX_ALL, IntPtr outer = 0, bool throwOnError = true)
        {
            // we use IUnknown first, some objects don't support direct query interface
            Functions.CoCreateInstance(classId, outer, ctx, typeof(IUnknown).GUID, out var ppv).ThrowOnError(throwOnError);
            if (ppv == null)
                return default;

            return new ComObject<T>((T)ppv);
        }
    }
}
