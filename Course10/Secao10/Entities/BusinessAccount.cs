using Secao10HErancaPolimorfsmo.Entities;

namespace Secao10HErancaPolimorfsmo.Entities
{
    class BusinessAccount : Account //BusinessAcount herda tudo que a classe Account tem
    {
        public double LoanLimit { get; set; }

        public BusinessAccount() // construtor padrão. cria objetos sem passar os dados
        {

        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance) //aproveita os construtores da classe Acount
        {
            
            LoanLimit = loanLimit;
        }

        public void Loan(double amount) //empréstimo
        {
            if(amount <= LoanLimit)
            {
                Balance += amount;
            }
            
        }
    }
}
