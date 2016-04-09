﻿using YZMIS.Resources.Form;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace YZMIS.Components.Mvc
{
    public class DateValidator : ModelValidator
    {
        public DateValidator(ModelMetadata metadata, ControllerContext context)
            : base(metadata, context)
        {
        }

        public override IEnumerable<ModelValidationResult> Validate(Object container)
        {
            return new ModelValidationResult[0];
        }
        public override IEnumerable<ModelClientValidationRule> GetClientValidationRules()
        {
            yield return new ModelClientValidationRule
            {
                ValidationType = "date",
                ErrorMessage = String.Format(Validations.Date, Metadata.GetDisplayName())
            };
        }
    }
}
