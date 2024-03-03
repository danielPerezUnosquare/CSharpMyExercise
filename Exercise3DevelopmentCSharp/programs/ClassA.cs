public class ClassA {
    public bool compareStringsLenght(string word1, string word2) {
        bool _sameLenght = false;

        if (word1.Length == word2.Length) {
            _sameLenght = true;
        }

        return _sameLenght;
    }

    public bool compareListLenght(List<string> numberList1, List<string> numberList2) {
        bool _sameLenght = false;
        
        if (numberList1.Count == numberList2.Count) {
            _sameLenght = true;
        }

        return _sameLenght;
    }
}