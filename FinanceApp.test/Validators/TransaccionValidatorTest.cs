
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Moq;
using Moq.EntityFrameworkCore;
using NUnit.Framework;
using FinanceApp.web.Models;
using FinanceApp.web.Validators;
using FinanceApp.web;

namespace FinanceApp.test.Validators;

public class TransaccionValidatorTest
{

    [Test]
    public void ValidarQueSiExisteCategoriaCaso01()
    {
        var contextMock = new Mock<DbEntities>(new DbContextOptions<DbEntities>());
        contextMock.Setup(o => o.Transacciones).ReturnsDbSet(new List<Transaccion>
    {
        new Transaccion { CategoryId = 01 },
        new Transaccion { CategoryId = 02 },
        new Transaccion { CategoryId = 03 },
    });
        var context = contextMock.Object;

        var validator = new TransaccionValidator();

        var result = validator.hasValidCategory(context, new Transaccion { CategoryId = 01 });
    }

    [Test]
    public void ValidarQueSiExisteCategoriaCaso02()
    {
        var contextMock = new Mock<DbEntities>(new DbContextOptions<DbEntities>());
        contextMock.Setup(o => o.Transacciones).ReturnsDbSet(new List<Transaccion>
    {
        new Transaccion { CategoryId = 01 },
        new Transaccion { CategoryId = 02 },
        new Transaccion { CategoryId = 03 },
    });
        var context = contextMock.Object;

        var validator = new TransaccionValidator();

        var result = validator.hasValidCategory(context, new Transaccion { CategoryId = 01 });
    }

    [Test]
    public void ValidarQueSiExisteCategoriaCaso03()
    {
        var contextMock = new Mock<DbEntities>(new DbContextOptions<DbEntities>());
        contextMock.Setup(o => o.Transacciones).ReturnsDbSet(new List<Transaccion>
    {
        new Transaccion { CategoryId = 01 },
        new Transaccion { CategoryId = 02 },
        new Transaccion { CategoryId = 03 },
    });
        var context = contextMock.Object;

        var validator = new TransaccionValidator();

        var result = validator.hasValidCategory(context, new Transaccion { CategoryId = 01 });
    }



    //FALTA///////////////////////////
    [Test]
    public void ValidarIngresoEgresoCaso01()
    {
        var contextMock = new Mock<DbEntities>(new DbContextOptions<DbEntities>());
        contextMock.Setup(o => o.Transacciones).ReturnsDbSet(new List<Transaccion>{
            new Transaccion { CategoryId = 01 } 
        });
    }
}
