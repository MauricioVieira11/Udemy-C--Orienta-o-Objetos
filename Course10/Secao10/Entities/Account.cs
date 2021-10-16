

namespace Secao10HErancaPolimorfsmo.Entities
{
    class Account
    {
        public int Number { get; private set; } //'private' possibilita o acesso, mas não a modificação
        public string Holder { get; private set; }
        public double Balance { get; protected set; } //protected pode modificar o saldo da classe e as subclasses

        public Account() //construtor padrão
        {

        }

        public Account(int number, string holder, double balance) //Construtor com os argumentos
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void WithDraw(double amount) //Saque
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount) //Depósito
        {
            Balance += amount;
        }

    }
}
