using CookComputing.XmlRpc;

namespace WordPressSharp.Models
{
    public abstract class FilterBase
    {
        [XmlRpcMember("number")]
        public int Number { get; set; }
        protected FilterBase()
        {
            Number = int.MaxValue;
        }
    }
}
