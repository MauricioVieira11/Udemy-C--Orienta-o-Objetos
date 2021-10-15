
namespace Secao10HErancaPolimorfsmo.Entities
{
    class SavingsAccount : Account //A classe Savings Account herda tudo que a classe Account tem
    {
        public double InterestRate { get; set; }

        
        
        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate):base(number, holder, balance)//construtor com artumentos
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {              //método que atualiza o saldo da conta baseado na taxa de juros

            Balance += Balance * InterestRate;
        }
    }
}
