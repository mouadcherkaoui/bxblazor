using System;
using System.Collections.Generic;
using System.Text;

namespace blazorwasm.Shared
{
    public static class TObjectExtensions
    {
        public static TResult pipeTo<TSource, TResult>
            (this TSource source, Func<TSource, TResult> next) => next(source) ?? default;

        public static void pipeTo<TSource>
            (this TSource source, Action<TSource> next) => next(source);

    }
}
