string[] person = {"Juan", "Lopez"};
int[] ageHeigh = {24, 167};

Class3 class3_1 = new Class3();
Class3 class3_2 = new Class3("Jorge", "Lopez", 20, 178);
Class3 class3_3 = new Class3(person, ageHeigh);

class3_1.Person = "Hello";
class3_2.Person = "\n\nHi";
class3_3.Person = "\n\nHey";

class3_1.printName();
class3_2.printName();
class3_3.printName();

Console.WriteLine("\n\nIs a palindrome? " + class3_1.isPalindrome());
Console.WriteLine("\n\nIs a palindrome? " + class3_2.isPalindrome());
Console.WriteLine("\n\nIs a palindrome? " + class3_3.isPalindrome());

class3_1.printDiagonal();
class3_2.printDiagonal();
class3_3.printDiagonal();