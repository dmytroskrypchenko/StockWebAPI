namespace Stock.BL.DtoEntities
{
    using System.Runtime.Serialization;

    [DataContract]
    public class ElectronicBookDto : ProductDto
    {
        [DataMember]
        public int ElectronicBookId { get; set; }
        [DataMember]
        public double ScreenDiagonal { get; set; }
        [DataMember]
        public ScreenTypeDto ScreenType { get; set; }
        [DataMember]
        public int BatteryCapacity { get; set; }
        [DataMember]
        public string WorkingTime { get; set; }
    }
}
