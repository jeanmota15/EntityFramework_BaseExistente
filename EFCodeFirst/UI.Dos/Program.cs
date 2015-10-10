using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Infra.Data.Models;

namespace UI.Dos
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new ModeloFeioContext();
            //var pessoa = p.Pessoa.Include("Endereco").FirstOrDefault();
            var pessoa = p.Pessoa.Where(x => x.Nome == "Jean Mota").FirstOrDefault();//uma lista

            Console.WriteLine(pessoa.Endereco.FirstOrDefault().Rua);
            Console.ReadKey();
        }
    }
}
