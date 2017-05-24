using Newtonsoft.Json;
using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactOnline.Client.Models
{
    public interface IModifiable
    {
        DateTime Created { get; set; }
        DateTime Modified { get; set; }
    }

    public interface ISynchronizable
    {
        [JsonIgnore]
        [PrimaryKey, AutoIncrement]
        int LocalId { get; set; }
        [JsonIgnore]
        string RemoteId { get; }
    }

    public abstract class SynchronizableBase : ISynchronizable
    {
        [JsonIgnore]
        [PrimaryKey, AutoIncrement]
        public int LocalId { get; set; }
        [JsonIgnore]
        public string RemoteId { get; set; }
    }
}
