public class Class2 {
    public int minValue;
    public Dictionary<int, string> dic;
    public Class2() {

    }

    public void printFirstFiveValues(List<int> numbers) {

        for (int i = 0; i < 5; i++) {
            Console.WriteLine(String.Format("The value in {0} position is {1}", i + 1, numbers[i]));
        }

    }

    public void printSmallestNumber(int[] numbers) {

        minValue = numbers[0];
        for (int i = 0; i < numbers.Length; i++) {

            if (numbers[i] < minValue) {
                minValue = numbers[i];
            }

        }
        Console.WriteLine(string.Format("\nThe smallest number of array is {0}\n", minValue));

    }

    public void printDictionary() {

        dic = new Dictionary<int, string>();
        dic.Add(1, "hey");
        dic.Add(2, "hi");
        dic.Add(3, "hello");

        foreach (KeyValuePair<int, string> d in dic) {
            Console.WriteLine(String.Format("Key = {0}, Value = {1}", d.Key, d.Value));
        }

    }
}