using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;

namespace tpmodul10_1302223076.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        List<Mahasiswa> LMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("Irvan Dzawin Nuha", "1302223076"),
            new Mahasiswa("Joshua Damiel Simanjuntak", "130222072"),
            new Mahasiswa("Rakha Galih Nugraha Sukma", "1302223118"),
            new Mahasiswa("Mohammed Yousef Gumilar", "1302220085"),
            new Mahasiswa("Abdillah Aufa Tawiyya", "1302220103")
        };
        
        [HttpGet]
        public IEnumerable<Mahasiswa> Get() { return LMahasiswa; }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return LMahasiswa[id];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            LMahasiswa.Add(value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            LMahasiswa.RemoveAt(id);
        }

    }
}
