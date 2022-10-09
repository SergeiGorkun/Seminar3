// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
int result = 1;
int i = 1;

while(i <= N){
    result = result * i;
    i = i + 1;
}

Console.WriteLine(result);
