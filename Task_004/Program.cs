// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число 1");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2 ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3 ");
int c = Convert.ToInt32(Console.ReadLine());

if( a > b && a > c){
    Console.Write("Max = " + a);
}
else if(b > c) {
    Console.Write("Max = " + b);
}
else{
    Console.Write("Max = " + c);
}