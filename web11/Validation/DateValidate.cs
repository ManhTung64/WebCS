using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace web11.Validation
{
    public class DateValidate : ValidationAttribute
    {
        private const string DateTimeFormat = "dd/MM/yy";
        private readonly DateTime date;
        private string today = DateTime.Now.Date.ToShortDateString();
        public DateValidate()
        {
            this.date = DateTime.ParseExact(today, DateTimeFormat, CultureInfo.InvariantCulture);
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if ((DateTime)value >= date) return new ValidationResult(this.ErrorMessage);
            return ValidationResult.Success;
        }
    }
}
