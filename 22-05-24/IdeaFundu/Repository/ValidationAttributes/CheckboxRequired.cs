using System.ComponentModel.DataAnnotations;

namespace Repository.ValidationAttributes
{
    public class CheckboxRequired : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            bool result = Convert.ToBoolean(value);
            if(result == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
