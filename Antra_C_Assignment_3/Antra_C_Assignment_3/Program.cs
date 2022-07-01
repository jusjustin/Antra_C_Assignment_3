/*
1. What are the six combinations of access modifier keywords and what do they do? 
Public: accessible everywhere
Private:accessible only in the current class
Protected: accessible in the same class or derived class
Internal: accessible in the same assembly
Protected Internal: accessible from the current assembly or from types that are derived from the containing class
Private Protected: accessible by types derived from the containing class, but only within its containing assembly

2. What is the difference between the static, const, and readonly keywords when applied to a type member?
Const: is static and we cannot change the value of a const variable throughout the entire program.
Readonly: is the keyword whose value we can change during runtime or we can assign it at run time but 
only through the non-static constructor.
Static members can only be accessed within the static methods. The non-static methods cannot access static members.

3. What does a constructor do?
Constructor is a method that will invoke automatically whenever an instance of class or struct is created.

4. Why is the partial keyword useful?
The partial keyword indicates that other parts of the class, struct, or interface can be defined in the namespace. 

5. What is a tuple?
Tuple items are ordered, unchangeable, and allow duplicate values.

6. What does the C# record keyword do?
use the record keyword to define a reference type that provides built-in functionality for encapsulating data.

7. What does overloading and overriding mean?
method overriding: 
happens between base class and derived class. They have the same method signature, including access modifiers, method name, and input parameters
runtime polymorphism

method overloading: 
multiple methods in the same class, they have same method signature, including access modifiers and method name. but different input and output parameters
compile time polymorphism

8. What is the difference between a field and a property?
A field is a variable of any type that is declared directly in a class.

A property is a member that provides a flexible mechanism to read, write or compute the value of a private field.

9. How do you make a method parameter optional?
Two-ways
-using default value
-method overloading

10. What is an interface and how is it different from abstract class?
An interface only allows you to define functionality, not implement it.

11.What accessibility level are members of an interface?
public

protected

internal

private

protected internal

private protected

12.True / False.Polymorphism allows derived classes to provide different implementations
of the same method.
TRUE

13. True/False. The override keyword is used to indicate that a method in a derived class is
providing its own implementation of a method.
TRUE

14. True/False. The new keyword is used to indicate that a method in a derived class is
providing its own implementation of a method.
FALSE

15.True/False. Abstract methods can be used in a normal (non-abstract) class.
FALSE

16.True / False.Normal(non -abstract) methods can be used in an abstract class. 
TRUE

17.True / False.Derived classes can override methods that were virtual in the base class. 
TRUE

18.True / False.Derived classes can override methods that were abstract in the base class. 
FALSE

19.True / False.In a derived class, you can override a method that was neither virtual non abstract in the
base class.
TRUE

20.True / False.A class that implements an interface does not have to provide an
implementation for all of the members of the interface.
TRUE

21.True / False.A class that implements an interface is allowed to have other members that
aren’t defined in the interface.
TRUE

22.True / False.A class can have more than one base class.
TRUE

23.True / False.A class can implement more than one interface.
TRUE
*/

/*Working with methods
1. Let’s make a program that uses methods to accomplish a task. Let’s take an array and
reverse the contents of it. For example, if you have 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, it would
become 10, 9, 8, 7, 6, 5, 4, 3, 2, 1.
To accomplish this, you’ll create three methods: one to create the array, one to reverse the
array, and one to print the array at the end.
Your Mainmethod will look something like this:............*/
/*
static int[] GenerateNumbers(int n)
{
    int[] tempArray = new int[n];
    for(int i = 0; i < n; i++)
    {
        tempArray[i] = i+1;
    }
    return tempArray;
}

static void Reverse(ref int[] array)
{
    for(int i = array.Length-1; i > array.Length/2; i--)
    {
        int a = array[i];
        int b = array[array.Length-i-1];
        int temp = a;

        a = b;
        b = temp;

        array[i] = a;
        array[array.Length - i - 1] = b;
    }
}    

static void PrintNumbers(int[] array)
{
    foreach(int i in array)
    {
        Console.WriteLine(i);
    }
}

int[] numbers = GenerateNumbers(10);
Reverse(ref numbers);
PrintNumbers(numbers);
*/

/*2.The Fibonacci sequence is a sequence of numbers where the first two numbers are 1 and 1,
and every other number in the sequence after it is the sum of the two numbers before it. So
the third number is 1 + 1, which is 2. The fourth number is the 2nd number plus the 3rd,
which is 1 + 2. So the fourth number is 3. The 5th number is the 3rd number plus the 4th
number: 2 + 3 = 5.This keeps going forever 1, 1, 2, 3, 5, 8, 13, 21, 34, 55*/
/*
int fibonacci(int n)
{
    if (n == 1 || n == 2)
        return 1;
    return fibonacci(n - 1) + fibonacci(n - 2);
}

Console.WriteLine(fibonacci(10));
*/

/*1.Write a program that demonstrates use of four basic principles of
object-oriented programming /Abstraction/, /Encapsulation/, /Inheritance/ and /Polymorphism/.*/

//Abstraction
/*abstract class Bug
{
    public abstract void bugSound();
    public void sleep()
    {
        Console.Write("Buzzz");
    }
}*/

//Encapsulation - is to make sure that "sensitive" data is hidden from users
/*class Person
{
    private string name; // field

    public string Name   // property
    {
        get { return name; }   // get method
        set { name = value; }  // set method
    }
}*/

//Inheritance - inherit fields and methods from one class to another
/*class Vehicle  // base class (parent) 
{
    public string brand = "Ford";  // Vehicle field
    public void honk()             // Vehicle method 
    {
        Console.WriteLine("Tuut, tuut!");
    }
}

class Car : Vehicle  // derived class (child)
{
    public string modelName = "Toyota";  // Car field
}*/

//Polymorphism - when we have many classes that are related to each other by inheritance
/*
 class Bug // Base Case
{
    public void bugSound()
    {
        Console.Write("The bug made a sound");
    }
}

class Bee : Bug
{
    public void bugSound()
    {
        Console.WriteLine("Buzz!");
    }
}
*/
/*2. Use /Abstraction/ to define different classes for each person type such as Student
and Instructor. These classes should have behavior for that type of person.*/

/*public abstract class Person
{
    public int Id { get; set; }
    public abstract void PerformClass();
}

public class Student : Person
{
    public override void PerformClass()
    {
        Console.WriteLine("Has multiple different classes to attend");
    }
}

public class Instructor : Person
{
    public override void PerformClass()
    {
        Console.WriteLine("Lectures many students at different times in the day teaching the same classes");
    }
}*/

/*3. Use /Encapsulation/ to keep many details private in each class.*/
/*class Person
{
    private string name; // field
    private string age;
    private string email;

    public string Name   // property
    {
        get { return name; }   // get method
        set { name = value; }  // set method
    }

    public string Age   // property
    {
        get { return age; }   // get method
        set { age = value; }  // set method
    }

    public string Email   // property
    {
        get { return email; }   // get method
        set { email = value; }  // set method
    }
}*/

/*4.Use / Inheritance / by leveraging the implementation already created in the Person
class to save code in Student and Instructor classes.*/
/*class Vehicle  // base class (parent) 
{
    public string brand = "Ford";  // Vehicle field
    public void honk()             // Vehicle method 
    {
        Console.WriteLine("Tuut, tuut!");
    }
}

class Car : Vehicle  // derived class (child)
{
    public string modelName = "Toyota";  // Car field
}*/

/*5. Use /Polymorphism/ to create virtual methods that derived classes could override to
create specific behavior such as salary calculations.*/
/*
public class Person
{
    private string name; // field
    private string salary; // field

    public string Name   // property
    {
        get { return name; }   // get method
        set { name = value; }  // set method
    }
    public string Salary   // property
    {
        get { return salary; }   // get method
        set { salary = value; }  // set method
    }

    public virtual void VirtualMethodSalary()
    {
        Console.WriteLine("This is a virtual method of the base class");
    }
}
public class Instructor : Person
{
    public decimal BiweeklyPay { get; set; }
    public override void VirtualMethodSalary()
    {
        Console.WriteLine("Calculate Instructor Salary...");
    }
}*/

/*6. Make sure to create appropriate /interfaces/ such as ICourseService, IStudentService,
IInstructorService, IDepartmentService, IPersonService, IPersonService (should have
person specific methods). IStudentService, IInstructorService should inherit from
IPersonService.*/
/*
interface ICourseService
{
    void run();
}
interface IStudentService
{
    void run();
}
interface IInstructorService : IPersonService
{
    void run();
}
interface IDepartmentService
{
    void run();
}
interface IPersonService
{
    void changeName();
    void PerformWork();
}*/

/* ONLINE EXAMPLE OF INTERFACE FOR FUTURE REFERENCE
https://www.w3schools.com/cs/cs_interface.php */

/*7.Try creating the two classes below, and make a simple program to work with them, as
described below
Create a Color class:
On a computer, colors are typically represented with a red, green, blue, and alpha
(transparency) value, usually in the range of 0 to 255. Add these as instance variables.
A constructor that takes a red, green, blue, and alpha value.
A constructor that takes just red, green, and blue, while alpha defaults to 255
(opaque).
Methods to get and set the red, green, blue, and alpha values from a Colorinstance.
A method to get the grayscale value for the color, which is the average of the red,
green and blue values.
Create a Ball class:
The Ball class should have instance variables for size and color (the Color class you just
created). Let’s also add an instance variable that keeps track of the number of times it
has been thrown.
Create any constructors you feel would be useful.
Create a Pop method, which changes the ball’s size to 0.
Create a Throw method that adds 1 to the throw count, but only if the ball hasn’t been
popped (has a size of 0).            
A method that returns the number of times the ball has been thrown.*/
/*
public class Color
{
    private byte red;
    private byte green;
    private byte blue;
    private byte alpha;

    public byte Red   // property
    {
        get { return red; }   // get method
        set { red = value; }  // set method
    }
    public byte Green   // property
    {
        get { return green; }   // get method
        set { green = value; }  // set method
    }
    public byte Blue   // property
    {
        get { return blue; }   // get method
        set { blue = value; }  // set method
    }
    public byte Alpha   // property
    {
        get { return alpha; }   // get method
        set { alpha = value; }  // set method
    }

    public Color() //Default alpha to 255
    {
        red = 0;
        green = 0;
        blue = 0;
        alpha = 255;
    }

    public Color(byte r, byte g, byte b) //Default alpha to 255
    {
        red = r;
        green = g;
        blue = b;
        alpha = 255;
    }
    public Color(byte r, byte g, byte b, byte a)
    {
        red = r;
        green = g;
        blue = b;
        alpha = a;
    }

    public byte GrayScaleValue()
    {
        return Convert.ToByte(((red + green + blue) / 3));
    }
}

public class Ball
{
    private uint size;
    private uint timesThrown;
    private Color color;

    public Ball()
    {
        size = 1;
        timesThrown = 0;
        color = new Color();
    }
    public Ball(byte s, byte t, byte r, byte g, byte b, byte a)
    {
        size = s;
        timesThrown = t;
        color = new Color(r, g, b, a);
    }

    public void Pop()
    {
        size = 0;
    }

    public void incrementThrow()
    {
        timesThrown += 1;
    }
    public uint getNumberOfThrows()
    {
        return timesThrown;
    }
    public uint getSizeOfBall()
    {
        return size;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Ball myObj = new Ball(10, 10, 100, 100, 100, 100);
        myObj.incrementThrow();
        myObj.Pop();
        Console.WriteLine(myObj.getSizeOfBall());
        Console.WriteLine(myObj.getNumberOfThrows());
    }
}*/