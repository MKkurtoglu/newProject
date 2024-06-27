using EntitiyLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete.FluentValidation
{
    public class AddressValidation : AbstractValidator<Address>
    {
        public AddressValidation()
        {
            RuleFor(x => x.Despriction1).NotEmpty().MaximumLength(50).MinimumLength(5).WithMessage("Açıklama boş geçilemez. Ve 3 harf ile" +
                "50 harf arasında olmak zorundadır.");
            RuleFor(x => x.Despriction2).NotEmpty().MaximumLength(50).MinimumLength(5).WithMessage("Açıklama boş geçilemez. Ve 3 harf ile" +
                "50 harf arasında olmak zorundadır.");
            RuleFor(x => x.Despriction3).NotEmpty().MaximumLength(50).MinimumLength(5).WithMessage("Açıklama boş geçilemez. Ve 3 harf ile" +
                "50 harf arasında olmak zorundadır.");
            RuleFor(x => x.Despriction4).NotEmpty().MaximumLength(50).MinimumLength(5).WithMessage("Açıklama boş geçilemez. Ve 3 harf ile" +
                "50 harf arasında olmak zorundadır.");
            RuleFor(x => x.MapInfo).NotEmpty().WithMessage("Adres bilgisi boş geçilemez.");
        }
    }
}
