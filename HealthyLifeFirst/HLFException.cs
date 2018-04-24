using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyLifeFirst
{
    class HLFException : ApplicationException
    {
        public HLFException() 
            : base() {}

        public HLFException(string message) 
            : base(message) {}

        public HLFException(string message, Exception innerExc)
            : base(message, innerExc){}
    }
    class HLFMsg
    {
        public const String GeneralErrorMsg
            = "There has been an unexpected error, " +
            "please contact helpdesk for assistance.";

        // Class_Item
        public const String AddItemOKMsg
            = "Added item successfully.";
        public const String AddItemNGMsg
            = "Failed to add item. " +
            "Please check and try again.";
        public const String FindItemNGMsg
            = "Failed to find item. " +
            "Please check and try again.";
        public const String UpdateItemOKMsg
            = "Updated item successfully.";
        public const String UpdateItemNGMsg
            = "Failed to update item. " +
            "Please check and try again.";
        public const String RemoveItemOKMsg
            = "Removed item successfully.";
        public const String RemoveItemNGMsg
            = "Failed to remove item. " +
            "Please check and try again.";
    }
}
