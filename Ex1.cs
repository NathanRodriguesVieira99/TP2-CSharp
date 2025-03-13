

class Ex1
{
    static void Main()
    {
        Console.WriteLine("Informe sua data de nascimento: ");


        string dataInformada = Console.ReadLine();

        if (DateTime.TryParse(dataInformada, out DateTime dataNascimento))
        {
            DateTime dataAtual = DateTime.Today;

            int anos = dataAtual.Year - dataNascimento.Year;
            int meses = dataAtual.Month - dataNascimento.Month;
            int dias = dataAtual.Day - dataNascimento.Day;

            if (dias < 0)
            {
                meses--;
                dias += DateTime.DaysInMonth(dataAtual.Year, dataAtual.Month);
            }
            if (meses < 0)
            {
                anos--;
                meses += 12;
            }
            Console.WriteLine($"Sua idade é {anos} anos, {meses} meses e {dias} dias");
        }
        else
        {
            Console.WriteLine("Data informada invalida");
        }
    }
}



