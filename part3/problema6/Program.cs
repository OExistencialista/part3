class Program{
    static void Main(){
        Console.Write("taxa: ");
        double taxa = Convert.ToDouble(Console.ReadLine());
        Console.Write("Valor Inicial: ");
        double valorInicial = Convert.ToDouble(Console.ReadLine());
        Console.Write("Periodo: ");
        double periodo = Convert.ToDouble(Console.ReadLine());
        double valorFinal = valorInicial * Math.Pow((1+taxa/100), periodo);
        Console.Clear();
        Console.WriteLine($"Valor Final : {valorFinal:F2}");
        Console.WriteLine($"Taxa: {taxa:F2}");
        Console.WriteLine($"Valor Inicial : {valorInicial:F2}");
        Console.WriteLine($"Periodo : {periodo:F2}");
    }
}