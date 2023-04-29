// Escreva um algoritmo que determine o número de dias que uma pessoa já viveu. 
// Para isso o usuário deverá informar apenas a sua data de nascimento. 
// Considere que cada mês tenha
// 30 dias e o ano tenha 360 dias.

internal class Program
{
    private static void Main()
    {
        int dias, meses, anos;
        int diasnoano, diasnomes;

        Console.Write("Diga sua idade: ");
        anos = int.Parse(Console.ReadLine());
        Console.Write("Mês do seu aniversário: ");
        meses = int.Parse(Console.ReadLine());
        Console.Write("Dia do seu aniversário: ");
        dias = int.Parse(Console.ReadLine());

        diasnoano = 360;
        diasnomes = 30;

        dias = anos * diasnoano + meses * diasnomes + dias;

         Console.WriteLine($"Sua idade em dias é: {dias}");
    }

}
