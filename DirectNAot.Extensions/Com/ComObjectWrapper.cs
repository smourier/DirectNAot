﻿namespace DirectNAot.Extensions.Com
{
    public sealed class ComObjectWrapper<T> : IDisposable
    {
        private readonly IComObject<T> _cot;

        public ComObjectWrapper(object obj)
        {
            ArgumentNullException.ThrowIfNull(obj);
            var cot = obj as IComObject<T>;
            if (cot == null)
            {
                if (obj is T t)
                {
                    cot = new ComObject<T>(t);
                }
                else
                {
                    if (obj is IComObject co)
                    {
                        if (co.IsDisposed)
                            throw new ArgumentException("Input of type '" + obj.GetType() + "' is disposed.", nameof(obj));

                        if (co.Object is T t2)
                        {
                            cot = new ComObject<T>(t2);
                        }
                    }

                    if (cot == null)
                        throw new ArgumentException("Input of type '" + obj.GetType() + "' must be assignable to type '" + typeof(T) + "'.", nameof(obj));
                }
            }

            if (cot.IsDisposed)
                throw new ArgumentException("Input of type '" + obj.GetType() + "' is disposed.", nameof(obj));

            _cot = cot;
        }

        public T Object => _cot.Object;
        public IComObject<T> ComObject => _cot;

        public void Dispose()
        {
            if (_cot.IsDisposed)
                return;

            _cot.Dispose();
        }
    }
}