class Prime
{

    //  public static bool IsPrimeNumbers(int number)
    // {
    //     bool returnMsg = false;
    //     for (int i = 2; i <= number; i++)
    //     {
    //         if ((number % i) == 0 && number != i)
    //         {
    //             returnMsg = false;
    //             return returnMsg;
    //         }
    //         else if (number == i)
    //         {
    //             returnMsg = true;
    //             return returnMsg;
    //         }
    //     }
    //     return returnMsg;
    // }

    // public string ParseString(string str)

    // {

    //     bool boolValue;
    //     int intValue;

    //     decimal doubleValue;
    //     DateTime dateValue;


    //     if (bool.TryParse(str, out boolValue))
    //         return "System_Boolean";
    //     else if (int.TryParse(str, out intValue))
    //     {
    //         Console.WriteLine("naresh edhi int ra");
    //         return "System_Int32";
    //     }


    //     else if (decimal.TryParse(str, out doubleValue))
    //         return "System_Decimal";
    //     else if (DateTime.TryParse(str, out dateValue))
    //         return "System_DateTime";
    //     else
    //     {
    //         Console.WriteLine("naresh edhi string ra");
    //         return "System_String";
    //     }


    // }

    // public void RemoveDuplicates(string str)
    // {
    //     string str2 = string.Empty;

    //     for (int i = 0; i < str.Length; i++)
    //     {
    //         if (!str2.Contains(str[i]))
    //         {
    //             str2 += str[i];
    //         }

    //     }
    //     Console.WriteLine($"string{str2}");

    // string resultString = string.Empty;
    // for (int i = 0; i < inputString.Length; i++)
    // {
    //     if (!resultString.Contains(inputString[i]))
    //     {
    //         resultString += inputString[i];
    //     }
    // }
    // Console.WriteLine(resultString);



    public int BinarySearch(int[] arr, int key)
    {
        int min = 0;
        int max = arr.Length - 1;
        while (min <= max)
        {
            int mid = (min + max) / 2;
            if (key == arr[mid])
            {
                return mid;
            }
            else if (key < arr[mid])
            {
                max = mid - 1;
            }
            else
            {
                min = mid + 1;
            }
        }
        return 0;
    }

}


