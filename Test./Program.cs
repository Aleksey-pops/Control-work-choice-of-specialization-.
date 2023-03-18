

// string[] message = {"123", "23", "hello", "world", "res"};
// string[] message = {"hello", "2", "world", ":_)"};
// string[] message = {"1234", "1567", "-2", "computer science"};
string[] message = {"Russia", "Denmarrk", "Kazan"};
  for (int i = 0; i < message.Length; i++)
  {  
    int j=0;
      foreach (var item in message[i])
      {
        System.Console.Write(item );
        j++;
      }  
      System.Console.Write($"\t Количество символов в строке массива: ({j})");
          if (j <= 3)
          System.Console.WriteLine($"\tУсловие выполняется массив меньше или равен 3. Массив: {message[i]}");
          else
          System.Console.WriteLine($"\tУсловие не выполнено. Массив имеет более трех символов");
      System.Console.WriteLine();
  }
