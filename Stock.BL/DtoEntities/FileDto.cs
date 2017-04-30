namespace Stock.BL.DtoEntities
{
    using System.Runtime.Serialization;
    
    [DataContract]
    public class FileDto 
    {
        [DataMember]
        public string FileName { get; set; }

        [DataMember]
        public long FileLength { get; set; }

        [DataMember]
        public byte[] FileByteStream { get; set; }
    }
}