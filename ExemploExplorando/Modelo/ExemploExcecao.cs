using System;

namespace Modelo.MyNamespace;
public class ExemploExcecao
    {

        public void Metodo1() 
        {
        /*
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("ÁRVOREZES");
        */
        
        try
        {
            Metodo2();
        }catch(Exception ex) //Pode ser sem o ex de argumento.
        { Console.WriteLine("Exceção Tratada."+ ex.Message); } //ex.StackTrace StackTrace mostra todo o caminho até a Exceção.

    }
        public void Metodo2() 
        {
            Metodo3();
        }
        public void Metodo3() 
        {
            Metodo4();
        }
        public void Metodo4() 
        { 
            throw new Exception("Ocorreu uma exceção");
        }
    
}



