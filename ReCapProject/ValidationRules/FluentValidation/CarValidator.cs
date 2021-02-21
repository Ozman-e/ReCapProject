using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.Id).NotEmpty();
            RuleFor(c => c.Description).NotEmpty().When(c => c.DailyPrice>699);
            //RuleFor(c => c.Description).Must(StartWithM).When((c => c.BrandId == 2));
        }

        //private bool StartWithM(string arg)
        //{
        //    return arg.StartsWith("M");
        //}
    }
}
