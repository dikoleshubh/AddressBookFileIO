using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CsvHelper;
using System.Globalization;
using Newtonsoft.Json;

namespace Address_Book_File_IO
{
    class FileReader
    {
        static String FilePath = @"C:\Users\Admin\source\repos\Address Book File IO\Address\Address.txt";
        static String FilePathCsv = @"C:\Users\Admin\source\repos\Address Book File IO\Address1csv.csv";
        static String FilePathjson = @"C:\Users\Admin\source\repos\Address Book File IO\TextFile.json";
        public static void WriteTxtFile(List<Person> persons)
        {
            if (File.Exists(FilePath))
            {
                using (StreamWriter streamWriter = File.AppendText(FilePath))
                {
                    foreach (Person person in persons)
                    {
                        streamWriter.WriteLine(" \nPersons detail ");
                        streamWriter.WriteLine("FirstName: " + person.firstName);
                        streamWriter.WriteLine("LastName: " + person.lastName);
                        streamWriter.WriteLine("City    : " + person.city);
                        streamWriter.WriteLine("Email   : " + person.email);
                        streamWriter.WriteLine("State   : " + person.state);
                        streamWriter.WriteLine("PhoneNum: " + person.phoneNumber);

                    }
                    streamWriter.Close();
                }
                Console.WriteLine("Writting Persons detail in to the Text the file");
            }
            else
            {
                Console.WriteLine("No such file exists");
            }
        }

        public static void ReadTxtFile()
        {
            if (File.Exists(FilePath))
            {
                using (StreamReader streamReader = File.OpenText(FilePath))
                {
                    String personDetails = "";
                    while ((personDetails = streamReader.ReadLine()) != null)
                        Console.WriteLine((personDetails));
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No such file exists");
            }
        }

        public static void writeIntoCsvFile(List<Person> contacts)
        {
            if (File.Exists(FilePathCsv))
            {
                using (StreamWriter streamWriter = File.AppendText(FilePathCsv))
                {
                    foreach (Person contact in contacts)
                    {
                        streamWriter.WriteLine(contact.firstName + "," + contact.lastName + "," + contact.city + "," + contact.state + "," + contact.phoneNumber);
                    }
                }
            }
        }

        public static void ReadContactsInCSVFile()
        {
            if (File.Exists(FilePathCsv))
            {
                string[] csv = File.ReadAllLines(FilePathCsv);
                foreach (string csValues in csv)
                {
                    string[] column = csValues.Split(',');
                    foreach (string CSValues in column)
                    {
                        Console.WriteLine(CSValues);
                    }
                }
            }
            else
            {
                Console.WriteLine("No such file exists");
            }
        }
        public static void WriteContactsInJSONFile(List<Person> contacts)
        {
            if (File.Exists(FilePathjson))
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                using (StreamWriter streamWriter = new StreamWriter(FilePathjson))
                using (JsonWriter writer = new JsonTextWriter(streamWriter))
                {
                    jsonSerializer.Serialize(writer, contacts);
                }
                Console.WriteLine("Writting Contacts to the JSON file");
            }
            else
            {
                Console.WriteLine("No such file exists");
            }
        }

        public static void ReadContactsFromJSONFile()
        {
            if (File.Exists(FilePathjson))
            {
                IList<Person> contactsRead = JsonConvert.DeserializeObject<IList<Person>>(File.ReadAllText(FilePathjson));
                foreach (Person contact in contactsRead)
                {
                    Console.Write(contact.ToString());
                }
            }
            else
            {
                Console.WriteLine("No such file exists");
            }
        }
    }

        




} 
