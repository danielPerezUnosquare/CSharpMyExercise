public class ClassB : ClassA, Interface1 {
    public void printBooleans(string word1, string word2, List<string> numberList1, List<string> numberList2) {
        Console.WriteLine("\nDo the strings have the same lenght? " + compareStringsLenght(word1, word2));
        Console.WriteLine("\nDo the lists have the same lenght? " + compareListLenght(numberList1, numberList2));
    }

    public void printMessage() {
        Console.WriteLine("\nHello Interface");
    }

    public void orderListStrings(string orderType, List<string> words) {
        if (orderType == "asc") {

            words.Sort();
            words.RemoveAll(s => string.IsNullOrWhiteSpace(s));

            Console.WriteLine("\nThe list order by asc is:");
            foreach(string word in words) {
                Console.Write(word + ", ");
            }
            
        } else if (orderType == "desc") {

            words.Sort();
            words.Reverse();
            words.RemoveAll(s => string.IsNullOrWhiteSpace(s));

            Console.WriteLine("\nThe list order by desc is:");
            foreach(string word in words) {
                Console.Write(word + ", ");
            }

        } else {

            Console.WriteLine("\nNo valid order type specified.");

        }
    }

    public void filterListStrings(string filter, List<string> words) {
        if (filter == " ") {

            Console.WriteLine("\n\nCannot filter with that argument.");

        } else {
            
            List<string> filterWords = new List<string>();
            foreach (string word in words) {
                if (word.Contains(filter)) {
                    filterWords.Add(word);
                }
            }
            
            filterWords.RemoveAll(s => string.IsNullOrWhiteSpace(s));
            
            Console.WriteLine("\n\nThe list of strings with " + filter + " as a filter is:");
            
            foreach(string word in filterWords) {
                Console.Write(word + ", ");
            }

        }
    }

    public void removeDuplicateNumbers(List<int> numbers) {
        List<int> filterNumbers = numbers.Distinct().ToList();
        Console.WriteLine("\n\nThe new list without duplicates is:");
        
        foreach(int number in filterNumbers) {
            Console.Write(number + ", ");
        }
    }
}