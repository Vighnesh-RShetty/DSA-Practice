
namespace Revison_First_.Arrays;

public class Longest_CosecutiveSequence
{
    public static int LongestSequenceInArray(int[] arr)
    {
        HashSet<int> set = new HashSet<int>(arr);
        int current = 0;
        int maxLength = 0;
        

        foreach (int ele in set)
        {
            if (!set.Contains(ele - 1))
            {
                current = ele;
                int length = 1;
                while (set.Contains(current + 1))
                {
                    length++;
                    current++;
                }
                if (length > maxLength) maxLength = length;
            }
        }
        return maxLength;
    }
}
