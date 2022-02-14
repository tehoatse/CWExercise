using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouncilWise
{
    internal class ReceiptItem
    {
        private const decimal PALINDROME_PRICE = 0;
        private decimal _unitPrice;
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice
        {
            get
            {
                if (Helper.IsPalindrome(Name))
                {
                    return PALINDROME_PRICE; // palindromes shop for free
                }
                return _unitPrice;
            }
            set => _unitPrice = value;
        }
        public bool IncludesTax { get; set; }
        public decimal TaxAmount
        {
            get
            {
                if (IncludesTax)
                {
                    return 0;
                }

                return (UnitPrice * Quantity * Helper.TaxRate).CurrencyRound();
            }
        }

        public decimal LineTotal
        {
            get => Quantity * UnitPrice + TaxAmount;
        }

        public override string ToString()
        {
            return $"\n\t{Name}\n\t\t{Quantity}\t{UnitPrice}\t{LineTotal}";
        }


    }
}
