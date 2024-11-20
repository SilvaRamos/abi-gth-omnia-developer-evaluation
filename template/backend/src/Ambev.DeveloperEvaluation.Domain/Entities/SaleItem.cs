using Ambev.DeveloperEvaluation.Common.Security;
using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Validation;
using MediatR;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

/// <summary>
/// Represents a Sale Item
/// This entity follows domain-driven design principles and includes business rules validation.
/// </summary>
public class SaleItem : BaseEntity
{
    public string ItemName { get; set; } = string.Empty;

    public int Quantitie { get; set; }

    public decimal Price { get; set; }

    public decimal Discount { get; set; }

    public decimal TotalAmount { get; set; }

    public SaleItem()
    {
        TotalAmount  =  ( Quantitie * Price ) - Discount;
    }
}