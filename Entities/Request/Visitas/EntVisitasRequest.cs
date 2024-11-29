﻿using Newtonsoft.Json;

namespace Entities.Request.Visitas
{
    public class EntVisitasRequest
    {
        [JsonProperty("NombreVisitante")]
        public string sNombreVisitante { get; set; }

        [JsonProperty("IdCriptas")]
        public Guid uIdCriptas { get; set; }
    }
}
