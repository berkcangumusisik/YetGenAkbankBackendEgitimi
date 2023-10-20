using CarProject.WebApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var cars = CarsContext.LuxuryCars.ToList();
            return Ok(cars);
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetById(Guid id)
        {
            if(id == Guid.Empty)
                return BadRequest("Id boş olamaz.");
            var car = CarsContext.LuxuryCars.FirstOrDefault(x => x.Id == id);
            if(car == null)
                return NotFound("Araba bulunamadı.");

            return Ok(car);
           
        }
    }
}


/**
 * Web API'de controller isimleri çoğul olmalıdır.
 * Ok() metodu 200 kodu döndürür. Bu kod başarılı bir şekilde isteğin karşılandığını gösterir.
 * 204 kodu ise içerik döndürmediğini gösterir.
 * 200'lü kodlar isteklerin başarılı olduğunu gösterir.
 * 400'lü kodlar isteklerin hatalı olduğunu gösterir.
 * 401 kodu yetkisiz isteklerde döndürülür.
 * 404 kodu istenen kaynağın bulunamadığını gösterir. Senin istediğin kaynak yok.
 * 400 kodu ise isteklerin hatalı olduğunu gösterir. Senin isteğin hatalı.
 * 500 kodu ise sunucu tarafında bir hata olduğunu gösterir. Sunucu tarafında bir hata oluştu.
 * 
 * Guid.empty bir guid değerinin boş olup olmadığını kontrol eder.
 * BadRequest() metodu 400 kodu döndürür. Bu kod isteğin hatalı olduğunu gösterir.
 * 
 * Blazor projesini başlatmak için proje dizinine git ve powershellde dotnet watch run komutunu çalıştır.
 * Blazor sadece güncellenen kısımları günceller. Sayfayı yenilemek zorunda kalmayız. Ama MVC'de sayfada bir kısmı güncellemek için sayfayı yeniden başlatmak zorundayız.
 */