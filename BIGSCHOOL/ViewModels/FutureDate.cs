﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace BIGSCHOOL.ViewModels
{
    public class FutureDate : ValidationAttribute
    {
        DateTime dateTime;
        public override bool IsValid(object value)
        {            
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "dd/MM/yyyy",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out dateTime);
            return (isValid && dateTime > DateTime.Now);  
        }
    }
}