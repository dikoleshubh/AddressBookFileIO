﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CsvHelper;
using System.Globalization;

namespace Address_Book_File_IO
{
    class FileReader
    {
        static String FilePath = @"C:\Users\Admin\source\repos\Address Book File IO\Address\Address.txt";
        static String FilePathCsv = @"C:\Users\Admin\source\repos\Address Book File IO\Address1csv.csv";
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
    }

        




} 
