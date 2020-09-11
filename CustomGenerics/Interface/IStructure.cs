using System;
using System.Collections.Generic;
using System.Text;

/*
 * author: victorisimoo
 * date: 8-septiembre-2020
 */


namespace CustomGenerics.Interface
{
    public abstract class IStructure<T> {
        protected abstract bool Insert(T value, Comparison<T> comparison);

    }
}
