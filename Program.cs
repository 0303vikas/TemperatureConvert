using System;

while (true) {



Console.WriteLine("Please enter a temperature value and its unit of measurement (F or C) :");
string[] temperature = Console.ReadLine().Split(' ');


if(temperature.Length == 0)
{
  Console.WriteLine("InputCannot be empty");
} else if(temperature.Length > 2 || temperature.Length < 2 ) {
  Console.WriteLine("Invalid Input: Format of the String should be of type: 45 F or 45 C");
} else {
  float inputTemperature = float.Parse(temperature[0]);
  var inputTempUnit = temperature[1];

  float result = 0;

  switch(inputTempUnit.ToLower())
  {
    case "c":
    result = TempConvert(inputTemperature, inputTempUnit.ToLower());
    Console.WriteLine("Temperature in F : " + result);
    break;
    case "f":
    result = TempConvert(inputTemperature, inputTempUnit.ToLower());
    Console.WriteLine("Temperature in C : " + result);
    break;
    default:
    Console.WriteLine("Temperature Unit can be either C or F");
    break;
    }
}
}

float TempConvert (float num, string unit) {
  float convertedTemp = 0;
  switch (unit)
  {
    case "c":
    convertedTemp = (((9/5)*num)+32);
    break;
    
    case "f":
    convertedTemp = (num-32)*5/9;    
    break;
  }
  return convertedTemp;
}




