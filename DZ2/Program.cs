﻿// See https://aka.ms/new-console-template for more information

int nu = new Random().Next(100,1000);
Console.WriteLine(nu);
int index = 1;
int result = 0;
while(nu > 0)
{
    int n = nu % 10;
    result+=n;
    index ++; 
    nu = nu / 10;
}
Console.WriteLine($"Ответ {result}"); 
