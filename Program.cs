/** Ze specjanlną dedykacją dla mojego ASA, mam nadzieję że Ta aplikacja będzie przydatna - p65 **/
using static System.Console;
class Program
{
    static void Main(string[] args)
    {
        string[] s = { "/--%--\\", "|  |  |", "\\  |  /", "       " };
        decimal czlon_mm;
        do
        {
            WriteLine("Podaj długość swojego członka:");
            czlon_mm = decimal.Parse(ReadLine());
            WriteLine();
            WriteLine("WOW!!! SUCH A MEMBER! Ma " + czlon_mm / 10 + " cm i wygląda naprawdę pokaźnie:");
            WriteLine(s[3] + s[0] + s[3]);
            WriteLine(s[3] + s[1] + s[3]);
            WriteLine(s[3] + s[2] + s[3]);
            for (int i = 1; i < czlon_mm / 10; i++)
            {
                WriteLine(s[3] + s[1]);
            }
            WriteLine(s[0] + s[1] + s[0]);
            WriteLine(s[1] + s[1] + s[1]);
            WriteLine(s[0] + s[0] + s[0]);
            ReadLine();
        } while (czlon_mm > 0);
    }
}