// Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.WriteLine("Enter a number from 1 to 7");
int number = Convert.ToInt32(Console.ReadLine());

void weekends(int num)
{
   if (num > 0 && num < 8)
   {
      if (num == 6 || num == 7)
      {
         Console.WriteLine("Yippee! It's a weekend :)"); 
      }
      else 
      {
         Console.WriteLine("Oh no! It's a working day :("); 
      }
   }
   else 
   {
      Console.WriteLine("You entered an invalid number. Enter a number from 1 to 7"); 
   }
}
   
weekends(number);

