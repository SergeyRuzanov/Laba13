using Laba11;
using System;
using System.Windows;

namespace Laba13
{
    class MyNewSortedDictionary<K, T> : MySortedDictionary<K, T>
        where K : IComparable
    {
        public MyNewSortedDictionary(string _nameCollection) : base()
        {
            NameCollection = _nameCollection;
        }
        public delegate void CollectionHandler(object source, CollectionHandlerEventArgs<K, T> args);
        public string NameCollection { get; private set; }
        public (K Key, T Value) this[int i]
        {
            get
            {
                if (i >= 0 && i < Count)
                {
                    return (Keys[i], Values[i]);
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            set
            {
                if (i >= 0 && i < Count)
                {
                    Keys[i] = value.Key;
                    Values[i] = value.Value;
                    CollectionReferenceChanged?.Invoke(this, new CollectionHandlerEventArgs<K, T>(NameCollection, "изменение ссылки на новый объект.", value));
                    Sort();
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        public bool Remove(int j)
        {
            try
            {
                (K, T) g = (Keys[j], Values[j]);
                this.RemoveAt(j);
                CollectionCountChanged?.Invoke(this, new CollectionHandlerEventArgs<K, T>(NameCollection, "удален объект.", g));
                return true;
            }
            catch
            {

                return false;
            }
        }
        public new void Add(K key, T value)
        {
            try
            {
                base.Add(key, value);
                CollectionCountChanged?.Invoke(this, new CollectionHandlerEventArgs<K, T>(NameCollection, "добавлен объект.", (key, value)));
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (FormatException)
            {
                MessageBox.Show("Объект с таким ключом уже существует!");
            }
        }
        public event CollectionHandler CollectionCountChanged;
        public event CollectionHandler CollectionReferenceChanged;
    }
}
