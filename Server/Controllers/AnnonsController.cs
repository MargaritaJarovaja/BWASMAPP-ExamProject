﻿using BWASMAPP.Server.Data;
using BWASMAPP.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BWASMAPP.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnonsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public AnnonsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var ann = await _context.Annonser.ToListAsync();
            return Ok(ann);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var ann = await _context.Annonser.FirstOrDefaultAsync(a => a.Id == id);
            return Ok(ann);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Annons annons)
        {
            _context.Add(annons);
            await _context.SaveChangesAsync();
            return Ok(annons.Id);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Annons annons)
        {
            _context.Entry(annons).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var ann = new Annons { Id = id };
            _context.Remove(ann);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}