using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Pattern
{
    public class EndOfChainExpenseHandler : IExpenseHandler
    {
        private EndOfChainExpenseHandler()
        {
            
        }
        internal static IExpenseHandler Instance
        {
            get { return _instance; }
        }

        ApprovalResponse IExpenseHandler.Approve(IExpenseReport expenseReport, ref string approver)
        {
            approver = "None";
            return ApprovalResponse.Denied;
        }
        

        void IExpenseHandler.RegisterNext(IExpenseHandler next)
        {
            throw new InvalidOperationException("End of chain handler must be the end of the chain!");
        }

        private static readonly EndOfChainExpenseHandler _instance = new EndOfChainExpenseHandler();
    }
}
