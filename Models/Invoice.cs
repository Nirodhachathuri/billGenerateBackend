using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Invoice
{
    [Key]
    public int InvoiceId { get; set; }

    public DateTime TransactionDate { get; set; }

    public decimal Discount { get; set; } = 0;

    public decimal TotalAmount { get; set; }

    public decimal PaidAmount { get; set; } // Amount the customer paid

    public decimal BalanceAmount 
    { 
        get
        {
            // Automatically calculate balance
            return TotalAmount - PaidAmount - Discount;
        }
    }

    public List<InvoiceItem> Items { get; set; } = new List<InvoiceItem>();
}

public class InvoiceItem
{
    [Key]
    public int InvoiceItemId { get; set; }

    public int ProductId { get; set; }

    public Product? Product { get; set; } // allow null

    public int Quantity { get; set; }

    public decimal TotalPrice { get; set; } // Price * Quantity
}
