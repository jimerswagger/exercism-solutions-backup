public static class LineUp
{
    public static string Format(string name, int number)
    {
        char[] cArr;
        string numStr = number.ToString();

        if (numStr.Length < 2) {
            string numStr2 = numStr.Insert(0, "0");
            cArr = numStr2.ToCharArray();
        }
        else {
            cArr = numStr.ToCharArray();    
        }        
        
        if (cArr[cArr.Length - 1] == '1' && cArr[cArr.Length - 2] != '1') {
            Console.WriteLine($"{name}, you are the {number}st customer we serve today. Thank you!");
            return $"{name}, you are the {number}st customer we serve today. Thank you!";
        }
        else if (cArr[cArr.Length - 1] == '2' && cArr[cArr.Length - 2] != '1') {
            Console.WriteLine($"{name}, you are the {number}nd customer we serve today. Thank you!");
            return $"{name}, you are the {number}nd customer we serve today. Thank you!";
        }
        else if (cArr[cArr.Length - 1] == '3' && cArr[cArr.Length - 2] != '1') {
            Console.WriteLine($"{name}, you are the {number}rd customer we serve today. Thank you!");
            return $"{name}, you are the {number}rd customer we serve today. Thank you!";
        }
        else {
            Console.WriteLine($"{name}, you are the {number}th customer we serve today. Thank you!");
            return $"{name}, you are the {number}th customer we serve today. Thank you!";
        }
        
    }
}
