using System;
using System.Collections.Generic;

public class User
{
    public string Name { get; set; }
}

public class Message
{
    public  User Sender { get; }
    public string Content { get; }

    public Message(User sender, string content)
    {
        Sender = sender;
        Content = content;
    }
}

public class ChatRoom
{
    private List<User> _users = new List<User>();
    private List<Message> _messages = new List<Message>();
    
}