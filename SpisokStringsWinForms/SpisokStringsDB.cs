using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpisokStringsWinForms
{

    // SQL Data - создание сохранене удаление
    public class SpisokStringsDB : IRepository<SpisokStrings>
    {
        SqlServerDatabaseInterface _database;
        //private List<string> strings;
        public SpisokStringsDB(            
            string IPSQLServer,
            string NameDB,
            string loginDB,
            string passwordDB)
        {            
            _database = new SqlServerDatabaseInterface(
                IPSQLServer,
                NameDB,
                loginDB,
                passwordDB);
            //Create(null);
        }

        public void Create(SpisokStrings entity)
        {
            _database.Open();
            _database.CreateTableDB();

            //_database.Open();
            //_database.TableAdd(strings);
        }

        public void TestOpen()
        {
            _database.Open();
            _database.Close();      
        }

        public void Create(List<string> strings)
        {
            _database.Open();
            _database.CreateTableDB();

            _database.Open();
            _database.TableAdd(strings);
        }

        public void Create(List<StringId> strings)
        {
            _database.Open();
            _database.CreateTableDB2();

            _database.Open();
            _database.TableAdd(strings);
        }

        public List<StringId> GetSpisokStrings()
        {
            _database.Open();                        
            return _database.GetSpisokStrings();
        }

        public List<StringId> GetSpisokStringsGroup(string searchGroup = "")
        {
            _database.Open();
            return _database.GetSpisokStringsGroup(searchGroup);
        }

        public void Add(string ValStr)
        {
            _database.Open();
            _database.TableAdd(ValStr);
            _database.Close();
        }

        public void Add(List<StringId> strID)
        {
            _database.Open();
            _database.TableAdd(strID);
            _database.Close();
        }

        public void Delete(SpisokStrings entity)

        {
            
        }

        public void Delete(int Ind)
        {
            _database.Open();
            _database.TableDelete(Ind);
            _database.Close();
        }

        public void DeleteAll(string tabname)
        {
            _database.Open();
            _database.TableDeleteAll(tabname);
            _database.Close();
        }

        public void Delete(string groupname)
        {
            _database.Open();
            _database.TableDelete(groupname);
            _database.Close();
        }

        public SpisokStrings GetById(long id)

        {
            return null;
        }

        public void Update(SpisokStrings entity)
        {
            _database.Open();
            _database.TableUpdate();
            _database.Close();
        }

        public void Update(int Ind, string ValStr)
        {
            _database.Open();
            _database.TableUpdate(Ind, ValStr);
            _database.Close();
        }

    }
}
