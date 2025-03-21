using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT2_WFCadastros
{
    public enum ETipoStatus
    {
        Ativo,
        Inativo,
    }

    public class CadastroCategoria
    {
        public CadastroCategoria(int codigo, string? nome, string? descricao, ETipoStatus eTipoStatus, DateTime? dtCadastro = null)
        {
            Codigo = codigo;
            Nome = nome;
            Descricao = descricao;
            ETipoStatus = eTipoStatus;
            DtCadastro = dtCadastro ?? DateTime.Now;
        }

        public CadastroCategoria() { }

        public static List<CadastroCategoria> ListaCategoria = new List<CadastroCategoria>();

        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public ETipoStatus ETipoStatus { get; set; }
        public DateTime DtCadastro { get; set; }

        public static List<CadastroCategoria> ObterLista()
        {
            return ListaCategoria;
        }
    }
}
