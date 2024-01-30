using System;

namespace Larrymax
{
  public class Larrymax
  {
    public static void Main(string[] args)
    {
      
     double first, second, third, fourth, fifth, sixth, seventh, CGPA;
    char option;

      Console.WriteLine($"Enter the score of first subject");
       first = Convert.ToDouble(Console.ReadLine());
       Console.WriteLine($"Enter the score of second subject");
       second = Convert.ToDouble(Console.ReadLine());
       Console.WriteLine($"Enter the score of third subject");
       third = Convert.ToDouble(Console.ReadLine());
       Console.WriteLine($"Enter the score of fourth subject");
       fourth = Convert.ToDouble(Console.ReadLine());
       Console.WriteLine($"Enter the score of fifth subject");
       fifth = Convert.ToDouble(Console.ReadLine());
       Console.WriteLine($"Enter the score of sixth subject");
       sixth = Convert.ToDouble(Console.ReadLine());
       Console.WriteLine($"Enter the score of seventh subject");
       seventh = Convert.ToDouble(Console.ReadLine());
       CGPA = ((first + second + third + fourth + fifth + sixth + seventh) / 7) / 9.5;
       Console.WriteLine($"Your CGPA is=>" + CGPA);

       if (CGPA >= 7)
       {
        option = '1';
       }

       else if (CGPA >= 6.5 && CGPA < 7)
       {
        option = '2';
       }

       else if (CGPA >= 4.5 && CGPA < 6.5)
       {
        option = '3';
       }

       else
       {
        option = 'f';
       }
       switch (option)
       {

        case '1': Console.WriteLine("Grade: first class with distinction"); break;
        case '2': Console.WriteLine("Grade: second class"); break;
        case '3': Console.WriteLine("Grade: third class"); break;
        case 'f': Console.WriteLine("Grade: FAIL"); break;
        default: Console.WriteLine($"INVALID GRADE"); break;
       }
       Console.ReadLine();

       
       
    
       
       
           
    }
  }
}

