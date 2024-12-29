public class ExampleClass{
    public int MyProperty { get; set; }

    public void MyMethod() {
        // Accessing a property that hasn't been initialized
        int value = MyProperty; // Potential error here if MyProperty is not set before this line
    }
}