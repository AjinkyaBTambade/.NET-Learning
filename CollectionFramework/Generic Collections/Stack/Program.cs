using System;
using System.Collections.Generic;

class TextEditor
{
    private Stack<string> documentStates;

    public TextEditor()
    {
        documentStates = new Stack<string>();
    }

    // Method to perform an action (e.g., typing text, deleting text)
    public void PerformAction(string action)
    {
        // Simulate applying the action to the document
        Console.WriteLine("Applying action: " + action);

        // Save the current state of the document by pushing it onto the stack
        documentStates.Push(action);
    }

    // Method to undo the most recent action
    public void Undo()
    {
        if (documentStates.Count > 0)
        {
            // Pop the top state from the stack and simulate restoring the document to that state
            string lastState = documentStates.Pop();
            Console.WriteLine("Undoing action: " + lastState);
        }
        else
        {
            Console.WriteLine("No actions to undo.");
        }
    }
}

class Program
{
    static void Main()
    {
        TextEditor editor = new TextEditor();

        // Simulating user actions
        editor.PerformAction("Typed 'Hello'");
        editor.PerformAction("Deleted 'Hello'");
        editor.PerformAction("Formatted text");

        // Simulating user clicking the "Undo" button
        editor.Undo(); // Undo formatting
        editor.Undo(); // Undo deletion
        editor.Undo(); // Undo typing

        // Simulating trying to undo when there are no actions left
        editor.Undo(); // No actions to undo
    }
}
