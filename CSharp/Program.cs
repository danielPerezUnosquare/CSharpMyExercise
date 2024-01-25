Class1 class1 = new Class1();

string word1 = "example";
string word2 = "exampl";
int[] numbersArray = {10, 12, 3, 54, 15};
string[] stringsArray = {"h", "a", "j", "d", "m"};
string word = "Hello";

string areEquals = class1.stringComparison(word1, word2);
Console.WriteLine(String.Format("The {0} and {1} are {2}", word1, word2, areEquals));

class1.verifyBiggestNumber(numbersArray);

class1.sortList(stringsArray);

Console.WriteLine(string.Format("\n\nThe word {0} has {1} of length.\n", word, class1.countStringLength(word)));

Class2 class2 = new Class2();

List<int> numbers = new List<int>();
for (int i = 1; i < 9; i++) {
    numbers.Add(i+3);
}
class2.printFirstFiveValues(numbers);

class2.printSmallestNumber(numbersArray);

class2.printDictionary();