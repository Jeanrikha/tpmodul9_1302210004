using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace tpmodul9_1302210004
{
    [ApiController]//penanda MahasiswaController sebagai API Controller
    [Route("api/[controller]")]//penentu route
    public class MahasiswaController : ControllerBase
    {
        //List data Mahasiswa
        public static List<Mahasiswa> ListM = new List<Mahasiswa>
        {

            new Mahasiswa ("Jean Rika Haryadi", "1302210004"),
            new Mahasiswa ("Aisha Putri Nuryan", "1302213038"),
            new Mahasiswa ("Jannatin Nurrohmah", "1302213051"),
            new Mahasiswa ("Novita Sabila Nugraha", "1302213030"),
            new Mahasiswa ("Muthia Khairunnisa", "1302213062")
        };

        [HttpGet] //menggunakan metode get
        public IEnumerable<Mahasiswa> Get()
        {
            return ListM; //mereturn data yg terdapat di ListM
        }

        [HttpGet("{id}")] //menggunakan metode get dengan parameter "id"
        public Mahasiswa Get(int id)
        {
            return ListM[id]; //mereturn data yg terdapat di ListM sesuai "id" yang diminta
        }

        [HttpPost] //menggunakan metode post
        public void Post(Mahasiswa mhs)
        {
            ListM.Add(mhs); //menambahkan data baru yang akan disimpan pada ListM
        }

        [HttpDelete("{id}")] //menggunakan metode delete
        public void Delete(int id)
        {
            ListM.RemoveAt(id); //menghapus data yg terdapat di ListM sesuai "id" yang diminta
        }
    }
}