Task1

public class EmployeeReport
{
    public string TypeReport { get; set; }

    public void GenerateReport(Employee em)
    {
        if (TypeReport == "TXT")
        {
            // generate TXT report
        }

        if (TypeReport == "PDF")
        {
            // generate PDF report
        }
    }
}

------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------

Task2

public static class DiscountHelper
{
    public static decimal GetDiscount(string DiscountType)
    {
        var discount = --some heavy logic related to get discount--;
        return discount;
    }
}

public interface IDiscount
{
    decimal GetDiscountForAPerson(string DiscountType);
}

public class ChildDiscount : IDiscount
{
    private string DiscountType { get; set; }

    public ChildDiscount()
    {
        DiscountType = "Child";
    }

    public decimal GetDiscountForAPerson(string DiscountType)
    {
        return DiscountHelper.GetDiscount(DiscountType);
    }
}

public class OldManDiscount : IDiscount
{
    private string DiscountType { get; set; }

    public OldManDiscount()
    {
        DiscountType = "OldMan";
    }

    public decimal GetDiscountForAPerson(string DiscountType)
    {
        return DiscountHelper.GetDiscount(DiscountType);
    }
}

------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------