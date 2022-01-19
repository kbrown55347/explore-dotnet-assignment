// // Hello World string
// Console.WriteLine("Hello, World!");

// // make a string
// string newString = "Hey, I'm a string!";
// Console.WriteLine(newString);

// // make an number
// int a = 7;
// Console.WriteLine(a);

// // make an array of strings
// string[] words = {"Hi", "I", "come", "from", "an", "array", "of", "strings"};

// // for loop through that array of strings
// for (int i=0; i < words.Length; i++)
// {
//   Console.WriteLine(words[i]);
// }


// // Code Katas

// // 1) Opposites Attract
// using System;

// public class LoveDetector
// {
//   public static bool lovefunc(int flower1, int flower2)
//   {
//     if (flower1 % 2 == 0 && flower2 % 2 == 1)
//     {
//       return true;
//     }
//     else if (flower1 % 2 == 1 && flower2 % 2 == 0)
//     {
//       return true;
//     }
//     else
//     {
//       return false;
//     }
//   }
// }

// // 2) You only need one 
// public class Kata
// {
//   public static bool Check(object[] a, object x)
//   {
//     for (int i=0; i<a.Length; i++)
//       {
//       if (a[i].Equals(x))
//         {
//         return true;
//       }
//     }
//     return false;
//   }
// }

// // 3) Sum of positives

// using System;
// using System.Linq;

// public class Kata
// {
//   public static int PositiveSum(int[] arr)
//   {
//     int sum = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//       if (arr[i] > 0)
//       {
//         sum += arr[i];
//       }
//     }
//     return sum;
//   }
// }