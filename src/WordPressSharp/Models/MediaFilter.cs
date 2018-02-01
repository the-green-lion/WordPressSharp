using CookComputing.XmlRpc;

namespace WordPressSharp.Models
{
    [XmlRpcMissingMapping(MappingAction.Ignore)]
    public class MediaFilter
    {
        [XmlRpcMember("number")]
        public int Number { get; set; }

        [XmlRpcMember("offset")]
        public string Offset { get; set; }

        [XmlRpcMember("parent_id")]
        public string ParentId { get; set; }

        [XmlRpcMember("mime_type")]
        public string MimeType { get; set; }
    }
}
