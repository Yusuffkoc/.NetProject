using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        //Result voidler için bu da data içerdiği için bu hale getirdik.
        public DataResult(T data,bool success,string message):base(success,message)
        {
            Data = data;
        }

        //message gondermek istemeyebilir.
        public DataResult(T data,bool success):base(success)
        {
            Data = data;
        }
        public T Data { get; }
    }
}
