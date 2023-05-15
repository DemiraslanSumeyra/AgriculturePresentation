using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public  class AddressValidator:AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(x => x.Description1).NotEmpty().WithMessage("Açıklama1 boş geçilemez.");
            RuleFor(x => x.Description2).NotEmpty().WithMessage("Açıklama2 boş geçilemez.");
            RuleFor(x => x.Description3).NotEmpty().WithMessage("Açıklama3 boş geçilemez.");
            RuleFor(x => x.Description4).NotEmpty().WithMessage("Açıklama4 boş geçilemez.");
            RuleFor(x => x.MapInfo).NotEmpty().WithMessage("Harita bilgisi boş geçilemez.");
            RuleFor(x => x.Description1).MaximumLength(25).WithMessage("Lütfen en fazla 25 karakter veri girişi yapın.");
            RuleFor(x => x.Description2).MaximumLength(25).WithMessage("Lütfen en fazla 25 karakter veri girişi yapın.");
            RuleFor(x => x.Description3).MaximumLength(25).WithMessage("Lütfen en fazla 25 karakter veri girişi yapın.");
            RuleFor(x => x.Description4).MaximumLength(25).WithMessage("Lütfen en fazla 25 karakter veri girişi yapın.");
        }
    }
}
