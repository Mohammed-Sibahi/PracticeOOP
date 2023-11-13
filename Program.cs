using System;
using System.Collections.Generic;

// Define the User class
public class User
{
    // Property to store the user's name
    public string Name { get; set; }
}

// Define the Message class
public class Message
{
    // Properties to store the sender (a User object) and the message content
    public User Sender { get; }
    public string Content { get; }

    // Constructor to create a Message object with a sender and content
    public Message(User sender, string content)
    {
        Sender = sender;
        Content = content;
    }
}
// Define the ChatRoom class
public class ChatRoom
{
    // Private lists to store users and messages
    private List<User> _users = new List<User>();
    private List<Message> _messages = new List<Message>();

    // Method to add a user to the chat room
    public void AddUser(User user)
    {
        _users.Add(user);
        // Display a message indicating that the user has joined the chat
        Console.WriteLine($"{user.Name} joined the chat!");
    }

    // Method to send a message in the chat room
    public void SendMessage(User sender)
    {
        // Prompt the user to type a message
        Console.Write($"Type your message, {sender.Name}: ");

        while (true)
        {
            //Console.Write($"{sender.Name}");
            string content = Console.ReadLine();

            if (content.ToLower() == "exit")
            {
                Console.WriteLine("Conversation ended.\n");
                break;
            }

            Message message = new Message(sender, content);
            _messages.Add(message);

            //Console.WriteLine($"Message sent: {content}\n");

            sender = (sender == _users[0]) ? _users[1] : _users[0];

            Console.Write($"{sender.Name}: ");
        }
    }

    // Method to display the chat history
    public void DisplayChatHistory()
    {
        // Display a header for the chat history
        Console.WriteLine("Chat History: \n");
        // Iterate through each message in the list and display its sender and content
        foreach (var message in _messages)
        {
            Console.WriteLine($"{message.Sender.Name}: {message.Content}");
        }
    }
}

// Define the Program class
public class Program
{
    // Main method, the entry point of the program
    public static void Main(string[] args)
    {
        // Display a welcome message
        Console.WriteLine("Welcome to the Chat App!");

        // Create 2 user objects with names Ahmad and Sibahi
        User user1 = new User { Name = "AK" };
        User user2 = new User { Name = "MAS" };

        // Create a chatroom
        ChatRoom room1 = new ChatRoom();

        // Add the 2 users to the chatroom
        room1.AddUser(user1);
        room1.AddUser(user2);

        // Send messages interactively for user1 and user2
        room1.SendMessage(user1);
        room1.SendMessage(user2);

        // Display the chat history
        room1.DisplayChatHistory();
    }
}
