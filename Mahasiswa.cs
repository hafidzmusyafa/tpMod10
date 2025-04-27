namespace tpmodul10_103022300162
{
    public class Mahasiswa
    {
        private string _nama;
        private string _nim;

        public string Nama
        {
            get { return _nama; }
            set { _nama = value; }
        }

        public string Nim
        {
            get { return _nim; }
            set { _nim = value; }
        }

        // Catatan:
        // Constructor '+ Mahasiswa' dari UML masih terpenuhi karena C# akan
        // secara otomatis menyediakan constructor publik tanpa parameter jika
        // tidak ada constructor lain yang didefinisikan secara eksplisit.
    }
}
