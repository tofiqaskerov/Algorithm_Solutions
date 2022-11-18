


//task_1 ----------------------------------------

/*
     Complete the solution so that it reverses the string passed into it.
*/


//static string Solution(string str)
//{
//    char[] arr = str.ToCharArray();

//    Array.Reverse(arr);
//    return new string(arr);
//}



// task_2  --------------------------------------

/*
 Your goal is to return multiplication table for number that is always an integer from 1 to 10.
*/

//string MultiTable(int number)
//{
//    int result = 0;
//    var str = "";
//    for (int i = 1; i <= 10; i++)
//    {
//        result = i * number;
//        str += $"{i} * {number} = {result}";
//        if (i < 10)
//            str += "\n";
//    }
//    return str;
//}




// task_3 -----------------------------------------

/*
 *The function should return true if you are employed and not on vacation (because these are the circumstances under which you need to set an alarm). 
 */


// bool SetAlarm(bool employed, bool vacation)
//{
//    if (employed && !vacation)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}



// task_4 ------------------------------------------

/*
 You get an array of numbers, return the sum of all of the positives ones.
*/



// int PositiveSum(int[] arr)
//{
//    int num = 0;
//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] > 0)
//        {
//            num += arr[i];
//        }
//    }
//    return num;
//}



// task_5 --------------------------------------------

/*
    Welcome. In this kata, you are asked to square every digit of a number and concatenate them.
    For example, if we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1.
 */


// int SquareDigits(int n)
//{
//    char[] numbers = n.ToString().ToArray();
//    string result = "";
//    for (int i = 0; i < numbers.Length; i++)
//    {
//        result += Math.Pow(Convert.ToInt32(numbers[i].ToString()), 2);
//    }
//    return Convert.ToInt32(result);
//}



// task_6 ---------------------------------------------


/*
   Given a list of integers, determine whether the sum of its elements is odd or even.
 */



// string OddOrEven(int[] array)
//{
//    var arrayRtn = array.Sum() % 2 == 0 ? "even" : "odd";
//    return arrayRtn;
//}




// task_7 ----------------------------------------------


/*
    Create a function that takes 2 integers in form of a string as an input, and outputs the sum (also as a string)   
*/



//string StringsSum(string s1, string s2)
//{
//    int a = 0;
//    int b = 0;
//    if (s1 != "")
//    {
//        a = Convert.ToInt32(s1);
//    }
//    if (s2 != "")
//    {
//        b = Convert.ToInt32(s2);
//    }
//    var sum = (a + b).ToString();
//    return sum;
//}




// task_8 ------------------------------------------------



/*
   If a name has exactly 4 letters in it, you can be sure that it has to be a friend of yours! Otherwise, you can be sure he's not...
    Ex: Input = ["Ryan", "Kieran", "Jason", "Yous"], Output = ["Ryan", "Yous"]
*/


//IEnumerable<string> FriendOrFoe(string[] names)
//{
//    List<string> friends = new List<string>();
//    foreach (var friend in names)
//    {
//        if (friend.Length == 4) friends.Add(friend);   
//    }
//    return friends;

//}


// task_9 ------------------------------------------------

/*
   In this kata you will create a function that takes a list of non-negative integers and strings and returns a new list with the strings filtered out. 
*/



//IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
//{
//    List<int> list = new List<int>();
//    foreach (var obj in listOfItems)
//    {
//        if (obj.GetType() == typeof(int))  list.Add((int)obj);
//    }
//    return list;        
//}


// task_10 ------------------------------------------------

/*
   How many times will he find each of the 3 numbers entered; 
*/


   //int[] numbers = new int[3];
   //for(int i = 0; i < numbers.Length; i++)
   //{
   //    Console.WriteLine($"{i+1} reqem daxil edin:");
   //    numbers[i] = Convert.ToInt32(Console.ReadLine());
   //}     
   //Random rnd = new Random();
   //int random = rnd.Next(10);
   //for (int i = 0; i < numbers.Length; i++)
   //{
   //    int counter = 0;
   //    while(true)
   //    {
   //        counter++;  
   //        random = rnd.Next(10);
   //        if (random == numbers[i])
   //        {
   //            break;
   //        }
   //    }
   //    Console.WriteLine($"{numbers[i]} reqemi {counter} defeye tapildi ");
   //}
 



// task_11 ------------------------------------------------
     
/*
   There is an array with some numbers. All numbers are equal except for one. Try to find it!
*/



//int GetUnique(IEnumerable<int> numbers)
//{
//    return numbers.GroupBy(x => x).Where(x => x.Count() == 1).SelectMany(x => x).First();
//}



// task_12 ------------------------------------------------


/*
     Given a non-empty array of integers, return the result of multiplying the values together in order
*/


// int Grow(int[] x)
//{
//    var result = 1;
//    for (var i = 0; i < x.Length; i++)
//    {
//        result *= x[i];
//    }
//    return result;
//}



// task_13 -------------------------------------------



/*
    Implement the function which takes an array containing the names of people that like an item. It must return the display text as shown in the examples:
*/


//string Likes(string[] name)
//{
//    if (name.Length == 0)
//    {
//        return "no one likes this";
//    }
//    else if (name.Length == 1)
//    {
//        return name[0] + " likes this";
//    }
//    else if (name.Length == 2)
//    {
//        return name[0] + " and " + name[1] + " like this";
//    }
//    else if (name.Length == 3)
//    {
//        return name[0] + ", " + name[1] + " and " + name[2] + " like this";
//    }
//    else
//    {
//        return name[0] + ", " + name[1] + " and " + (name.Length - 2) + " others like this";
//    }

//}




// task_14 -------------------------------------------


/*
    Given an array of integers, remove the smallest value. Do not mutate the original array/list. If there are multiple elements with the same value, remove the one with a lower index. If you get an empty array/list, return an empty array/list.
*/



// List<int> RemoveSmallest(List<int> numbers)
//{
//    if (numbers.Count == 0 || numbers == null)
//        return numbers;
//    List<int> newNumbers = numbers.ToList();
//    newNumbers.Remove(newNumbers.Min());
//    return newNumbers;

//}




// task_15 -------------------------------------------


/*
   Sort the odd numbers in ascending order, keeping the even numbers 
*/



//   int[] arr = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
//   List<int> odd = new();
//   List<int> result = new();
//   for (int i = 0; i < arr.Length; i++)
//   {
//       if(arr[i] % 2 != 0) odd.Add(arr[i]);
//   }
//   var sortOdd = odd.OrderBy(i => i);
//   int skipCount=0;
//   for (int i = 0; i < arr.Length; i++)
//   {
//    if (arr[i] % 2 != 0)
//    {
//        for (int j = 0; j < 1; j++)
//        {
//            var findOdd = sortOdd.Skip(skipCount).FirstOrDefault();
//            result.Add(findOdd);
//            skipCount++;
//        }
//    }
//    else
//    {
//        result.Add(arr[i]);
//    }
// }
//    foreach (var i in result)
//    {
//        Console.WriteLine(i);
//    }








