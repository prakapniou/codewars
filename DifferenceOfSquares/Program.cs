/*Find the difference between the square of the sum 
 * of the first n natural numbers (1 <= n <= 100) 
 * and the sum of their squares.*/

static int DifferenceOfSquares(int n)
{

    int sum = default;
    int sumSquare=default;
    int squareSum=default;
    int differenceOfSquares = default;


    for (int i = 1;i<=n;i++)
    {
        sum+=i;
        sumSquare+=i*i;
    }

    squareSum=sum*sum;
    differenceOfSquares=squareSum-sumSquare;

    return differenceOfSquares;
}

Console.WriteLine(DifferenceOfSquares(10));