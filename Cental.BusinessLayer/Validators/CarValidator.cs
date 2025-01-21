using Cental.EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.BusinessLayer.Validators
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.ModelName).NotEmpty().WithMessage("Araba modeli boş bırakılamaz.");
            RuleFor(c => c.Transmission).NotEmpty().WithMessage("Vites türü boş bırakılamaz.");
            RuleFor(c => c.GasType).NotEmpty().WithMessage("Yakıt türü boş bırakılamaz.");
            RuleFor(c => c.Price).NotEmpty().WithMessage("Fiyat boş bırakılamaz.");
            RuleFor(c => c.Year).NotEmpty().WithMessage("Yıl boş bırakılamaz.");
            RuleFor(c => c.Kilometer).NotEmpty().WithMessage("Km değeri boş bırakılamaz.");
            RuleFor(c => c.GearType).NotEmpty().WithMessage("Vites boş bırakılamaz.");
            RuleFor(c => c.SeatCount).NotEmpty().WithMessage("Koltuk sayısı boş bırakılamaz.");
        }
    }
}
