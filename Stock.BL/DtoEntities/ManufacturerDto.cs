namespace Stock.BL.DtoEntities
{
    using System.Runtime.Serialization;

    [DataContract]
    public class ManufacturereDto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}
