using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using tpmodul10_103022300162;

namespace tpmodul10_103022300162.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        // static list untuk menyimpan data (in-memory)
        private static List<Mahasiswa> _mahasiswaList = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "Hafidz Musyafa Azmi", Nim = "103022300162" },
            new Mahasiswa { Nama = "Fauzul Akbar", Nim = "103022300102" },
            new Mahasiswa { Nama = "Gilang Tirta K", Nim = "103022330077" },
            new Mahasiswa { Nama = "Haafizd Alhabib A", Nim = "103022330089" },
            new Mahasiswa { Nama = "Fadhli Muhammad Dzaki", Nim = "103022330068" },
        };

        // GET /api/mahasiswa
        [HttpGet]
        public ActionResult<IEnumerable<Mahasiswa>> Get()
        {
            return Ok(_mahasiswaList);
        }

        // GET /api/mahasiswa/{index}
        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> Get(int index)
        {
            // Asumsi input selalu benar 
            if (index < 0 || index >= _mahasiswaList.Count)
            {
                return NotFound($"Mahasiswa dengan index {index} tidak ditemukan.");
            }
            return Ok(_mahasiswaList[index]);
        }

        // POST /api/mahasiswa
        [HttpPost]
        public ActionResult Post([FromBody] Mahasiswa newMahasiswa)
        {
            // Asumsi input selalu benar
            _mahasiswaList.Add(newMahasiswa);
            return CreatedAtAction(nameof(Get), new { index = _mahasiswaList.Count - 1 }, newMahasiswa);
        }

        // DELETE /api/mahasiswa/{index}
        [HttpDelete("{index}")]
        public ActionResult Delete(int index)
        {
            // Asumsi input selalu benar
            if (index < 0 || index >= _mahasiswaList.Count)
            {
                return NotFound($"Mahasiswa dengan index {index} tidak ditemukan.");
            }
            _mahasiswaList.RemoveAt(index);

            return NoContent();
        }
    }
}
