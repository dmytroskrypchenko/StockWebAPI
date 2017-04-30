namespace Stock.BL.DtoEntities
{
    using System.Runtime.Serialization;

    [DataContract]
    public class PhoneDto : ProductDto
    {
        [DataMember]
        public int PhoneId { get; set; }
        [DataMember]
        public int? RAM { get; set; }
        [DataMember]
        public int? ROM { get; set; }
        [DataMember]
        public string CPU { get; set; }
        [DataMember]
        public int? BatteryCapacity { get; set; }
        [DataMember]
        public double? ScreenDiagonal { get; set; }
        [DataMember]
        public double? Camera { get; set; }
    }
}
