using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web;

namespace My_Stream_File
{
    internal class Program
    {
       // DriveInfo
       //Directory 
        //DirectoryInfo
        //File
        //FileInfo
        static void Main(string[] args)
        {
            //DriveInfo[] driveInfo = DriveInfo.GetDrives();

            //foreach(var item in driveInfo)
            //{
            //    Console.WriteLine($"{item.Name} {item.DriveType}");
            //     if (item.IsReady)
            //    {
            //        Console.WriteLine($"{item.VolumeLabel}{item.TotalSize}{item.TotalFreeSpace}");
            //    }
            //    Console.WriteLine("=======================");
            //}


            //2 want to collect all subdirectory from particular disk
            //string name_directory = @"C:\Users\User\Desktop";
            //if(Directory.Exists(name_directory))
            //{
            //    Console.WriteLine("subdirectory");
            //    string[] all_dir = Directory.GetDirectories(name_directory);
            //    foreach(var item in all_dir)
            //    {
            //        Console.WriteLine(item);
            //    }

            //    Console.WriteLine("File");
            //    string[] all_file = Directory.GetFiles(name_directory);
            //    foreach (var item in all_file)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}


            //3 finding a particular file with specific name

            //string name_directory = Console.ReadLine(); //@"C:\Users\User\Desktop";
            //string[] dirs = Directory.GetDirectories(name_directory, "Academy*.");
            //foreach (var item in dirs)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("+++++++++++++++++++++++++++++++");
            //string[] files = Directory.GetFiles(name_directory, "*.docx");
            //foreach (var item in files)
            //{
            //    Console.WriteLine(item);
            //}


            //4 creating Directory

            // string path = @"C:\Users\User\Desktop\Academy3";
            // string subPath = @"students\bal";
            // DirectoryInfo dirInfo = new DirectoryInfo(path);
            // if(!dirInfo.Exists)
            // {
            //     dirInfo.Create();
            // }
            // dirInfo.CreateSubdirectory(subPath);

            //Console.WriteLine($"{dirInfo.FullName}{dirInfo.CreationTime}{dirInfo.Root}");
            // dirInfo.Delete(true); //way to delete our file 

            //next statement deleting return false if our Academy5 has another folder inside and delete(false)
            //string path = @"C:\Users\User\Desktop\Academy5";

            //DirectoryInfo dirInfo = new DirectoryInfo(path);
            //dirInfo.Delete(false);

            //5 file and fileinfo
            //FileInfo file = new FileInfo(@"C:\Users\User\Desktop\Academy5\tmp.txt");
            //file.Create();
            //if (file.Exists)
            //{
            //    Console.WriteLine($" {file.FullName}{file.CreationTime}{file.Length}");
            //}

            ////Next ability to move our tmp.txt from Academy5 to Academy2 on our desktop

            //string new_pat = @"C:\Users\User\Desktop\Academy1\tmp.txt";
            //if (file.Exists)
            //{
            //    file.MoveTo(new_pat);
            //}

            //FileInfo file = new FileInfo(@"C:\Users\User\Desktop\Academy5\tmp.txt");
            //if(!file.Exists)
            //{
            //    file.Create();
            //    if (file.Exists)
            //    {
            //        Console.WriteLine($" {file.FullName}{file.CreationTime}{file.Length}");
            //    }
            //}
            //else
            //{
            //    //Next ability to move our tmp.txt from Academy5 to Academy2 on our desktop

            //    string new_pat = @"C:\Users\User\Desktop\Academy1\tmp.txt";
            //    if (file.Exists)
            //    {
            //        file.MoveTo(new_pat);
            //    }
            //}

            ////CopyinTo
            //string path_old = @"C:\Users\User\Desktop\Academy5\tmp.txt";
            //string path_new = @"C:\Users\User\Desktop\Academy3\tmp.txt";

            //FileInfo file = new FileInfo(@"C:\Users\User\Desktop\Academy5\tmp.txt");
            //if (file.Exists)
            //{
            //    file.CopyTo(path_old, true);
            //}


            //6.1 Class filestream write 
            //string path = @"C:\Users\User\Desktop\Academy3\tmp.txt";
            //string str = "\nDad drink beer";

            //using (FileStream file = new FileStream(path, FileMode.Append))//OpenORCreate
            //{
            //    byte[] temp = Encoding.Default.GetBytes(str);
            //    //file.Seek(10, SeekOrigin.Begin);
            //    file.Write(temp, 0, temp.Length);
            //    Console.WriteLine("Ok");
            //}

            ////6.2 Reading
            //using (FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))//
            //{
            //    //file.Seek(-5, SeekOrigin.End); //reading from -5 to the end
            //    //creating our byte array
            //    byte[] tem_read = new byte[(int)file.Length];
            //    file.Read(tem_read, 0, tem_read.Length);
            //    string read = Encoding.Default.GetString(tem_read);
            //    Console.WriteLine(read);

            //}


            ////cc
            //string path = @"C:\Users\User\Desktop\Academy3\tmp7.txt";
            //Tovar[] all_tovar =
            //{
            //   new Tovar ("T1", 40),
            //   new Tovar ("T2", 400),
            //   new Tovar ("T3", 4000)

            //};
            ////Using StreamWriter to write to file
            //StreamWriter sw = new StreamWriter(path);
            //foreach (var item in all_tovar)
            //{

            //    Console.WriteLine($"{item.Name} {item.Cost}");
            //    sw.WriteLine($"{item.Name} {item.Cost}");
            //}
            //Console.WriteLine("++++++++++++++++++++++++++++++++++");
            //sw.Close();


            //Using BinaryWrite to write to file
            string path = @"C:\Users\User\Desktop\Academy3\tmp8.txt";
            Tovar[] all_tovar =
            {
               new Tovar ("T1", 40),
               new Tovar ("T2", 400),
               new Tovar ("T3", 4000)

            };
            using (BinaryWriter bw = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))//OpenORCreate
            {
                foreach (var item in all_tovar)
                {
                    bw.Write(item.Name);
                    bw.Write(item.Cost);
                }
            }


        }
    }

    class Tovar
    {
        public int Cost { get; set; }
        public string Name { get; set; }
        public Tovar(string name, int cost)
        {
            Name = name;
            Cost = cost;

        }
    }
}
