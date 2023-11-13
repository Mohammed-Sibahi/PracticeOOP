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

}