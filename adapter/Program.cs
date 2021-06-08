using System;

namespace adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ICrypto kea = new KEA();
            ICrypto md5 = new MD5();
            ICrypto rsa = new RSAAdapter(new RSA());

            Console.WriteLine(kea.encrypt("black"));
            Console.WriteLine(md5.encrypt("hole"));
            Console.WriteLine(rsa.encrypt("sun"));

            Console.WriteLine(kea.decrypt("show me"));
            Console.WriteLine(md5.decrypt("how to"));
            Console.WriteLine(rsa.decrypt("live"));
        }
    }
}
