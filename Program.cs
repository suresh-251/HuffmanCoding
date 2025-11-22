using System;
using HuffmanCoding;   // Your namespace

class Program
{
    static void Main(string[] args)
    {
        HuffmanCoder coder = new HuffmanCoder();

        Console.Write("Enter text to encode: ");
        string input = Console.ReadLine();

        // Step 1: Build Huffman tree using input
        coder.HuffmanEncoder(input);
        coder.printCodes();
        // Step 2: Encode input
        string encoded = coder.encode(input);
        Console.WriteLine("\nEncoded:");
        Console.WriteLine(encoded);

        // Step 3: Decode encoded output
        string decoded = coder.decode(encoded);
        Console.WriteLine("\nDecoded:");
        Console.WriteLine(decoded);

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
