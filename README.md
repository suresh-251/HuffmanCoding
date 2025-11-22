A simple implementation of Huffman Coding in C#, used for compressing and decompressing text using prefix-free binary codes.
This project demonstrates how to:

Calculate character frequencies

Build a Huffman Tree

Generate prefix codes (encoder & decoder dictionaries)

Encode text into binary form

Decode compressed binary back to original text

This is a great entry-level project showcasing data structures, recursion, trees, and greedy algorithms.

🚀 Features

✔ Generate frequency map from input string
✔ Build Huffman Tree using a min-heap (PriorityQueue<Node,int>)
✔ Create prefix codes (binary strings) for each character
✔ Encode text into binary
✔ Decode binary back into original text
✔ Print Huffman codes for each character

📁 Project Structure
HuffmanCoder.cs
Program.cs

Main Class: HuffmanCoder

Contains:

HuffmanEncoder(string feeder)

encode(string source)

decode(string codedstring)

printCodes()

🧠 How It Works
1. Frequency Map

Counts how many times each character appears.

2. Min-Heap

Least frequent characters get higher-length codes, helping compression.

3. Huffman Tree

Creates internal nodes combining the lowest-cost nodes until one root remains.

4. DFS-Based Code Assignment

Recursively generates codes such as:

s : 110
u : 0100
r : 11111

5. Encode

Each character replaced by its binary code.

6. Decode

Binary is matched using reverse lookup (decoder dictionary).



🧪 How to Run

Clone the repository:

git clone https://github.com/<your-username>/HuffmanCoding.git


Build the project:

dotnet build


Run it:

dotnet run


Enter your text → get encoded + decoded result.
