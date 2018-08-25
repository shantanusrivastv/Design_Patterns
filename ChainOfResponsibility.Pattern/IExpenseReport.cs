using System;

namespace ChainOfResponsibility.Pattern
{
    public interface IExpenseReport
    {
        Decimal Total { get; }
    }
}