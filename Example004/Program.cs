// Показать кубы чисел, заканчивающихся на четную цифру
string [] arr = {"233", "212", "452", "115", "266", "232"};
int i = 0;

while(i < arr.Length) {
    string str = arr[i];
    int number = Convert.ToInt32(str[str.Length - 1]);
    if(number % 2 == 0) {
        double res = Math.Pow(Convert.ToInt32(str), 3);
        Console.WriteLine(res);
    }
    i++;
}