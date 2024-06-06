using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Filtro.Models;
using Filtro.Services.Students;
using Microsoft.AspNetCore.Mvc;

namespace Filtro.Controller.Students
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentsRepository _studentsRepository;

        public StudentsController(IStudentsRepository studentsRepository){
            _studentsRepository = studentsRepository;
        }

        [HttpGet]
        public IEnumerable<Student> GetAll(){
            return _studentsRepository.GetAll();
        }

        [HttpGet("{id}")]
        public Student GetById(int id){
            return _studentsRepository.GetById(id);
        }

        [HttpGet("[action]/{date}")]
        public List<Student> GetStudentByDate(DateTime date){
            return _studentsRepository.GetStudentByDate(date);
        }

        // [HttpGet("EnvioCorreo")]
        // public async Task<IActionResult> EnviarCorreo(){
        //     try
        //     {
        //         //Url de destino
        //         string Url = "https://api.mailersend.com/v1/email";

        //         //token de autorizacion
        //         string JtwToken = "mlsn.0a4252d3f07363d80577a0c01ae45f5d79f5f19e477b13318dd4c6f97dab1b5b";
            
        //         //crear un obj email para contener los datos
        //         var oEmail = new Email{
        //             from = new From {Email = "info@trial-3yxj6ljvek1ldo2r.mlsender.net"},
        //             to = new []{
        //                 new To {Email = "camicarva119@gmail.com"}
        //             },
        //             subject = "Hello from MailerSend!",
        //             text = "Greetings from the team, you got this message through MailerSend.",
        //             html = "Greetings from the team, you got this message through MailerSend."
        //         };
        //         //serealizar el objeto en formato json
        //         string JsonBody = JsonSerializer.Serialize(oEmail);

        //         //crear obj http client
        //         using(HttpClient client = new HttpClient()){
        //             client.DefaultRequestHeaders.Add("ContentType", "application/json");
        //             client.DefaultRequestHeaders.Add("Authorization", $"Bearer {JtwToken}");

        //             StringContent content = new StringContent(JsonBody, Encoding.UTF8, "application/json");

        //             HttpResponseMessage responseMessage = await client.PostAsync(Url, content);

        //             if(responseMessage.IsSuccessStatusCode){
        //                 string responseBody = await responseMessage.Content.ReadAsStringAsync();
        //                 Console.WriteLine("Respuesta del servidor:");
                        
        //                 Console.WriteLine(responseBody);
        //             }else{
        //                 Console.WriteLine("errores");
        //                 Console.WriteLine(responseMessage.StatusCode);
        //             }
        //         }
        //     }
        //     catch (System.Exception)
        //     {
                
        //         throw;
        //     }
        //     return Ok();
        // }
    }
}