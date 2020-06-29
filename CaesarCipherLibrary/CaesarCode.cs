namespace CaesarCipherLibrary
{
    public class CaesarCode:CaesarBase
    {
        public string CipherText { get; set; }
        public CaesarCode(string message, int key)
        {
            Key = key;
            CipherText = DoWork(message);         
        }
    }
}
