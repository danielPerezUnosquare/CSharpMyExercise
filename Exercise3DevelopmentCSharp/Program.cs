ClassB classB = new ClassB();

string word1 = "hey";
string word2 = "hey";

List<string> words1 = new List<string>{ "Text", "Computer", "Automation", "Visual Studio", "Auto Parts", " " };
List<string> words2 = new List<string>{ "hey", "not", "are", "is", "was", "were" };

List<int> numbers = new List<int>{ 1, 1, 2, 3, 4, 4, 5, 6, 7, 8, 10 };

classB.printBooleans(word1, word2, words1, words2);

classB.printMessage();

classB.orderListStrings("asc", words1);

classB.filterListStrings("om", words1);

classB.removeDuplicateNumbers(numbers);