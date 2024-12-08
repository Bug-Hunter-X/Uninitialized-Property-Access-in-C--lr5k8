public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize the property

    public void MyMethod()
    {
        int value = MyProperty; 
    }
}

//Another solution is to use a constructor to initialize:
public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int initialValue)
    {
        MyProperty = initialValue;
    }

    public void MyMethod()
    {
        int value = MyProperty;
    }
} 