using System;
using System.Collections.Generic;
using System.Text;

namespace ST3V1.Application.DTOs
{
    public class ClienteDTO
    {
        public int Id { get; set; }
        public int IdHtml { get; set; }
        public string CodInterno { get; set; }
        public string CnpjParametro { get; set; }
        public string CnpjConsultado { get; set; }
        public string CnpjNumInscricao { get; set; }
        public string NomeEmpresarial { get; set; }
        public string NomeFantasia { get; set; }
        public DateTime DataImportacao { get; set; }
        public string PorteEmpresa { get; set; }
        public decimal FatBrutoAnual { get; set; }
        public bool Ativo { get; set; }
        public ICollection<EnderecoDTO> Enderecos { get; set; }
    }
}
