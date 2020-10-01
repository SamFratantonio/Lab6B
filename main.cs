using System;

class MainClass {
  public static void BMIResults(double BMI)
  {
    if (BMI < 18.5) {Console.WriteLine("Underweight");}
    else if ((BMI >= 18.5) && (BMI < 25)) {Console.WriteLine("Normal");}
    else if ((BMI >= 25) && (BMI < 30)) {Console.WriteLine("Overweight");}
    else {Console.WriteLine("Obese");}
  }
  public static void Main (string[] args) 
  {
    for (int x = 0; x < 10; x++)
    {
      Console.Write("Enter Your Height: ");
      double height = double.Parse(Console.ReadLine());
      Console.Write("Enter Your Weight: ");
      double weight = double.Parse(Console.ReadLine());
      BMIResults((weight * 703)/(height * height));
    }
  }
}