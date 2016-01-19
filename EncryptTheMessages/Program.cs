using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptTheMessages
{
    class EncryptTheMessages
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> encrypted = new List<string>();
            while (input.ToLower() != "start")
            {
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input.ToLower() != "end")
            {

                if (input.Length != 0)
                {
                    List<char> message = new List<char>(input.ToCharArray().Reverse());
                    string output = "";
                    foreach (var item in message)
                    {
                        if (item > 64 && item < 78 || item > 96 && item < 110)
                        {
                            output += (Convert.ToChar(item + 13));
                        }
                        if (item > 77 && item < 91 || item > 109 && item < 123)
                        {
                            output += (Convert.ToChar(item - 13));
                        }
                        if (item > 47 && item < 58)
                        {
                            output += item;
                        }
                        switch (item)
                        {
                            case ' ': output += '+'; break;
                            case ',': output += '%'; break;
                            case '.': output += '&'; break;
                            case '?': output += '#'; break;
                            case '!': output += '$'; break;
                            default:
                                break;
                        }
                    }
                    encrypted.Add(output);
                }
                input = Console.ReadLine();
            }
            if (encrypted.Count>0)
            {
                Console.WriteLine("Total number of messages: {0}", encrypted.Count);
                foreach (var item in encrypted)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("No messages sent.");
            }
        }
    }
}
