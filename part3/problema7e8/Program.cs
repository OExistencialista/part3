class Program
{
    static void Main()
    {
        Console.Write("taxa: ");
        double taxa = Convert.ToDouble(Console.ReadLine())/100;
        Console.Write("Valor Inicial: ");
        double valorInicial = Convert.ToDouble(Console.ReadLine());
        Console.Write("Valor do saque: ");
        double saque = Convert.ToDouble(Console.ReadLine());
        Console.Write("Periodo: ");
        int periodo = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite a date do saque se existir: ");
        int mesRegaste  = Convert.ToInt32(Console.ReadLine());

        
        
        
        for (int i = 1; i <= periodo; i++)
        {
            valorInicial = juroscompostos(valorInicial, taxa, 1);
            double mensal =valorInicial - juroscompostos(valorInicial, -taxa, 1);
            if(i == mesRegaste){ valorInicial-= saque;
            
            }


            Console.WriteLine(
            $" {i} |".PadLeft(7, ' ') +
            $"{mensal:F2} |".PadLeft(19, ' ') +
            $"{valorInicial:F2} | ".PadLeft(19, ' ') +((i==mesRegaste)? $"resgate: -{saque}": "")
             );
             
        }

        static double juroscompostos(double valor, double taxa, int periodo){
            return valor * Math.Pow(taxa+1, periodo);
        }
    }
}