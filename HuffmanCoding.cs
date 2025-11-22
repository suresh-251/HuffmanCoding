using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace HuffmanCoding
{
    public class HuffmanCoder
    {
        Dictionary<char, string> encoder;
        Dictionary<string, char> decoder;
        private class Node : IComparable<Node>
        {
            public char data;
            public int cost;
            public Node left, right;

            public Node(char data, int cost)
            {
                this.data = data;
                this.cost = cost;
                this.left = null;
                this.right = null;
            }

            public int CompareTo(Node? other)
            {
                if (other == null) return 1;
                return this.cost - other.cost;
            }


        }
        public void HuffmanEncoder(string feeder)
        {
            Dictionary<char, int> frequencyMap = new Dictionary<char, int>();
            foreach (char c in feeder)
            {
                if (frequencyMap.ContainsKey(c))
                {
                    frequencyMap[c]++;
                }
                else
                {
                    frequencyMap[c] = 1;
                }
            }
           
            PriorityQueue<Node, int> minHeap = new PriorityQueue<Node, int>();

            foreach (var entry in frequencyMap)
            {
                Node node = new Node(entry.Key, entry.Value);
                minHeap.Enqueue(node, entry.Value);
            }
            while (minHeap.Count != 1)
            {
                Node first = minHeap.Dequeue();
                Node second = minHeap.Dequeue();
                Node newnode = new Node('\0', first.cost + second.cost);
                newnode.left = first;
                newnode.right = second;
                minHeap.Enqueue(newnode, newnode.cost);

            }
            Node ft = minHeap.Dequeue();
            this.encoder = new Dictionary<char, string>();
            this.decoder = new Dictionary<string, char>();
            this.Initencoderdecoder(ft, "");
        }


        private void Initencoderdecoder(Node node, string osf)
        {
            if (node == null)
            {
                return;
            }
            if (node.left == null && node.right == null)
            {
                this.encoder.Add(node.data, osf);
                this.decoder.Add(osf, node.data);
            }
            Initencoderdecoder(node.left, osf + "0");
            Initencoderdecoder(node.right, osf + "1");


        }
        public string encode(string source)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < source.Length; i++)
            {
                sb.Append(encoder[source[i]]);
            }
            return sb.ToString();

        }
        public string decode(string codedstring)
        {
            StringBuilder key = new StringBuilder();
            StringBuilder ans = new StringBuilder();
            for (int i = 0; i < codedstring.Length; i++)
            {
                key.Append(codedstring[i]);
                if (decoder.ContainsKey(key.ToString()))
                {
                    ans.Append(decoder[key.ToString()]);
                    key.Clear();
                }

            }
            return ans.ToString();

        }
        public void printCodes()
        {
            foreach(var entry in encoder)
            {
                Console.WriteLine($"{entry.Key} : {entry.Value}");
            }
           
        }
     
    }

}