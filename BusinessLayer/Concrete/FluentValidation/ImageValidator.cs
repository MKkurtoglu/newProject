using EntitiyLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete.FluentValidation
{
    public class ImageValidator : AbstractValidator<Image>
    {
        public ImageValidator()
        {
            RuleFor(x=>x.Title).NotEmpty().WithMessage("Resim başlığı boş geçilemez");
            RuleFor(x => x.Description).MaximumLength(25).WithMessage("En fazla 300 karakter girilebilir");
            RuleFor(x => x.ImageURL).NotEmpty().WithMessage("Resim Adresi boş geçilemez");
        }
    }
}
