using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.Models
{
    public class ExemploExcecao
    {
        public void MetodoUm()
        {
            try
            {
                MetodoDois();
            }catch(Exception ex){
                Console.WriteLine("Exceção tratada | " + ex.Message);
            }
        }

        public void MetodoDois()
        {
            MetodoTres();
        }
        public void MetodoTres()
        {
            MetodoQuatro();
        }
        public void MetodoQuatro()
        {
            throw new Exception("Ocorreu uma exceção");
        }
    }


}