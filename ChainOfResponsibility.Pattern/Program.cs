using System;

namespace ChainOfResponsibility.Pattern
{
    using System.Runtime.InteropServices;

    internal class Program
    {
        private static void Main(string[] args)
        {
            ExpenseHandler william = new ExpenseHandler(new ApprovalManager("William Worker", Decimal.Zero));
            ExpenseHandler mary = new ExpenseHandler(new ApprovalManager("Mary Manager", new Decimal(1000)));
            ExpenseHandler victor = new ExpenseHandler(new ApprovalManager("Victor Vice-president", new Decimal(5000)));
            ExpenseHandler paula = new ExpenseHandler(new ApprovalManager("Paula President", new Decimal(20000)));

            william.RegisterNext(mary);
            mary.RegisterNext(victor);
            victor.RegisterNext(paula);

            do
            {
                Console.Clear();
                Console.WriteLine("Enter expense amount");
                decimal expenseReportAmount;
                string approver = String.Empty;
                if (decimal.TryParse(Console.ReadLine(), out expenseReportAmount))
                {
                    IExpenseReport expense = new ExpenseReport(expenseReportAmount);
                    ApprovalResponse response = mary.Approve(expense, ref approver);
                    Console.WriteLine($"Your expense request is {response} and the approver is { approver} " )
                    ;

                    Console.WriteLine("Press a key to continue, Escape to exit");
                }
                
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}