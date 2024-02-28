
using System.Globalization;

string text = Console.ReadLine();

int length = text.Length;

for (int i = text.Length - 1; i >= 0; i--)
{
    char letter = text[i];
    Console.Write(letter);
}