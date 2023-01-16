using System;

namespace Switch{

    class Program
    {
        static void Main(string[] args)
        {
            string cor = "rosa";
//com switch nao pode trabalhar com operadores comparacionais exp: > < etc.
            switch (cor)
            {
                case "vermelho":
                    Console.WriteLine("sua cor favorita é vermelho!");
                    break;
                case "amarelo":
                    Console.WriteLine("sua cor favorita é amarelo!");
                    break;
                case "azul":
                    Console.WriteLine("sua cor favorita é azul!");
                    break;
                default: //se eu tiver uma variavel verde e em nenhum case tiver essa cor, ele vai executar o que estiver dentro do default.
                         //default é bem semelhante com o "else"
                    Console.WriteLine("sua cor favorita eu não sei!");
                    break;
            }


        }
    }
}