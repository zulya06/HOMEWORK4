﻿//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());

  int SumNum(int numN){
    
    int counter = Convert.ToString(numN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = numN - numN % 10;
      result = result + (numN - advance);
      numN = numN / 10;
    }
   return result;
  }

int sumNumber = SumNum(numN);
Console.WriteLine("Сумма цифр в числе: " + SumNum);