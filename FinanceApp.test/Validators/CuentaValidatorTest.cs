using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Moq;
using Moq.EntityFrameworkCore;
using NUnit.Framework;
using FinanceApp.web.Models;
using FinanceApp.web.Validators;
using FinanceApp.web;

namespace FinanceApp.test.Validators;

internal class CuentaValidatorTest
{
    [Test]
    public void UnicaCuentaCaso01() 
    {
        var contextMock = new Mock<DbEntities>(new DbContextOptions<DbEntities> ());
        contextMock.Setup(o => o.Cuentas).ReturnsDbSet(new List<Cuenta>
    {
        new Cuenta { Nombre = "Cuenta1" },
        new Cuenta { Nombre = "Cuenta2" },
        new Cuenta { Nombre = "Cuenta3" },
    });
        var context = contextMock.Object;

        var validator = new CuentaValidator();

        var result = validator.hasUniqueName(context, new Cuenta { Nombre = "Cuenta3" });
    }

    [Test]
    public void UnicaCuentaCaso02()
    {
        var contextMock = new Mock<DbEntities>(new DbContextOptions<DbEntities>());
        contextMock.Setup(o => o.Cuentas).ReturnsDbSet(new List<Cuenta>
    {
        new Cuenta { Nombre = "Cuenta1" },
        new Cuenta { Nombre = "Cuenta2" },
        new Cuenta { Nombre = "Cuenta3" },
    });
        var context = contextMock.Object;

        var validator = new CuentaValidator();

        var result = validator.hasUniqueName(context, new Cuenta { Nombre = "Cuenta4" });
    }

    [Test]
    public void UnicaCuentaCaso03()
    {
        var contextMock = new Mock<DbEntities>(new DbContextOptions<DbEntities>());
        contextMock.Setup(o => o.Cuentas).ReturnsDbSet(new List<Cuenta>
    {
        new Cuenta { Nombre = "Cuenta1" },
        new Cuenta { Nombre = "Cuenta2" },
        new Cuenta { Nombre = "Cuenta3" },
    });
        var context = contextMock.Object;

        var validator = new CuentaValidator();

        var result = validator.hasUniqueName(context, new Cuenta { Nombre = "NUeva" });
    }
}
