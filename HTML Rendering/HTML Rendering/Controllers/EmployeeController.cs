using Microsoft.AspNetCore.Mvc;

namespace HTML_Rendering.Controllers
{
    public class EmployeeController : Controller
    {
        public String Index()
        {
            return "Hello World";
        }

        //Bu action string dönüyor; herhangi bir render olayı yok. 

        public ViewResult Index2()
        {
            return View("Index");   // View ile html ifadelerini render ederek sonuç dönüyor. 

            /*Controlers yapısı içerisinde tanımlanan bir action normal şartlar altında default olarak bu action
            ile aynı isme sahip olan bir view ifadesi arar. 
            Eğer farklı bir view'e göndermek istior isek bunu, o view'in adını burada belirtmemiz gerekir. 

            Yani Index2 view'i değil Index view'i gönderdiğimiz için : return View("Index"); şeklinde belirtmeliyiz.
            */

            // Ugulama Index2 action'ına gidiyor, ve daha sonra hangi view'i render edecğini ona söylememiz ile işlem
            //gerçekleşmiş oluyor.
        }

        public IActionResult Index3() //ContentResult'da olur, IActionResult daha kapsayıcı
        {
            return Content("Employee"); //Content (içerik) ifadesi ile dönüş yapıyor. 
        }

        /* dönüş tipini, metot içerisinde dönecek olan ifadeye,(dönen verinin yapısına bağlı olarak)
           uygun seçmeliyiz;
           örneğin ; String, View, IActionResult gibi.
        */

        //IActionResult daha kapsayıcı bir ifade. Hem content ifadesini, hem view ifadesini, 
        //bu referansların her birini ayrı ayrı tutabilir.

        //IActionResult action'ları tanımlarken/ifade ederken kullandığımız bir yapı 
    }
}
