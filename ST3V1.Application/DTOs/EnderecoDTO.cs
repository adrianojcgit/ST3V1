﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ST3V1.Application.DTOs
{
    public class EnderecoDTO
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
        public int ClienteId { get; set; }
        public ClienteDTO Cliente { get; set; }
    }
}
