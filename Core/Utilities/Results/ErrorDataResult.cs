using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{

    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }

        //mesaj vermek istemezse
        public ErrorDataResult(T data) : base(data, false)
        {

        }

        //sadece mesaj
        public ErrorDataResult(string message) : base(default, false, message)
        {

        }

        //hiçbir şey vermeyedebilirsin.
        public ErrorDataResult() : base(default, false)
        {

        }
    }

}
