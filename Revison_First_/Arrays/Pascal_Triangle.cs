
namespace Revison_First_.Arrays;

public class Pascal_Triangle
{

    public static int PacalTriangle(int a,int c)
    {
        {
            int r = a;
            int k = c;

            int n = r - 1;
            int m = k - 1;

            int result = 1;

            for (int i = 0; i < k; i++)
            {
                result = result * (n - i);
                result = result / (i + 1);
            }
            return result;
        }
    }
}
