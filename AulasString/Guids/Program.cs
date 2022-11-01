using System;
using System.IO;
using System.Globalization;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Guid - Identificador Global Unico

            var id = Guid.NewGuid(); //para usar o Guid não se esqueça de está com using System aplicado.            
            Console.WriteLine(id);

            //Para transformá-lo em string => id.ToString();
            id = new Guid("ecda0068-3c7d-4ccf-b232-c39e96a12c66");
            Console.WriteLine(id.ToString().Substring(0, 8)); //O .Substring serviu para extrair somente os 8 primeiros dígitos do ID em questão.
            
            id = new Guid();
            Console.WriteLine(id); //vai sempre retornar zero.
        }
    }
}

