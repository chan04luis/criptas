﻿using Newtonsoft.Json;

namespace Entities.Models
{
    public class EntCriptas
    {
        [JsonProperty("Id")]
        public Guid uId { get; set; }

        [JsonProperty("IdSeccion")]
        public Guid uIdSeccion { get; set; }

        [JsonProperty("IdCliente")]
        public Guid uIdCliente { get; set; }

        [JsonProperty("Numero")]
        public string sNumero { get; set; }

        [JsonProperty("UbicacionEspecifica")]
        public string sUbicacionEspecifica { get; set; }

        [JsonProperty("FechaRegistro")]
        public DateTime dtFechaRegistro { get; set; }

        [JsonProperty("FechaActualizacion")]
        public DateTime dtFechaActualizacion { get; set; }

        [JsonProperty("Estatus")]
        public bool bEstatus { get; set; }
    }
}
