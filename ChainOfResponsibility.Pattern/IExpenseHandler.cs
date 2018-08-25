using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Pattern
{
    interface IExpenseHandler
    {
        ApprovalResponse Approve(IExpenseReport expenseReport, ref string approval);
        void RegisterNext(IExpenseHandler next);
    }

    class ExpenseHandler : IExpenseHandler
    {
        public ExpenseHandler(IExpenseApprover expenseApprover)
        {
            _approver = expenseApprover;
            _next = EndOfChainExpenseHandler.Instance;
        }

        public ApprovalResponse Approve(IExpenseReport expenseReport, ref string approval)
        {
            ApprovalResponse response = _approver.ApproveExpense(expenseReport);

            if (response == ApprovalResponse.BeyondApprovalLimit)
            {
                return _next.Approve(expenseReport, ref approval);
            }

            approval = _approver.Name;
            return response;
        }

        public void RegisterNext(IExpenseHandler next)
        {
            _next = next;
        }


        private readonly IExpenseApprover _approver;
        private IExpenseHandler _next;
    }
}
