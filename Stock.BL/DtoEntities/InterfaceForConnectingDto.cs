﻿namespace Stock.BL.DtoEntities
{
    using System.Runtime.Serialization;

    [DataContract]
    public class InterfaceForConnectingDto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}
