﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace OpenInvoicePeru.Comun.Dto.Modelos
{
    public class ComunicacionBaja : DocumentoResumen
    {
        [JsonProperty(Required = Required.Always)]
        public List<DocumentoBaja> Bajas { get; set; }
    }
}