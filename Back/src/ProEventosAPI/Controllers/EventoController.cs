using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProEventosAPI.Data;
using ProEventosAPI.Models;

namespace ProEventosAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly DataContext _context;
          public EventoController(DataContext context)
          {
            this._context = context;

          }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
           return _context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
           return _context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
           return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
           return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete]
        public string Delete(int id)
        {
           return $"Exemplo de Delete com id = {id}";
        }
    }
}
