using System;

namespace Laba13
{
    class CollectionHandlerEventArgs<K, T> : EventArgs
    {
        public string NameCollection { get; set; }
        public string TypeChange { get; set; }
        public (K Key, T Value) Object { get; set; }
        public CollectionHandlerEventArgs(string _nameCollection, string _typeChange, (K, T) _person) : base()
        {
            NameCollection = _nameCollection;
            TypeChange = _typeChange;
            Object = _person;
        }
        public override string ToString()
        {
            return $"Название коллекции: {NameCollection}\nТип изменения: {TypeChange}\nОбъект: {Object.Key} ::::: {Object.Value}";
        }

    }
}