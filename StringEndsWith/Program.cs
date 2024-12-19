/*Complete the solution so that it returns
 * true if the first argument(string) passed in ends 
 * with the 2nd argument (also a string).*/

static bool Solution(string str, string ending)=>str.EndsWith(ending);

Console.WriteLine(Solution("abc","bc"));