using System;
using System.Runtime.Serialization;

namespace Restaurante.Shared.Entities
{
    [DataContract]
    public abstract class Entidade
    {
        [DataMember]
        public int Id { get; private set; }
    }
}
