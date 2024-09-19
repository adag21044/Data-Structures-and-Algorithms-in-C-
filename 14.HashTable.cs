using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a dictionary for student management
        Dictionary<int, string> students = new Dictionary<int, string>();

        // Add students
        AddStudent(students, 101, "John Smith");
        AddStudent(students, 102, "Jane Doe");
        AddStudent(students, 103, "Michael Johnson");

        // List all students
        Console.WriteLine("All Students:");
        ListStudents(students);

        // Search for a specific student by their ID
        Console.WriteLine("\nStudent with ID 102:");
        FindStudent(students, 102);

        // Update a student's name
        Console.WriteLine("\nUpdating student with ID 103...");
        UpdateStudent(students, 103, "Michael Williams");

        // Show updated list
        Console.WriteLine("\nUpdated Student List:");
        ListStudents(students);

        // Remove a student
        Console.WriteLine("\nRemoving student with ID 102...");
        RemoveStudent(students, 102);

        // Show the list after removal
        Console.WriteLine("\nUpdated Student List:");
        ListStudents(students);
    }

    // Function to add a student
    static void AddStudent(Dictionary<int, string> students, int id, string name)
    {
        if (!students.ContainsKey(id))
        {
            students.Add(id, name);
            Console.WriteLine($"Student added: {id} - {name}");
        }
        else
        {
            Console.WriteLine($"Error: Student with ID {id} already exists.");
        }
    }

    // Function to remove a student
    static void RemoveStudent(Dictionary<int, string> students, int id)
    {
        if (students.ContainsKey(id))
        {
            students.Remove(id);
            Console.WriteLine($"Student with ID {id} has been removed.");
        }
        else
        {
            Console.WriteLine($"Error: Student with ID {id} not found.");
        }
    }

    // Function to update a student's name
    static void UpdateStudent(Dictionary<int, string> students, int id, string newName)
    {
        if (students.ContainsKey(id))
        {
            students[id] = newName;
            Console.WriteLine($"Student with ID {id} has been updated to: {newName}");
        }
        else
        {
            Console.WriteLine($"Error: Student with ID {id} not found.");
        }
    }

    // Function to find a specific student
    static void FindStudent(Dictionary<int, string> students, int id)
    {
        if (students.TryGetValue(id, out string name))
        {
            Console.WriteLine($"Student with ID {id}: {name}");
        }
        else
        {
            Console.WriteLine($"Error: Student with ID {id} not found.");
        }
    }

    // Function to list all students
    static void ListStudents(Dictionary<int, string> students)
    {
        if (students.Count > 0)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
            }
        }
        else
        {
            Console.WriteLine("No students found.");
        }
    }
}
