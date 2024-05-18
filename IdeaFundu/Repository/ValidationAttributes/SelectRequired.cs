using System.ComponentModel.DataAnnotations;

namespace Repository.ValidationAttributes
{
    public class SelectRequired : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            Int64 result = Convert.ToInt64(value);
            if(result  == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
