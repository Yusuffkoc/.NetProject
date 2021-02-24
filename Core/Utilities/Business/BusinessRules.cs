using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        //Run içerisine istedigin kadar IResult verebilirsin.
        public static IResult Run(params IResult[] logics)
        {
            foreach (var logic in logics)
            {
                //basarısız olanı business bildirdik.
                if (!logic.Success)
                {
                    return logic;
                }
            }

            return null;
        }
    }
}
