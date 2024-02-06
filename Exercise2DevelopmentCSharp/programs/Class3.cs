public class Class3 {
    private string _person = "";
    private string _first_name;
    private string _last_name;
    private int _age;
    private int _heigh;

    public Class3() {

    }

    public Class3(string first_name, string last_name, int age, int heigh) {
        this._first_name = first_name;
        this._last_name = last_name;
        this._age = age;
        this._heigh = heigh;
    }

    public Class3(string[] person, int[] ageHeigh) {
        this._first_name = person[0];
        this._last_name = person[1];
        this._age = ageHeigh[0];
        this._heigh = ageHeigh[1];
    }

    public string Person {

        get {
            return _person;
        }

        set {
            _person = value + ", my name is " + _first_name + " " + _last_name + ", my age is " + _age + " and my heigh is " + _heigh + " cm.";
        }

    }

    public void printName() {
        Console.Write(Person);
    }

    public void printName(string message) {
        Console.Write(message + Person);
    }

    public bool isPalindrome() {
 
        char[] cArray = Person.ToCharArray();
        Array.Reverse(cArray);
        string rev_Person = new string(cArray);

        if (Person == rev_Person) {
            return true;
        } else {
            return false;
        }

    }

    public void printDiagonal() {
        for (int i = 1; i < 11; i++) {
            switch (i) {
                case 1:
                    Console.WriteLine("\n\n" + i + "----------");
                    break;
                case 2:
                    Console.WriteLine("-" + i + "---------");
                    break;
                case 3:
                    Console.WriteLine("--" + i + "--------");
                    break;
                case 4:
                    Console.WriteLine("---" + i + "-------");
                    break;
                case 5:
                    Console.WriteLine("----" + i + "------");
                    break;
                case 6:
                    Console.WriteLine("-----" + i + "-----");
                    break;
                case 7:
                    Console.WriteLine("------" + i + "----");
                    break;
                case 8:
                    Console.WriteLine("-------" + i + "---");
                    break;
                case 9:
                    Console.WriteLine("--------" + i + "--");
                    break;
                case 10:
                    Console.WriteLine("---------" + i);
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
        }
    }
}