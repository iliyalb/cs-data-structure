using System;

namespace DataStructure
{
    class HashTable
    {
        internal class HashEntry
        {
            public String value;
            public HashEntry(String value)
            {
                this.value = value;
            }
        }

        internal class HashMap
        {
            const int TABLE_SIZE = 127;
            public HashEntry[] table;
            public HashMap()
            {
                table = new HashEntry[TABLE_SIZE];
                for (int i = 0; i < TABLE_SIZE; i++)
                    table[i] = null;
            }

            private int HashFunc(String value)
            {
                int key = 0;
                char[] charArray = value.ToCharArray();
                for (int i = 0; i < value.Length; i++)
                    key += charArray[i];
                return key % TABLE_SIZE;
            }

            internal void Insert(String value)
            {
                int hash = HashFunc(value);
                if (table[hash] == null)
                    table[hash] = new HashEntry(value);
            }

            internal HashEntry Search(String value)
            {
                int hash = HashFunc(value);
                if (table[hash] == null)
                {
                    Console.WriteLine("Value {" + value + "} not found.");
                    return null;
                }
                else
                    return table[hash];
            }

            internal void Remove(String value)
            {
                int hash = HashFunc(value);
                if (table[hash] != null)
                    table[hash] = null;
            }
        }
    }
}
