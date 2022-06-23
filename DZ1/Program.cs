// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a = Input("A: ");
int b = Input("B: ");
int result=1;
for(int i = 0; i< b;i++)
{
    result *=a ;

}
Console.WriteLine("A^B="+result);



int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
