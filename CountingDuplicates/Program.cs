/*Write a function that will return the count 
 * of distinct case-insensitive alphabetic characters and numeric digits 
 * that occur more than once in the input string. 
 * The input string can be assumed to contain only alphabets 
 * (both uppercase and lowercase) and numeric digits.*/

static int DuplicateCount(string str)
{
    var upperStr=str.ToUpper();
    int i = default;

    while(upperStr.Length>0)
    {
        var length=upperStr.Length;
        var firstSymbol=upperStr[0].ToString();
        upperStr=upperStr.Replace(firstSymbol,string.Empty);
        var newLength=upperStr.Length;
        if (Math.Abs(length-newLength)>1) i++;
    }

    return i;
}

Console.WriteLine(DuplicateCount("AAABBDDFF")); 