namespace ClasseSelada.Entities
{  
    // Tentando Soprepor uma classe sealed 
    // Eu Recebo o Erro 
    // 'SavingsAccountPlus': cannot derive from sealed type 'SavingsAccount'CS0509
    // class SavingsAccountPlus : SavingsAccount
    class SavingsAccountPlus
    
    {
        // 'SavingsAccountPlus.Withdraw(double)': no suitable method found to overrideCS0115
        public override void Withdraw(double amount)
        {

        }
    }
}