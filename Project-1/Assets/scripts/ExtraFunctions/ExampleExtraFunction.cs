using UnityEngine;

public class ExtraFunction{
    public virtual void Call()
    {
        // This method can be overridden by derived classes to provide specific functionality
        Debug.Log("ExtraFunction called");
        
        // You can add more code here if needed, or leave it empty for default behavior
    }
}

public class ExampleFunction : ExtraFunction
{
    public override void Call()
    {
        // This method overrides the base Call method to provide specific functionality
        Debug.Log("ExampleFunction called with specific functionality");
        
        // You can add more code here to implement the specific behavior you want
        // For example, you might want to modify some game state or trigger an event
    }
}