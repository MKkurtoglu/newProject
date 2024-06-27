using EntitiyLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete.FluentValidation
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("görevler en az 5 harfden oluşturulmalıdır");

            RuleFor(x => x.PersonName).NotEmpty().WithMessage("isim boş geçilemez");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Görev Boş geçilemez ");
            RuleFor(x => x.ImageURL).NotEmpty().WithMessage("Resim boş geçilemez");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("görevler en az 5 harfden oluşturulmalıdır");
            //RuleFor(x => x.ImageURL).NotEmpty().WithMessage("Resim boş geçilemez");
            
            


        }
    }
}
