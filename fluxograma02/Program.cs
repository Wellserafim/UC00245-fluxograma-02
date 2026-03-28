namespace Fluxograma02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Fluxograma de trabalho ===\n");

            // Início
            Console.WriteLine("1. Início");

            // Comecei o trabalho

            Console.WriteLine("2. Comecei o trabalho");

            // Recebi 10 documentos

            Console.WriteLine("3. Recebi 10 Documentos");
            int documentos = 10;
            int contador = 0;

            // repetidor --> FOR, WHILE E DO-WHILE

            Console.WriteLine("4. ainda tem documentos para auditar e assinar? ");


            while (contador < documentos)
            {
                Console.WriteLine("Sim -> auditando e assinando ");
                Console.WriteLine($"Documentos {contador + 1} concluído");
                contador++;
                
            } // Fim do while

            // Acabaram os documentos
            Console.WriteLine("Não tem documentos");
            Console.WriteLine("Ainda tem atividade");

            // Variável do tipo BOOLEANA

            bool temAtividade = true; // Pode mudar para falso

            if (temAtividade == true)
            {
                Console.WriteLine("Sim tem atividade");          
            }
            else
            {
                Console.WriteLine("Não tem atividade");
            }
            // Bloco do fim
            Console.WriteLine("6. Fim");

            Console.WriteLine("\n ****Fim do Program**** ");


        } // Fim do metodo Main
 
    } // Fim do program
    
} // Fim namespace