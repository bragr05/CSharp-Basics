public class WebSales : StoreSales
{
    public string SaleUrl { get; set; }

    public WebSales(string name, string url, decimal price, decimal taxes) : base(name, price, taxes)
    {
        SaleUrl = url;
    }

    // Reserved word 'override' to indicate overwriting 
    public override string getSaleSummary()
    {
        decimal totalSale = SalePrice + SaleTaxes;
        return "SALE NAME: " + SaleName + " / SALE TOTAL: " + totalSale.ToString() + " / SALE URl: " + SaleUrl;
    }
}

public class StoreSales
{

    public string SaleName { get; set; }
    public decimal SalePrice { get; set; }
    public decimal SaleTaxes { get; set; }

    public StoreSales(string name, decimal price, decimal taxes)
    {
        SaleName = name;
        SalePrice = price;
        SaleTaxes = taxes;
    }

    // Reserved word "virtual" to indicate overwrite capability  
    public virtual string getSaleSummary()
    {
        decimal totalSale = SalePrice + SaleTaxes;
        return "SALE NAME: " + SaleName + " / SALE TOTAL: " + totalSale.ToString();
    }
}