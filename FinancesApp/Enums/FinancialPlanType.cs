using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances_Control_App.Domain.FinancesApp.Enums
{
    /// <summary>
    /// Represents the type of a financial plan based on its recurrence.
    /// </summary>
    public enum FinancialPlanType
    {
        /// <summary>
        /// Represents a weekly financial plan.
        /// </summary>
        Weekly = 0,

        /// <summary>
        /// Represents a monthly financial plan.
        /// </summary>
        Monthly = 1
    }
}
