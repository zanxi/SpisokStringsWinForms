using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpisokStringsWinForms
{
    public struct StringId 
    {
        public int Id;
        public string ValStr;
        public string GroupName;
    }

    public class SpisokStrings : EntityBase
        {
            private readonly Random rand = new Random();
            //private readonly string[] strings = null;        
            public List<string> Strings
            {
                get;
                set;
            }

            public List<StringId> StringsId
            {
                get;
                set;
            }

            // конструктор для генерации строк
            public SpisokStrings()
            {
                Strings = Generator();
            }

            // конструктор для генерации групп строк
            public SpisokStrings(string groups)
            {
                StringsId = GeneratorId();
            }

           // генератор случайных строк если таблица пустая
            public List<string> Generator()
            {
                List<string> strings = Enumerable.Range(0, 20).
                    Select(
                    y =>
                    {
                        var range = Enumerable.Range(0, rand.Next(8, 50));
                        var chars = range.Select(x => (char)rand.Next('A', 'z')).ToArray();
                        var str = new string(chars);
                        return str;
                    }
                    ).ToList();
                return strings;
            }
        
        // генератор случайных групп строк если таблица пустая
        public List<StringId> GeneratorId()
        {
            List<StringId> strings = Enumerable.Range(0, 40).
                Select(
                y =>
                {
                    var range = Enumerable.Range(0, rand.Next(8, 50));
                    var range2 = Enumerable.Range(0, rand.Next(1, 3));
                    var chars = range.Select(x => (char)rand.Next('A', 'z')).ToArray();
                    var chars2 = range2.Select(x => (char)rand.Next('A', 'D')).ToArray();
                    var str = new string(chars);
                    var str2 = new string(chars2);
                    StringId strID = new StringId() { ValStr = str, GroupName=str2 };
                    return strID;
                }
                ).ToList();
            return strings;
        }

    }
    }
