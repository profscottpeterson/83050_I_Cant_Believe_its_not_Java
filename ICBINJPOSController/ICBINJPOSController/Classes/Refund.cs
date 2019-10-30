using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICBINJPOSController
{
    public class Refund
    {
        // Should we make this an interface?
        public Transaction FindTransaction(int transNum)
        {
            Transaction Trans2Refund = null;
            return Trans2Refund;
        }

        public Transaction DisplayTransaction(int transNum)
        {
            Transaction Trans2Display = null;
            return Trans2Display;

        }

        // Should we select an item for refund off the trans, or just select a drink from
        // the register screen to refund?
        public Item SelectItem(int ItemNum)
        {
            // Find the item to refund by item number.
            Item selectedItem = null;
            return selectedItem;
        }

        public void ReportRefund()
        {
            // Report refund.
        }
    }
}
