namespace Catalog.Settings
{
    public class MongoDbSettings
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public bool InProd { get; set; }
        public string ConnectionString
        {
            get
            {
                if (InProd)
                {
                    return $"mongodb+srv://{User}:{Password}@examples.ksqsw.mongodb.net/catalog?retryWrites=true&w=majority";
                }
                else
                {
                    return $"mongodb://{Host}:{Port}";
                }
            }
        }
    }
}
