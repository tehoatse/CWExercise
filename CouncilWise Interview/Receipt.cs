using System.Collections.Generic;
using System.Text;

namespace CouncilWise
{
    internal class Receipt
    {
        public ICollection<ReceiptItem> Items { get; set; }
        public decimal Total 
        { 
            get
            {
                decimal total = 0;
                foreach(var item in Items)
                {
                    total += item.LineTotal;
                }

                return total;
            }
        }
        public decimal TaxTotal 
        {
            get => (Total / Helper.TaxDivisor).CurrencyRound();
        }

        public Receipt(ICollection<ReceiptItem> items)
        {
            Items = items;
        }

        public override string ToString()
        {
            string outputString = $"\nReceipt:\n\tItems";
            foreach(var item in Items)
            {
                outputString += item.ToString(); 
            }

            outputString += $"\n\nTotal:\t{Total}\nGST:\t{TaxTotal}";
            return outputString;
        }

    }
}
