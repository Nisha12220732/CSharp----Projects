using LibraryManagementSystem;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main(string[] args)
    {
        try
        {
            BookRepo library = new BookRepo();
            Console.WriteLine("Enter: \n 1.User \n 2.Admin");
            int choice1 = Int32.Parse(Console.ReadLine());

            if (choice1 == 1)
            {

                bool exit = false;
                while (!exit)
                {
                    DisplayMenuForUser();
                    int choice2 = Int32.Parse(Console.ReadLine());
                    switch (choice2)
                    {
                        case 1:
                            {
                                library.ViewAllBooks();
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Enter the Title of the book you want to search for");
                                string str = Console.ReadLine();
                                library.SearchBookByName(str);
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("Enter the Writer of the book you want to search for");
                                string str = Console.ReadLine();
                                library.SearchBookByPublisher(str);
                                break;
                            }
                        case 4:
                            {
                                library.MaxPriceBook();
                                break;
                            }
                        case 5:
                            {
                                library.MinPriceBook();
                                break;
                            }
                        case 6:
                            {
                                exit = true;
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Please Enter a Valid Choice");
                                break;
                            }
                    }
                }

            }
            else if (choice1 == 2)
            {   //PassCode == 123
                bool flag = false;

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("\n \n Enter Admin Passcode");
                    int pass = Int32.Parse(Console.ReadLine());
                    if (pass == 123)
                    {
                        Console.WriteLine("Access Granted as Admin");
                        flag = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Password Entered!!");
                        Console.WriteLine("Try Again !!");
                    }
                }
                if (flag)
                {
                    bool exit = false;
                    while (!exit)
                    {
                        DisplayMenuForAdmin();
                        int choice2 = Int32.Parse(Console.ReadLine());
                        switch (choice2)
                        {
                            case 1:
                                {
                                    Book b1 = new Book();
                                    Console.WriteLine("Enter the ID of the book");
                                    b1.BookId = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter the Title of the book");
                                    b1.Name = Console.ReadLine();
                                    Console.WriteLine("Enter the Writer of the book");
                                    b1.Writer = Console.ReadLine();
                                    Console.WriteLine("Enter the Price of the book");
                                    b1.Price = Int32.Parse(Console.ReadLine());
                                    library.AddBook(b1);
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine("Enter the ID of the book you want to Update");
                                    int newid = Int32.Parse(Console.ReadLine());

                                    Console.WriteLine("Now Enter the updated details !!");
                                    Console.WriteLine("Enter the ID of the book");
                                    int BookId = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter the Title of the book");
                                    string Name = Console.ReadLine();
                                    Console.WriteLine("Enter the Writer of the book");
                                    string Writer = Console.ReadLine();
                                    Console.WriteLine("Enter the Price of the book");
                                    int Price = Int32.Parse(Console.ReadLine());
                                    library.UpdateBook(BookId, Price, Name, Writer);
                                    break;
                                }
                            case 3:
                                {

                                    Console.WriteLine("Enter the ID of the book you want to Delete");
                                    int newid = Int32.Parse(Console.ReadLine());
                                    library.DeleteBook(newid);
                                    break;
                                }
                            case 4:
                                {
                                    library.ViewAllBooks();
                                    break;
                                }
                            case 5:
                                {
                                    exit = true;
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Please Enter a Valid Choice");
                                    break;
                                }
                        }
                    }

                }

                else
                {
                    throw new AdminInvalidException("Three times wrong Password Entered \nAdmin Passcode is Wrong !! \n Access Denied");
                }
            }
            else
            {
                throw new InvalidChoice("Invalid Choice Entered");
            }
        }
        catch(AdminInvalidException e)
        {
            Console.WriteLine($"Error {e.Message}");
        }
        
        catch (InvalidChoice e)
        {
            Console.WriteLine($"Error {e.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error {e.Message}");
        }
    }

    public static void DisplayMenuForUser()
    {
        Console.WriteLine("Enter the Operation You want to Perform");
        Console.WriteLine("1. Browse Books from Library");
        Console.WriteLine("2. Search Book by Name");
        Console.WriteLine("3. Search Book by Publisher");
        Console.WriteLine("4. View Highest Price Book");
        Console.WriteLine("5. View Lowest Price Book");
        Console.WriteLine("6. Exit");
    }
    public static void DisplayMenuForAdmin()
    {
        Console.WriteLine("Enter the Operation You want to Perform");
        Console.WriteLine("1. Add a Book in Library");
        Console.WriteLine("2. Update a Book");
        Console.WriteLine("3. Delete a Book");
        Console.WriteLine("4. View All Books");
        Console.WriteLine("5. Exit");

    }
    internal class AdminInvalidException : Exception
    {
        public AdminInvalidException()
        {

        }
        public AdminInvalidException(string message) : base(message)
        {

        }
    }

    internal class InvalidChoice : Exception
    {
        public InvalidChoice()
        {

        }
        public InvalidChoice(string message) : base(message)
        {

        }
    }
}

