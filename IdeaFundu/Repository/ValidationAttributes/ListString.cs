using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Repository.ValidationAttributes
{
    public class ListString : ValidationAttribute
    {
        public override bool IsValid(object value)
        {

            if (value is List<string> durationList)
            {
                if (durationList.Count == 0)
                {
                    return false;
                }

                foreach (string duration in durationList)
                {
                    if (duration == null)
                    {
                        return false;
                    }
                }

                return true;
            }
            return false;
        }
    }
}
