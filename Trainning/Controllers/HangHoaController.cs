using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Trainning.Models;

namespace Trainning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HangHoaController : ControllerBase
    {

        public static List<hangHoa> hanghoas = new List<hangHoa>();

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(hanghoas);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            try
            {
                var hanghoa = hanghoas.FirstOrDefault(hh => hh.MaHangHoa == Guid.Parse(id));
                if (hanghoa == null)
                    return NotFound();
                return Ok(hanghoa);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost]
        public IActionResult Create(HangHoaVM vm)
        {
            var hanghoa = new hangHoa
            {
                MaHangHoa = Guid.NewGuid(),
                TenHangHoa = vm.TenHangHoa,
                DonGia = vm.DonGia,
            };
            hanghoas.Add(hanghoa);
            return Ok(new
            {
                Success = true,Data = hanghoa
            });
        }

        [HttpPut("{id}")]
        public IActionResult Edit(string id,hangHoa hangHoaEdit)
        {
            try
            {
                var hanghoa = hanghoas.FirstOrDefault(hh => hh.MaHangHoa == Guid.Parse(id));
                if (hanghoa == null)
                    return NotFound();
                if(id!= hanghoa.MaHangHoa.ToString())
                    return BadRequest();
                hanghoa.TenHangHoa = hangHoaEdit.TenHangHoa;
                hanghoa.DonGia = hangHoaEdit.DonGia;
                return Ok(hanghoa);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            try
            {
                var hanghoa = hanghoas.FirstOrDefault(hh => hh.MaHangHoa == Guid.Parse(id));
                if (hanghoa == null)
                    return NotFound();
                hanghoas.Remove(hanghoa);
                return Ok(hanghoa);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
