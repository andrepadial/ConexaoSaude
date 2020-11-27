using ConexaoSaude.Domain.Interfaces.Signatures;
using ConexaoSaude.Domain.Models.Signatures;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.Globalization;

namespace ConexaoSaudeApi.Settings
{
    public class JsonSettings
    {
        public static void SetJsonOptions(MvcJsonOptions obj)
        {
            obj.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            obj.SerializerSettings.Formatting = Formatting.None;
            obj.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
            obj.SerializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.Utc;
            obj.SerializerSettings.ContractResolver = new DefaultContractResolver();
            obj.SerializerSettings.Culture = CultureInfo.CurrentCulture;
            obj.SerializerSettings.Converters = new List<JsonConverter>()
            {                
                new AbstractConverter<IObterClienteSignature, ObterClienteSignature>()                                             
            };
        }
    }
}
