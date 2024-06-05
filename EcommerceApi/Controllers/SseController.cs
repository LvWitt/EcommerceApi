using Microsoft.AspNetCore.Mvc;

namespace SseDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SseController : ControllerBase
    {
        [HttpGet("events")]
        public async Task GetEvents()
        {
            var response = Response;
            response.Headers.Add("Content-Type", "text/event-stream");

                //await response.WriteAsync($"data: Message {i + 1}\n\n");
                await response.WriteAsync("data: Pagamento efetuado com sucesso!\n\n");
                await response.Body.FlushAsync();
                await Task.Delay(10000);
        }
    }
}