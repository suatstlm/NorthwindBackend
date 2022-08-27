﻿using FluentValidation;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator,object entity)
        {
            //var contex = new ValidationContext<object>(entity);
            var result = validator.Validate((IValidationContext)entity /*contex*/);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
