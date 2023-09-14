public class Reverse
{
    public static string Reversename()
    {

        Console.WriteLine("ENTER NAME");
        string firstname = Console.ReadLine();
        string secondname = "";
        for (int i = firstname.Length - 1; i >= 0; i--)
        {
            secondname += firstname[i];
        }
        // Console.WriteLine(secondname);
        return secondname;

        // Console.Write("Enter a String : ");
        // string originalString = Console.ReadLine();
        // string reverseString = string.Empty;
        // for (int i = originalString.Length - 1; i >= 0; i--)
        // {
        //     reverseString += originalString[i];
        // }
        // return reverseString;



    }
}