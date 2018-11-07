using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileStreamApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteReadDirectlyToStream();
            WriteReadWithStreamClasses();
        }

        private static void WriteReadDirectlyToStream()
        {
            Console.WriteLine("***** Fun with FileStreams Without Readers*****\n");

            // Obtain a FileStream object.
            using (FileStream fStream = File.Open(@".\myMessage.dat", FileMode.Create))
            {
                // Encode a string as an array of bytes.
                string msg = "Hello!";
                byte[] msgAsByteArray = Encoding.Default.GetBytes(msg);

                // Write byte[] to file.
                fStream.Write(msgAsByteArray, 0, msgAsByteArray.Length);

                // Reset internal position of stream.
                fStream.Position = 0;

                // Read the types from file and display to console.
                Console.Write("Your message as an array of bytes: ");
                byte[] bytesFromFile = new byte[msgAsByteArray.Length];
                for (int i = 0; i < msgAsByteArray.Length; i++)
                {
                    bytesFromFile[i] = (byte)fStream.ReadByte();
                    Console.Write(bytesFromFile[i]);
                }

                // Display decoded messages.
                Console.Write("\nDecoded Message: ");
                Console.WriteLine(Encoding.Default.GetString(bytesFromFile));
            }
            Console.ReadLine();
        }

        private static void WriteReadWithStreamClasses()
        {
            Console.WriteLine("***** Fun with FileStreams Using Writer/Reader *****\n");

            // Obtain a FileStream object.
            using (FileStream fStream = File.Open(@".\myMessage.dat",
              FileMode.Create))
            {
                // Encode a string as an array of bytes.
                string msg = "Hello!";
                byte[] msgAsByteArray = Encoding.Default.GetBytes(msg);

                BinaryWriter sWriter = new BinaryWriter(fStream);
                // Write byte[] to file.
                sWriter.Write(msgAsByteArray);
                
                // Reset internal position of stream.
                fStream.Position = 0;

                BinaryReader sReader = new BinaryReader(fStream);
                                // Display decoded messages.
                Console.Write("Your message as an array of bytes: ");
                byte[] fileAsByteArray = sReader.ReadBytes((int)sReader.BaseStream.Length);
                foreach (byte bByte in fileAsByteArray)
                {
                    Console.Write(bByte);
                }
                Console.Write("\nDecoded Message: ");
                                Console.WriteLine(Encoding.Default.GetString(fileAsByteArray));
            }

            Console.ReadLine();
        }

    }
}
