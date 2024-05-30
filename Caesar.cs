namespace CaesarCipher;

public static class Caesar
{
    public static string Encode(string input, int shift)
    {
        string output = "";

        foreach (char character in input)
        {
            if (char.IsLetter(character))
            {
                char offset = char.IsUpper(character) ? 'A' : 'a';
                output += (char)(((character + shift - offset) % 26) + offset);
            }
            else
                output += character;
        }

        return output;
    }

    public static string Decode(string input, int shift) => Encode(input, 26 - shift);
}
