using Ambev.DeveloperEvaluation.Common.Security;
using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Validation;
using MediatR;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ambev.DeveloperEvaluation.Domain.Entities;


/// <summary>
/// Represents a user in the system with authentication and profile information.
/// This entity follows domain-driven design principles and includes business rules validation.
/// </summary>
public class Sale : BaseEntity
{
    public string SaleNumber { get; set; } = string.Empty;

    public DateTime SaleDate{ get; set; }

    public Customer Customer { get; set; }

    public Branch Branch { get; set; }

    public List <SaleItem> SaleItems { get; set; }

    public bool Cancelled { get; set; }

    public Sale()
    {
        SaleDate    = DateTime.UtcNow;
        SaleItems   = new List<SaleItem>();
        Customer    = new Customer();
        Branch      = new Branch();
    }
}