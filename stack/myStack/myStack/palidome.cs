public static bool IsPalindrome(string input)
{
    // Remove all non-alphanumeric characters and convert to lowercase
    string cleanInput = new string(input.Where(char.IsLetterOrDigit).ToArray()).ToLower();

    // Compare the string to its reverse
    for (int i = 0; i < cleanInput.Length / 2; i++)
    {
        if (cleanInput[i] != cleanInput[cleanInput.Length - i - 1])
        {
            return false;
        }
    }

    return true;
}
