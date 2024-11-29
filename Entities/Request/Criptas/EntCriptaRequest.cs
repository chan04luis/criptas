﻿using Newtonsoft.Json;

namespace Entities.Request.Criptas
{
    public class EntCriptaRequest
    {
        [JsonProperty("IdSeccion")]
        public Guid uIdSeccion { get; set; }

        [JsonProperty("IdCliente")]
        public Guid uIdCliente { get; set; }

        [JsonProperty("Numero")]
        public string sNumero { get; set; }

        [JsonProperty("UbicacionEspecifica")]
        public string sUbicacionEspecifica { get; set; }
    }
}
