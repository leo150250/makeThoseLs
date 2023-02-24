    class Program
    {
        static void Main(string[] args)
        {
            string binCode = "01000110 01100001 01111010 00100000 01101111 00100000 01001100";
            string tempStr = string.Empty;
            string character = System.Text.RegularExpressions.Regex.Replace(binCode, "[^01]", "");
            byte[] data = new byte[character.Length / 8 - 1 + 1];

            for(int index = 0; index <= data.Length - 1; index++)
                data[index] = System.Convert.ToByte(character.Substring(index * 8, 8), 2);

            tempStr = (string)(System.Text.ASCIIEncoding.ASCII.GetString(data));
            System.Console.WriteLine(tempStr);
            System.Console.ReadLine();
        }
    }