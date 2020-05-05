namespace Class08
{
    public class BankAccount
    {
        public string BankName { get; set; }
        public string PersonName { get; set; }
        public float Amount { get; set; }
        public string Number { get; set; }

        public BankAccount(string bankName, string personName, float amount, string number)
        {
            BankName = bankName;
            PersonName = personName;
            Amount = amount;
            Number = number;
        }

        public BankAccount()
        {
            
        }
    }
}
