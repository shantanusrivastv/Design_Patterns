using System;

namespace ChainOfResponsibility.Pattern
{
    public interface IExpenseApprover
    {
        ApprovalResponse ApproveExpense(IExpenseReport expenseReport);
        string Name { get; set; }
    }

    class ApprovalManager : IExpenseApprover
    {
        private decimal approvalLimit;
        public string Name { get; set; }

        public ApprovalManager(string name, decimal approvalLimit)
        {
            this.approvalLimit = approvalLimit;
            this.Name = name;
        }

      
        ApprovalResponse IExpenseApprover.ApproveExpense(IExpenseReport expenseReport)
        {
            if (expenseReport.Total <= this.approvalLimit)
            {
                return ApprovalResponse.Approved;
            }
            else
            {
                return ApprovalResponse.BeyondApprovalLimit;
            }
        }

       

    }
}