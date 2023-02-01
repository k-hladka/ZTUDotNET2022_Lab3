using String.ClassesExtensions;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Інвертування рядка: ");
Console.ResetColor();

string str = "Британські пушистики схожі на плюшевих ведмежат. Це компактні і при цьому потужні коти.";
Console.WriteLine(str.Invert());

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Підрахунок кількості входжень символа 'і' в рядок: ");
Console.ResetColor();

Console.WriteLine(str.CountChar('і'));
