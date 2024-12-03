using System;
using System.Collections.Generic;
using System.Linq;

//calculator
#region
//class Calculator
//{
//    static void Main(string[] args)

//    { //ciklshi chavsva
//        Console.WriteLine("Simple Calculator");
//        Console.WriteLine("------------------");


//        Console.Write("Enter the first number: ");

//        double.TryParse(Console.ReadLine(), out var num1);

//        Console.Write("Enter the second number: ");
//        double.TryParse(Console.ReadLine(), out var num2);


//        Console.Write("Enter an operator (+, -, *, /): ");
//        char op = Console.ReadKey().KeyChar;
//        Console.WriteLine();


//        double result;

//        switch (op)
//        {
//            case '+':
//                result = num1 + num2;
//                Console.WriteLine($"Result: {num1} + {num2} = {result}");
//                break;

//            case '-':
//                result = num1 - num2;
//                Console.WriteLine($"Result: {num1} - {num2} = {result}");
//                break;

//            case '*':
//                result = num1 * num2;
//                Console.WriteLine($"Result: {num1} * {num2} = {result}");
//                break;

//            case '/':
//                if (num2 != 0)
//                {
//                    result = num1 / num2;
//                    Console.WriteLine($"Result: {num1} / {num2} = {result}");
//                }
//                else
//                {
//                    Console.WriteLine("Error: Division by zero is not allowed.");
//                }
//                break;

//            default:
//                Console.WriteLine("Invalid operator. Please use +, -, *, or /.");
//                break;
//        }

//        Console.WriteLine("Press any key to exit...");
//        Console.ReadKey();
//    }
//}
#endregion

// guess the Number
#region
//    class GuessTheNumber
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Welcome to 'Guess the Number'!");
//        Console.WriteLine("I have selected a number between 1 and 100. Try to guess it!");


//        Random random = new Random();
//        int numberToGuess = random.Next(1, 101);
//        int attempts = 0;
//        bool guessedCorrectly = false;

//        while (!guessedCorrectly)
//        {

//            Console.Write("\nEnter your guess: ");
//            string input = Console.ReadLine();


//            if (!int.TryParse(input, out int playerGuess) || playerGuess < 1 || playerGuess > 100)
//            {
//                Console.WriteLine("Invalid input! Please enter a number between 1 and 100.");
//                continue;
//            }


//            attempts++;


//            if (playerGuess == numberToGuess)
//            {
//                Console.WriteLine($"Congratulations! You guessed the correct number {numberToGuess} in {attempts} attempts.");
//                guessedCorrectly = true;
//            }
//            else if (playerGuess < numberToGuess)
//            {
//                Console.WriteLine("Too low! Try again.");
//            }
//            else
//            {
//                Console.WriteLine("Too high! Try again.");
//            }
//        }

//        Console.WriteLine("Thanks for playing! Press any key to exit.");
//        Console.ReadKey();
//    }
//}
#endregion

//bank simulator

#region
//class BankAccount
//{
//    // Account properties
//    public string AccountHolder;
//    public double Balance;

//    // Constructor to create an account
//    public BankAccount(string accountHolder, double initialDeposit)
//    {
//        AccountHolder = accountHolder;
//        Balance = initialDeposit;
//        Console.WriteLine($"\nAccount created for {AccountHolder} with an initial balance of {Balance:C}.");
//    }

//    // Deposit method
//    public void Deposit(double amount)
//    {
//        Balance += amount;
//        Console.WriteLine($"Deposited {amount:C}. New Balance: {Balance:C}");
//    }

//    // Withdraw method
//    public void Withdraw(double amount)
//    {
//        if (amount <= Balance)
//        {
//            Balance -= amount;
//            Console.WriteLine($"Withdrew {amount:C}. New Balance: {Balance:C}");
//        }
//        else
//        {
//            Console.WriteLine("Insufficient balance for this withdrawal.");
//        }
//    }

//    // Check balance method
//    public void CheckBalance()
//    {
//        Console.WriteLine($"Current Balance: {Balance:C}");
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Welcome to the Bank Simulator!");

//        // Create a bank account
//        Console.Write("\nEnter your name: ");
//        string name = Console.ReadLine();
//        Console.Write("Enter an initial deposit amount: ");
//        double initialDeposit = Convert.ToDouble(Console.ReadLine());

//        BankAccount account = new BankAccount(name, initialDeposit);

//        // Simple menu
//        while (true)
//        {
//            Console.WriteLine("\nChoose an option:");
//            Console.WriteLine("1. Deposit Money");
//            Console.WriteLine("2. Withdraw Money");
//            Console.WriteLine("3. Check Balance");
//            Console.WriteLine("4. Exit");
//            Console.Write("Your choice: ");
//            int choice = Convert.ToInt32(Console.ReadLine());

//            switch (choice)
//            {
//                case 1: // Deposit
//                    Console.Write("Enter the amount to deposit: ");
//                    double depositAmount = Convert.ToDouble(Console.ReadLine());
//                    account.Deposit(depositAmount);
//                    break;

//                case 2: // Withdraw
//                    Console.Write("Enter the amount to withdraw: ");
//                    double withdrawAmount = Convert.ToDouble(Console.ReadLine());
//                    account.Withdraw(withdrawAmount);
//                    break;

//                case 3: // Check Balance
//                    account.CheckBalance();
//                    break;

//                case 4: // Exit
//                    Console.WriteLine("Thank you for using the Bank Simulator. Goodbye!");
//                    return;

//                default:
//                    Console.WriteLine("Invalid choice. Please try again.");
//                    break;
//            }
//        }
//    }
//}
#endregion

//OOP
#region
//namespace BookManagement
//{


//    public class Book
//    {


//        public string Title { get; set; }
//        public string Author { get; set; }
//        public DateTime PublishDate { get; set; }
//        public int ID { get; set; }



//        public Book(string title, string author, DateTime publishDate, int id)
//        {
//            Title = title;
//            Author = author;
//            PublishDate = publishDate;
//            ID = id;
//        }



//        public override string ToString()
//        {
//            return $"ID: {ID}, Title: {Title}, Author: {Author}, Publish Date: {PublishDate.ToShortDateString()}";
//        }
//    }



//    public class BookManager
//    {


//        private List<Book> books = new List<Book>();



//        public void AddBook()
//        {
//            Console.WriteLine("\n--- Add New Book ---");



//            Console.Write("Enter Title: ");
//            string title = Console.ReadLine();
//            if (string.IsNullOrWhiteSpace(title))
//            {
//                Console.WriteLine("Title cannot be empty!");
//                return;
//            }



//            Console.Write("Enter Author: ");
//            string author = Console.ReadLine();
//            if (string.IsNullOrWhiteSpace(author))
//            {
//                Console.WriteLine("Author cannot be empty!");
//                return;
//            }



//            Console.Write("Enter Publish Date (yyyy-mm-dd): ");
//            if (!DateTime.TryParse(Console.ReadLine(), out DateTime publishDate))
//            {
//                Console.WriteLine("Invalid date format!");
//                return;
//            }



//            Console.Write("Enter ID (unique): ");
//            if (!int.TryParse(Console.ReadLine(), out int id) || books.Any(b => b.ID == id))
//            {
//                Console.WriteLine("ID must be a unique integer!");
//                return;
//            }



//            books.Add(new Book(title, author, publishDate, id));
//            Console.WriteLine("Book added successfully!");
//        }



//        public void ViewAllBooks()
//        {
//            Console.WriteLine("\n--- All Books ---");
//            if (books.Count == 0)
//            {
//                Console.WriteLine("No books available.");
//                return;
//            }

//            foreach (var book in books)
//            {
//                Console.WriteLine(book);
//            }
//        }



//        public void SearchBookById()
//        {
//            Console.Write("\nEnter Book ID to Search: ");
//            if (!int.TryParse(Console.ReadLine(), out int id))
//            {
//                Console.WriteLine("Invalid ID format!");
//                return;
//            }

//            var book = books.FirstOrDefault(b => b.ID == id);
//            if (book != null)
//            {
//                Console.WriteLine("Book Found:");
//                Console.WriteLine(book);
//            }
//            else
//            {
//                Console.WriteLine("No book found with the given ID.");
//            }
//        }
//    }



//    class Programm
//    {
//        static void Main(string[] args)
//        {
//            BookManager manager = new BookManager();
//            bool exit = false;

//            while (!exit)
//            {
//                Console.WriteLine("\n--- Book Management System ---");
//                Console.WriteLine("1. Add New Book");
//                Console.WriteLine("2. View All Books");
//                Console.WriteLine("3. Search Book by ID");
//                Console.WriteLine("4. Exit");
//                Console.Write("Choose an option: ");

//                switch (Console.ReadLine())
//                {
//                    case "1":
//                        manager.AddBook();
//                        break;
//                    case "2":
//                        manager.ViewAllBooks();
//                        break;
//                    case "3":
//                        manager.SearchBookById();
//                        break;
//                    case "4":
//                        exit = true;
//                        Console.WriteLine("Exiting the system. Goodbye!");
//                        break;
//                    default:
//                        Console.WriteLine("Invalid option! Please try again.");
//                        break;
//                }
//            }
//        }
//    }
//}
#endregion


