using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class OrdemServico
    {

        #region ..:: DADOS OS ::..
        /// 
        /// OS
        /// 
        public int Id { get; set; }
        public bool Favorito { get; set; }
        public string DataEntrada { get; set; }
        public string FimPrevisto { get; set; }
        public string FimReal { get; set; }
        public int TipoServico { get; set; }
        public Tipo StatusAntigo { get; set; } = new Tipo();
        public Tipo StatusAtual { get; set; } = new Tipo();
        public string Resumo { get; set; }


        /// 
        /// Cliente
        /// 
        public Cliente DadosCliente { get; set; } = new Cliente();

        /// 
        /// Observações
        /// 
        public string ObservacoesLoja { get; set; }
        public string ObservacoesCliente { get; set; }


        ///
        /// Dados de Entrada
        ///

        public string SituacaoRelatada { get; set; }
        public string RelatorioTecnico { get; set; }


        ///
        /// Dados de saída
        ///

        public string DescServicoRealizado { get; set; }
        public string DtInicioGarantia { get; set; }
        public string DuracaoGarantia { get; set; }
        public string DtFimGarantia { get; set; }

        #endregion

        #region ..:: DADOS APARELHO ::..

        ///
        /// Dados do aparelho
        ///
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public string NSerie { get; set; }
        public string InformacoesAdicionais { get; set; }
        public string SitAparelho { get; set; }



        ///
        /// Senhas
        ///
        public string Senha { get; set; }
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }
        public string E { get; set; }
        public string F { get; set; }
        public string G { get; set; }
        public string H { get; set; }
        public string I { get; set; }


        ///
        /// Itens Avaliados
        ///
        public bool Tela { get; set; }
        public bool Cameras { get; set; }
        public bool Bateria { get; set; }
        public bool SaidaSom { get; set; }
        public bool Microfone { get; set; }
        public bool Conectores { get; set; }
        public bool Biometria { get; set; }
        public bool Conexoes { get; set; }
        public bool SO { get; set; }
        public bool Bandejas { get; set; }
        public bool Estrutura { get; set; }
        public bool BtnFisicos { get; set; }
        public bool Outros { get; set; }
        public string Detalhamento { get; set; }

        #endregion

        #region ..:: PEÇAS ::..

        public List<ItemCard> ItensEsporadicos { get; set; } = new List<ItemCard>();
        public List<ItemCard> ItensOrdemServico { get; set; } = new List<ItemCard>();

        #endregion

        #region ..:: ORÇAMENTO ::..

        public string Acrescimo { get; set; }
        public string CustoManual { get; set; }
        public string Desconto { get; set; }
        public string Total { get; set; }

        #endregion
    }
}
