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
    public static class Hits
    {
        public static RocksDb Database;

        public static void Load()
        {
            string path = Path.Combine(Application.StartupPath, "Hits");
            var options = new DbOptions();
            options.SetCreateIfMissing(true);
            Database = RocksDb.Open(options, path);
        }

        public static BigInteger Count()
        {
            return new BigInteger(Database.GetProperty("rocksdb.estimate-num-keys"));
        }
    }
}
