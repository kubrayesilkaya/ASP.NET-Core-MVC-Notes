using Microsoft.AspNetCore.Mvc;
using HTML_Rendering.Models;

namespace HTML_Rendering.Controllers
{
    public class EmployeeController : Controller
    {

        // not: IActionResult yapısı string tipinde bir dönüşü kabul etmiyor.
        public IActionResult Index1()
        {
            string message = $"Hello World. {DateTime.Now.ToString()}";
            return View("Index1",message); //burada index'i vermek zorundayım.

            /*view'e tek bir string verir isek bu string ifadesini viewName olarak algılıyor. 
              Aslında benim view ifadem Index1. Dolayısı ile önce view'i veriyorum, view'in yanına object'i
              verirsek bunu model olarak kabul edecek.  
              View("Index",message) olarak verdiğimiz zaman, artık bu fonskiyon view ifadesini index1 olarak kabul edecek.
              Ve sayfaya mesaage biligisini de taşıyor olacak.
            */
        }


        public ViewResult Index2()
        {
            var names = new String[]
            {
                "Ahmet",
                "Mehmet",
                "Can"
            };
            /*
             Burada tanımladığımız, kullandığımız veri tipi: String[] array'i. 
             Burada model olarak bir stirng array kullanılıyor.
             Bu modele hiç index ismi(view ismi) belirtmeyeceğiz. names olarak parametre olarak geçeceğiz.

             Yukarıdakiden farklı. Yukarıda bir index ismi verdik--> vermek durumunda kaldık. 
             Çünkü string olarak verdiğimizde bunu viewName olarak algıladı. 
             */

            return View(names);   //burada string'den farklı bir veri türüyle, bir string dizisi ile çalıştığımız için  
                                  //view adını vermedik. Index1/ index2 demedik. Doğrudan Index2'ye kendisi gitti.
        }

        public IActionResult Index3() 
        {
            var list = new List<Employee>()
            {
                new Employee(){Id=1, FirstName="Ahmet", LastName="Can", Age=20},
                new Employee(){Id=2, FirstName="Can", LastName="Dağ", Age=25},
                new Employee(){Id=3, FirstName="Demir", LastName="Güneş", Age=37},
            };
            return View("Index3",list); //Index3.cshtml'e gitsin; yanında da model olarak listeyi götürsün.
                                        //Burada belirtmesek de olurdu. 
        }

    }
}
