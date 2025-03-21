using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT2_WFCadastroPessoa
{
    public enum ETipoTelefone
    {
        Pessoal = 1,
        Comercial,
        Recado,
    }

    public class Pessoa
    {
       
        public Pessoa(int cadastro, string? nome, string? dDDCelular, ETipoTelefone tipoTelefone, string? email, string? filhos)
        {
            Cadastro = cadastro;
            Nome = nome;
            DDDCelular = dDDCelular;
            TipoTelefone = tipoTelefone;
            Email = email;
            Filhos = filhos;
        }

        public int Cadastro { get; set; }
        public string? Nome { get; set; }
        public string? DDDCelular { get; set; }
        public ETipoTelefone TipoTelefone { get; set; }
        public string? Email { get; set; }
        public string? Filhos { get; set; }

        public static List<Pessoa> ListaPessoas = new List<Pessoa>();

        public Pessoa() { }


        public static List<Pessoa> ObterLista()
        {
            return ListaPessoas;
        }
    }
}
