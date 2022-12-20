Console.Write("Введите элементы массива: ");
int[] s = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.WriteLine();
Console.WriteLine($"[{String.Join(", ",s)}]"); 
int count =0;
for (int i = 0;  i < s.Length; i++)
{
    if (s[i] > 0)
     {
        count = count + 1;
     }
}
Console.WriteLine("Количество чисел введённых пользователем, значения которых больше нуля равно:" + " " + count);
