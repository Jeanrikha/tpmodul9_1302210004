namespace tpmodul9_1302210004
{
    public class Mahasiswa
    {
        //membuat get set nama dan nim
        public string nama { get; set; }
        public string nim { get; set; }
        public Mahasiswa(string nama, string nim) //membuat konstruktor Mahasiswa
        {
            this.nama = nama;
            this.nim = nim;
        }

    }
}
