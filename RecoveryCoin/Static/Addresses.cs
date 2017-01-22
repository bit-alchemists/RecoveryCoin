using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RocksDbSharp;
using System.IO;
using System.Windows.Forms;
using Org.BouncyCastle.Math;

namespace RecoveryCoin
{
    public static class Addresses
    {
        public static RocksDb Database;

        public static void Load(ListBox listbox)
        {
            string path = Path.Combine(Application.StartupPath, "Addresses");
            var options = new DbOptions();
            options.SetCreateIfMissing(true);
            Database = RocksDb.Open(options, path);
            using (var iterator = Database.NewIterator(readOptions: new ReadOptions()))
            {
                iterator.SeekToFirst();
                while (iterator.Valid())
                {
                    listbox.Items.Add(ByteOps.ByteToAddress(iterator.Key()));
                    iterator.Next();
                }
            }
        }

        public static BigInteger Count()
        {
            return new BigInteger(Database.GetProperty("rocksdb.estimate-num-keys"));
        }
    }
}
