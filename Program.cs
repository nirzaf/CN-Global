using System;

public static class MathProblem{

//find all numbers and add into array from a string input
public static int[] FindNumbers(string input){
  int[] numbers = new int[input.Length];
  for(int i = 0; i < input.Length; i++){
    numbers[i] = int.Parse(input[i].ToString());
  }
  return numbers;
}

}
