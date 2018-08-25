namespace ChainOfResponsibility.Pattern
{
    using System;

    class ExpenseReport : IExpenseReport
    {
        public ExpenseReport(Decimal total)
        {
            this.Total = total;
        }

        public decimal Total
        {
            get;
            private set;
        }
    }
}