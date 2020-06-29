namespace CaesarCipherLibrary
{
    public abstract class CaesarBase
    {
		protected int Key { get; set; }	
	
		private char Cipher(char ch)
		{
			if (!char.IsLetter(ch))
				return ch;
			char offset;
			if (char.IsUpper(ch))
			{ 
				offset = 'A'; 
			}
			else
			{ 
				offset = 'a'; 
			}
			return (char)(((ch - offset + Key) % 26) + offset);
		}

		protected string DoWork(string m)
		{
			string message = string.Empty;
			foreach (char ch in m)
				message += Cipher(ch);
			return message;
		}
	}
}


