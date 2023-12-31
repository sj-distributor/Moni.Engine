﻿using FluentValidation;
using Wax.Core.Middlewares.FluentMessageValidator;
using Wax.Messages.Commands.Customers;

namespace Wax.Core.Validators;

public class CreateCustomerCommandValidator : FluentMessageValidator<CreateCustomerCommand>
{
    public CreateCustomerCommandValidator()
    {
        RuleFor(v => v.Name).NotEmpty().MaximumLength(64);
        RuleFor(v => v.Address).MaximumLength(512);
        RuleFor(v => v.Contact).MaximumLength(128);
    }
}