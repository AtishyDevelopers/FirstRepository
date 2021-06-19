using System;
using System.Collections.Generic;
using System.Text;

namespace APPSTOCK.Persistence.Context
{
    public interface IDictionaryDatabaseSettings
    {
        string DictionaryCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
    public class DictionaryDatabaseSettings : IDictionaryDatabaseSettings
    {
        public string DictionaryCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
