using System;
using System.Collections.Generic;
using System.Text;

namespace BackendApi
{
    public static class TObjectExtensions
    {
        public static TResult pipeTo<TSource, TResult>
            (this TSource source, Func<TSource, TResult> next) => next(source) ?? default;
    }
}
