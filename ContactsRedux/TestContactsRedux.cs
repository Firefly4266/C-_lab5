using System; 

public class TestContactsRedux
{
    public static void Main()
    {
        InputWrapper iw = new InputWrapper();
        Console.WriteLine("Enter command,  <quit> to exit.");
        string cmd = iw.getString("> ");
        while (cmd != "quit")
        {
            Console.WriteLine("The {0} command was entered.", cmd);
            switch (cmd)
            {
                case "add":
                    {
                        Console.WriteLine("add command");
                            break;
                    }
                case "forward":
                    {
                        Console.WriteLine("forward command");
                        break;
                    }
                case "reverse":
                    {
                        Console.WriteLine("reverse command");
                        break;
                    }
                case "find":
                    {
                        Console.WriteLine("find command");
                        break;
                    }
                case "remove":
                    {
                        Console.WriteLine("remove command");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("add, forward, reverse, find, remove are the only commands available");
                        break;
                    }
            }
            cmd = iw.getString("> ");
        }
    }
}