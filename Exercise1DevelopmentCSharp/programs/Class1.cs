public class Class1 {
    public int maxValue;
    public int countString;
    public Class1() {

    }

    public string stringComparison(string word1, string word2) {

        if (word1 == word2) {
            return "the same word";
        } else {
            return "not the same word";
        }

    }

    public void verifyBiggestNumber(int[] numbers) {

        maxValue = numbers[0];
        for (int i = 0; i < numbers.Length; i++) {

            if (numbers[i] > maxValue) {
                maxValue = numbers[i];
            }

        }
        Console.WriteLine("\nThe biggest number of array is: " + maxValue);

    }

    public void sortList(string[] words) {
        
        Array.Sort(words);
        Console.WriteLine("\nThe words sort by asc are:");
        foreach (string word in words) {
            Console.Write(word + " ");
        }

        Array.Reverse(words);
        Console.WriteLine("\n\nThe words sort by desc are:");
        foreach (string word in words) {
            Console.Write(word + " ");
        }

    }

    public int countStringLength(string word) {

        return countString = word.Length;
        
    }
}