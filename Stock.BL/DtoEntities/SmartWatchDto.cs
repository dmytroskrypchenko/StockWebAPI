namespace Stock.BL.DtoEntities
{
    using System.Runtime.Serialization;

    [DataContract]
    public class SmartWatchDto : ProductDto
    {
        [DataMember]
        public int SmartWatchId { get; set; }
        [DataMember]
        public InterfaceForConnectingDto InterfaceForConnecting { get; set; }
        [DataMember]
        public double? ScreenDiagonal { get; set; }
        [DataMember]
        public bool? Pulsometer { get; set; }
        [DataMember]
        public bool? SimCard { get; set; }
    }
}
