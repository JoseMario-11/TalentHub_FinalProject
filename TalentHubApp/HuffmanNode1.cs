
namespace TalentHubApp
{
    internal class HuffmanNode<T>
    {
        public T Record { get; set; }
        public HuffmanNode<T> Left;
        public HuffmanNode<T> Right;

        public HuffmanNode(T Record)
        {
            this.Record = Record;
        }
    }
}
