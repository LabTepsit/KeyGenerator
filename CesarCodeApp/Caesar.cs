namespace CesarCodeApp
{
    public class Caesar
    {
        public string PlainText { get; set; }
		public string CipherMessage { get; set; }
		int Key { get; set; }	
		public Caesar(string message, int key)
		{
			PlainText = message;
			Key = key;
		}
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

			return (char)(((ch + Key - offset) % 26) + offset);
		}
		public void Encipher()
		{
			CipherMessage = DoWork(PlainText);
		}
		public void Decipher()
		{
			Key = 26 - Key;
			PlainText =DoWork(CipherMessage);
		}
		private string DoWork(string m)
		{
			string message = string.Empty;
			foreach (char ch in m)
				message += Cipher(ch);
			return message;
		}
	}
}

