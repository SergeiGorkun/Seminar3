// Подсчитать сумму цифр в числе
Console.WriteLine("Введите число");
int Number = int.Parse(Console.ReadLine());
int Sum = 0;

while(Number > 0){
    Sum = Sum + Number % 10;
    Number = Number/10;
}
Console.WriteLine("Ответ  " + Sum);