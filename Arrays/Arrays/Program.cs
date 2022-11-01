using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //var meuArray = new int[5] {1,2,3,4,5};
            //meuArray[0] = 12;

            //Console.WriteLine(meuArray.Length);

            //for(var index = 0; index < meuArray.Length; index++)
            //{
            //    Console.WriteLine(meuArray[index]);
            //}            

            //foreach(var item in meuArray)
            //{
            //    Console.WriteLine(item);
            //}

            //var funcionarios = new Funcionario[5];
            //funcionarios[0] = new Funcionario() { Id = 1, Name = "Leonardo Martinho" };

            //foreach (var funcionario in funcionarios)
            //{
            //    Console.WriteLine(funcionario.Id);
            //    Console.WriteLine(funcionario.Name);
            //}

            var primeiro = new int[4];
            var segundo = new int[4];

            segundo[0] = primeiro[0];

            primeiro[0] = 23;
            Console.WriteLine(segundo[0]);
        }          

            struct Funcionario
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }           
        
    }    
}