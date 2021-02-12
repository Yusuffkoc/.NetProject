using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Result ve list dondurmesi için data içeriyor mu?
    public interface IDataResult<T>:IResult
    {
        //IResulttan aynı zamanda message be bool kısmını alarak, zaten yazdık tekrar etmiyoruz.
        T Data { get; }
    }
}
