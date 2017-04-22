namespace Stock.BL.DtoEntities
{
    using System.Runtime.Serialization;

    [DataContract]
    [KnownType(typeof(PhoneDto))]
    [KnownType(typeof(SmartWatchDto))]
    [KnownType(typeof(ElectronicBookDto))]
    public abstract class ProductDto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public decimal Price { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public ManufacturerDto Manufacturer { get; set; }
    }
}
