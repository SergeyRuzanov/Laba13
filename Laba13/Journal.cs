using Laba10;
using System.Collections.Generic;

namespace Laba13
{
    class JournalEntry
    {
        public string NameCollection { get; set; }
        public string TypeChange { get; set; }
        public string ObjectInfo { get; set; }
        public JournalEntry(string _nameCollection, string _typeChange, string _objectInfo)
        {
            NameCollection = _nameCollection;
            TypeChange = _typeChange;
            ObjectInfo = _objectInfo;
        }

        public override string ToString()
        {
            return $"Название коллекции: {NameCollection}\nТип изменения: {TypeChange}\nОбъект: {ObjectInfo}";
        }
    }
    class Journal
    {
        private List<JournalEntry> journalEntries = new List<JournalEntry>();
        public void AddEntry(object source, CollectionHandlerEventArgs<string, Person> args)
        {
            journalEntries.Add(new JournalEntry(args.NameCollection, args.TypeChange, args.Object.ToString()));
        }

        public override string ToString()
        {
            string str = "";
            foreach (JournalEntry t in journalEntries)
            {
                str += "=============================\n" + t.ToString() + "\n";
            }
            str += "=============================";
            return str;
        }
    }
}
