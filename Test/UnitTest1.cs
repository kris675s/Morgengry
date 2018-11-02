using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Morgengry;

[TestClass]
public class UnitTest1
{
    Book b1, b2, b3;
    Amulet a11, a12, a13;
    Course c111, c112, c113;
    ValuableRepository repo;

    [TestInitialize]
    public void Init()
    {
        repo = new ValuableRepository();

        b1 = new Book("1");
        b2 = new Book("2", "Falling in Love with Yourself");
        b3 = new Book("3", "Spirits in the Night", 123.55);
        repo.AddValuable(b1);
        repo.AddValuable(b2);
        repo.AddValuable(b3);


        a11 = new Amulet("11");
        a12 = new Amulet("12", Level.high);
        a13 = new Amulet("13", Level.low, "Capricorn");
        repo.AddValuable(a11);
        repo.AddValuable(a12);
        repo.AddValuable(a13);
    }
}