﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace BigSchool.ViewModels
{
    public class Validation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime  dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "HH:mm",
                CultureInto.CurrentCulture,
                DateTimeStyles.None,
                out dateTime);
            return IsValid;
        }
    }
}