using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("libray Menu:\n1) add book\n2) search books by prefix\n3) print who borrowed book by name\n4) print library by id\n5) print library by name\n6) add user\n7) user borrow book\n8) user return book\n9) print users\n10) Exit \n\nenter your menu choice[1 - 10] ");
            int choice = int.Parse(Console.ReadLine());
            

            List<(int id, string name, int total_quantity)> records = new List<(int, string, int)>();
            Dictionary<string, string> Users = new Dictionary <string, string>();
            Dictionary<int, int> total_borrowed = new Dictionary<int, int>();
            

            while (choice > 0)
            {
                if (choice == 1)
                {
                    Console.Write("Enter your book info: id & name & Total quantity");
                    string[] arr_info = Console.ReadLine().Split();
                    // validation 
                    if (arr_info.Length != 3 || !int.TryParse(arr_info[0], out int id) || !int.TryParse(arr_info[2], out int total_quantity))
                    {
                        Console.WriteLine("Invalid input! Try again.");
                        continue;
                    }
                    records.Add((int.Parse(arr_info[0]), arr_info[1], int.Parse(arr_info[2])));
                    total_borrowed[id] = 0;// intilize number
                }
                else if (choice == 2)
                {
                    //continue;
                }
                else if (choice == 3)
                {
                    //continue;
                }
                else if (choice == 4)
                {
                    print_libary_by_id(records, total_borrowed);
                }
                else if (choice == 5) 
                {
                    //continue;
                }
                else if(choice == 6)
                {
                    // this fild to put user and his id number
                    Console.WriteLine("Enter your name & national id:");
                    string[] user_info = Console.ReadLine().Split();
                    //validation
                    if (user_info.Length != 2)
                    {
                        Console.WriteLine("Invalid input! Try again.");
                        continue;
                    }

                    //var user = (name : user_info[0], id : int.Parse(user_info[1]));
                    //Uesers.Add((user_info[0], int.Parse(user_info[1])));
                    string user_name = user_info[0];
                    string national_id =  user_info[1];
                    if (Users.ContainsKey(national_id))
                    {
                        Console.WriteLine("User is already exist");
                    }
                    else
                    {
                        Users[national_id] = user_name;
                        Console.WriteLine("user is add");
                    }
                    

                }
                else if (choice == 7)
                {
                    Console.WriteLine("Enter your Name & book name");
                    string[] user_info = Console.ReadLine().Split();
                    string user_name = user_info[0];
                    string book_name = user_info[1];

                    // التحقق من وجود المستخدم
                    if (Users.ContainsValue(user_name))
                    {
                        //search for book in list records
                        var book = records.Find(b => b.name.Equals(book_name, StringComparison.OrdinalIgnoreCase));

                        // cheack for book is exist
                        if (book.name == null)
                        {
                            Console.WriteLine("Sorry, this book is not available in the library.");
                        }
                        else
                        {
                            // check for free book for borrow
                            if (!total_borrowed.ContainsKey(book.id))
                            {
                                total_borrowed[book.id] = 0; // inital value
                            }

                            if (book.total_quantity > total_borrowed[book.id])
                            {
                                total_borrowed[book.id]++;
                                Console.WriteLine("Book borrowed successfully!");
                            }
                            else
                            {
                                Console.WriteLine("Sorry, no copies available at the moment.");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("User not found! Please register first.");
                    }
                }

                else if (choice == 8)
                {
                    //continue;
                }

                Console.WriteLine("enter your menu choice[1 - 10]");
                choice = int.Parse(Console.ReadLine());
            }

        }
        public static void print_libary_by_id(List<(int id, string name, int count)> records, Dictionary<int, int> total_borrowed)
        {

            Console.WriteLine();
            Console.WriteLine();
            foreach (var rec in records)
            {

                int borrowed = total_borrowed.ContainsKey(rec.id) ? total_borrowed[rec.id] : 0;
                Console.WriteLine("id = {0}, name = {1}, total_quantity = {2}, total_borrowed = {3}", rec.id, rec.name, rec.count, borrowed);
            }
            
        }
        public static void check_your_book(List<(int id, string name, int count)> records, (string name, string book) User)
        {
            for (int i = 0; i < records.Count; i++)
            {
                if (records[i].name == User.name)
                {
                    
                }

            }
        }

    }
}
