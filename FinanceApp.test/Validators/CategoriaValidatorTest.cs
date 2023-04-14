/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Moq;
using Moq.EntityFrameworkCore;
using NUnit.Framework;
using FinanceApp.web.Models;
using FinanceApp.web.Validators;
using FinanceApp.web;

namespace FinanceApp.test.Validators;

public class CategoriaValidatorTest
{
    [Test]
    public void NombreCategoriaUnicoCaso01()
    {
        var validator = new CategoriaValidator();
        var result = validator.hasValidType(new Categoria { Id = 01 });

        Assert.IsTrue(result);
    }
}
