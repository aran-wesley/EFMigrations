using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFMigrations
{
    class Program
    {
        static void Main(string[] args)
        {
            LojaContex db = new LojaContex();

            //db.Clientes.Add(new Cliente 
            //{
            //    Nome = "Wesley",
            //    Telefone = "999998888"
            //});

            // db.Clientes.Add(new Cliente 
            //{
            //    Nome = "Andrew",
            //    CPF = "559686284",
            //    TelefoneContato = "19995385018",
            //    Email = "andrewmarques@outlook.com.br"
            //});

            //db.Produtos.Add(new Produto
            //{
            //    Nome = "SmartPhone",
            //    Preco = 2000,
            //    DataCadastro = DateTime.Today
            //});

            db.Clientes.ToList().ForEach(c => Console.WriteLine(c.Nome));
            db.SaveChanges();
        }
    }
}
