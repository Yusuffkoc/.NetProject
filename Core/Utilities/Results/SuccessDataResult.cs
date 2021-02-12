using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data,string message):base(data,true,message)
        {

        }

        //mesaj vermek istemezse
        public SuccessDataResult(T data):base(data,true)
        {

        }

        //sadece mesaj
        public SuccessDataResult(string message):base(default,true,message)
        {

        }

        //hiçbir şey vermeyedebilirsin.
        public SuccessDataResult():base(default,true)
        {
                
        }
    }
}
