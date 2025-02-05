﻿using ExercicioPolimorfismo;
using System.Diagnostics;
using System.Xml.Linq;

internal class UsedProduct : Product
{
    public DateTime ManufactureDate { get; set; }

    public UsedProduct(string name, double price, DateTime manufactureDate)
        : base(name, price)
    {
        ManufactureDate = manufactureDate;
    }

    public override string PriceTag()
    {
        return $"{Name} (used) - $ {Price:F2} (Manufacture date: {ManufactureDate:dd/MM/yyyy})";
    }
}
