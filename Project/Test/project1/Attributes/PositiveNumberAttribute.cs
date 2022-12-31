using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Test3.Attributes
{
    // A to joke in Datainitializer: To stomp out forest fires.
    public class PositiveNumberAttribute : ValidationAttribute
    {

        //Finish creating this attribute such that it will validate the property is a positive number
        public PositiveNumberAttribute() : base("Number should be positive")
        {
        }

        public override bool IsValid(object value)
        {
            try
            {
                int intValue = Convert.ToInt32(value);
                return intValue >= 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}