using System;

namespace WPiAA.Singleton
{
    public class Vault
    {
        private static Vault? instance;
        private string accessKey;
        private bool isKeyRetrieved = false;

        private Vault()
        {
            accessKey = RetrieveKeyFromAzureVault();
        }

        public static Vault GetInstance()
        {
            if (instance == null)
            {
                instance = new Vault();
            }

            return instance;
        }

        public string RetrieveAccessKey()
        {
            if (isKeyRetrieved)
            {
                Console.WriteLine("Klucz został już pobrany!");
            }

            isKeyRetrieved = true;
            return accessKey;
        }

        private string RetrieveKeyFromAzureVault()
        {
            Console.WriteLine("Pobieranie klucza z Azure Key Vault . . . . . . .");
            return "Azure-Secret-Key-12345";
        }
    }
}