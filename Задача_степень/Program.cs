double a;
double Stepen;
Console.WriteLine("Введите число  ");
a = Convert.ToDouble(Console.ReadLine());
if(a==0)
{
    Console.WriteLine("Нельзя делить на ноль");
}
Stepen = 1/a; //double pow = Math.Pow(a,-1); 
Console.WriteLine(Stepen);

          
