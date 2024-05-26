using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
public class ListDecimal : ValidationAttribute
{
    public override bool IsValid(object value)
    {
        //if (value == null)
        //{
        //    return false;
        //}


        if (value is List<decimal> decimalList)
        {
            if (decimalList.Count == 0)
            {
                return false;
            }

            foreach (var item in decimalList)
            {
                if (item < 0)
                {
                    return false;
                }
            }
            return false;
        }
        return false;
    }
}
