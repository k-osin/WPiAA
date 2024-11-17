using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPiAA.Proxy
{
    public class FileProxy : IFile
    {
        private readonly RestrictedFile _restrictedFile;
        private readonly string _correctPassword;

        public FileProxy(string password)
        {
            _restrictedFile = new RestrictedFile();
            _correctPassword = password;
        }

        public void Access()
        {
            Console.Write("Podaj hasło do pliku zastrzeżonego: ");
            string enteredPassword = Console.ReadLine();

            if (enteredPassword == _correctPassword)
            {
                _restrictedFile.Access();
            }
            else
            {
                Console.WriteLine("Błędne hasło! Dostęp do pliku zastrzeżonego został odmówiony.");
            }
        }
    }
}