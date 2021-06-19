using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using APPSTOCK.Core.Models;


namespace APPSTOCK.Persistence.Context
{
    public class MongoApplicationContext
    {
        //private readonly IMongoCollection<DictionaryModel> _dictonary;
        private IMongoDatabase _iMongoDatabase;
        public MongoApplicationContext(IDictionaryDatabaseSettings settings)
        {
            var client = new MongoClient("mongodb://localhost:44339");
            _iMongoDatabase = client.GetDatabase("DictionaryDb");

            //_dictonary = _iMongoDatabase.GetCollection<DictionaryModel>("Dictionary");
        }


        //public List<DictionaryModel> Get()
        //{
        //    try
        //    {
        //        return _dictonary.Find(dictonary => true).ToList();
        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }

        //}

        //public DictionaryModel Get(string id) =>
        //   _dictonary.Find<DictionaryModel>(dictonary => dictonary.Id == id).FirstOrDefault();

        //public DictionaryModel GetByHindi(string Hindi) =>
        //  _dictonary.Find<DictionaryModel>(dictonary => dictonary.Hindi == Hindi).FirstOrDefault();

        //public DictionaryModel GetByEnglish(string English) =>
        //  _dictonary.Find<DictionaryModel>(dictonary => dictonary.English == English).FirstOrDefault();


        //public List<DictionaryModel> GetByHindiList(List<string> Hindi)
        //{
        //    try
        //    {
        //        var list = JsonConvert.SerializeObject(Hindi);
        //        //var cmd = new JsonCommand<BsonDocument>("db.Dictionary.find({ English : { $in : ['amit', 'arvind'] }})");
        //        //var obj = _iMongoDatabase.RunCommand<BsonDocument>("db.Dictionary.find({ English : { $in : ['amit', 'arvind'] }})");
        //        var result = _dictonary.Find<DictionaryModel>("{ Hindi : { $in :"+ list.ToString() + " }}").ToList();
        //        return result;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }

        //}

        //public async Task Create(DictionaryModel dictonary)
        //{
        //    await _dictonary.InsertOneAsync(dictonary);
        //}

        //public async Task CreateMany(List<DictionaryModel> dictonary)
        //{
        //    await _dictonary.InsertManyAsync(dictonary);
        //}

        //public async Task Update(string id, DictionaryModel bookIn) =>
        //   await _dictonary.ReplaceOneAsync(dictonary => dictonary.Id == id, bookIn);

        //public void Remove(DictionaryModel bookIn) =>
        //    _dictonary.DeleteOne(dictonary => dictonary.Id == bookIn.Id);

        //public void Remove(string id) =>
        //    _dictonary.DeleteOne(dictonary => dictonary.Id == id);
    }
}
