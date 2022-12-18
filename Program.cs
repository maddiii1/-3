//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. Не использовать String!
//14212 -> нет
//12821 -> да
//23432 -> да
/*
int number;
void five (int number){


if( number/10000 == number%10 && (number/1000)%10 == (number%100)/10){
    Console.Write("Это палиндром");
}
else{
    Console.Write("Это не палиндром");
}
}

Console.Write("Введите пятизначное число: ");
number = Convert.ToInt32(Console.ReadLine());
five(number);
*/

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
/*
double InputInt (){
    Console.WriteLine("Введите число: ");
    bool isNum = double.TryParse(Console.ReadLine(), out double num);
    if(isNum){
        return num;
    }
    else{
        Console.WriteLine("Вы ввели некорректное значение:)");
        return -1;
    }
}

double x1 = InputInt();
double y1 = InputInt();
double z1 = InputInt();
double x2 = InputInt();
double y2 = InputInt();
double z2 = InputInt();

double GetDistance(double x1, double y1, double z1, double x2, double y2, double z2){
    double AB = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1));
    return AB;
}

double res = GetDistance(x1,y1,z1,x2,y2,z2);
Console.WriteLine(res);
*/

//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. Задание должно быть выполнено в методе и метод должен вернуть массив чисел.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
/*
int InputInt()
{
    Console.WriteLine("Введите целое число: ");
    bool  isNum = int.TryParse(Console.ReadLine(), out int num);
    if(isNum)
    {
        return num;
    }
    else
    {
      Console.WriteLine("Вы ввели некорректное значение");
      return -1;
    }
}

int num = InputInt();

int[] GetTableOfCubes(int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = (int)(Math.Pow(i+1, 3));
    }
return arr;
}

int[] CubesTable = GetTableOfCubes(num);

void PrintArray (int[] arr){
    for (int i = 0; i < arr.Length; i++){
        Console.WriteLine(arr[i]);
    }
}
PrintArray(CubesTable);
*/
