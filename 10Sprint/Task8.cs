public enum InvoiceType
    {
        Final,
        Proposed
    };
    class Invoice
    {
        public InvoiceType InvoiceType { get; set; }
        public double GetDiscount(double amount)
        {
            double finalAmount = 0;
            if (InvoiceType == InvoiceType.Final)
            {
                finalAmount = amount - amount * 0.03;
            }
            else if (InvoiceType == InvoiceType.Proposed)
            {
                finalAmount = amount - amount * 0.05;
            }

            return finalAmount;
        }
    }
    class FinalInvoice : Invoice
    {

        public double GetDiscount(double amount)
        {
            double finalAmount = 0;
            if (InvoiceType == InvoiceType.Final)
            {
                finalAmount = amount - amount * 0.03;
            }
            else if (InvoiceType == InvoiceType.Proposed)
            {
                finalAmount = amount - amount * 0.05;
            }

            return finalAmount;
        }
    }
    class ProposedInvoice : Invoice
    {

        public double GetDiscount(double amount)
        {
            double finalAmount = 0;
            if (InvoiceType == InvoiceType.Final)
            {
                finalAmount = amount - amount * 0.05;
            }
            else if (InvoiceType == InvoiceType.Proposed)
            {
                finalAmount = amount - amount * 0.05;
            }

            return finalAmount;
        }
    }
    class RecurringInvoice : Invoice
    {

        public double GetDiscount(double amount)
        {
            double finalAmount = 0;
            if (InvoiceType == InvoiceType.Final)
            {
                finalAmount = amount - amount * 0.1;
            }
            else if (InvoiceType == InvoiceType.Proposed)
            {
                finalAmount = amount - amount * 0.05;
            }

            return finalAmount;
        }
    }
    class OrdinaryInvoice : Invoice
    {

        public double GetDiscount(double amount)
        {
            double finalAmount = 0;
            if (InvoiceType == InvoiceType.Final)
            {
                finalAmount = amount - amount * 0.01;
            }
            else if (InvoiceType == InvoiceType.Proposed)
            {
                finalAmount = amount - amount * 0.05;
            }

            return finalAmount;
        }
    }
