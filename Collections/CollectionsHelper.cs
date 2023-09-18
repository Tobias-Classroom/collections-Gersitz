using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Collections
{
  public static class CollectionsHelper
  {
    public static List<int> AddRandomNumbersToList(List<int> numbers, int quantity)
    {
      for (int i = 0; i < quantity; i++)
      {
        Random rng = new Random();
        numbers.Add(rng.Next());
      }
      return numbers;
    }

    public static (List<int>, string) RemoveElementFromList(List<int> numbers, int element)
    {
      string message = "";
      if (numbers.Contains(element))
      {
        numbers.Remove(element);
        message = $"{element} wurde entfernt.";
      }
      else
      {
        message = "Element nicht gefunden.";
      }
      return (numbers, message);

    }

    public static bool CheckElementInList(List<int> numbers, int element)
    {
      return numbers.Contains(element);
    }

    public static int FindMax(List<int> numbers)
    {
      int max = 0;
      if (numbers.Count == 0)
      {
        return 0;
      }
      else
      {
        foreach (int num in numbers)
        {
          if (num > max)
          {
            max = num;
          }
        }
        return max;
      }

    }
    public static int FindMin(List<int> numbers)
    {
      int min = 0;
      if (numbers.Count == 0)
      {
        return 0;
      }
      else
      {
        foreach (int num in numbers)
        {
          if (num < min)
          {
            min = num;
          }
        }
        return min;
      }
    }

    public static double CalculateAverage(List<int> numbers)
    {
      double sum = 0;
      foreach (double num in numbers)
      {
        sum += num;
      }
      return sum/numbers.Count();
    }

  }
}
