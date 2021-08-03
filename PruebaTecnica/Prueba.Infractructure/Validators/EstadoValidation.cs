using FluentValidation;
using Prueba.Core.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba.Infractructure.Validators
{
    //Fluent validations
    public class EstadoValidation : AbstractValidator<EstadoDto>
    {
        public EstadoValidation()
        {
            RuleFor(estado => estado.Nombre)
            .NotNull()
            .Length(3, 15);

            RuleFor(estado => estado.Id)
            .NotNull()
            .GreaterThan(0);
        }
    }
}
