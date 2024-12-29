public class ExampleClass{
    public int MyProperty { get; set; } = 0; // Initialize with a default value

    public void MyMethod() {
        // Accessing a property after it has been initialized
        int value = MyProperty; // No longer a potential error if MyProperty has been initialized to 0
    }
}