Console.WriteLine("Задача 19");
Console.Write("Введите число пятизначное: ");
string? number = Console.ReadLine();

void CheckingNumber(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"Ваше число пятизначное: {number} - палиндром.");
  }
  else Console.WriteLine($"Ваше число пятизначное: {number} - НЕ палиндром.");
}

if (number!.Length == 5){
  CheckingNumber(number);
}
else Console.WriteLine("Введи правильное число");