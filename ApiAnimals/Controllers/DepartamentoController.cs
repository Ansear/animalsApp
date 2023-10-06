
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiAnimals.Controllers;
public class DepartamentoController : BaseController
{
    private readonly IUnitOfWork _unitOfWork;

    public DepartamentoController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<Departamento>>> Get()
    {
        var departamentos = await _unitOfWork.Departamentos.GetAllAsync();
        return Ok(departamentos);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<Departamento>> Get(int id)
    {
        var departamento = await _unitOfWork.Departamentos.GetByIdAsync(id);
        if (departamento == null)
        {
            return NotFound();
        }
        return departamento;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Departamento>> Post(Departamento departamento)
    {
        _unitOfWork.Departamentos.Add(departamento);
        await _unitOfWork.SaveAsync();
        if (departamento == null)
        {
            return BadRequest();
        }
        return CreatedAtAction(nameof(Post), new { id = departamento.Id }, departamento);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<Departamento>> Put(int id, [FromBody] Departamento departamento)
    {
        if (departamento == null)
        {
            return BadRequest();
        }
        if (departamento.Id == 0)
        {
            departamento.Id = id;
        }
        if (departamento.Id != id)
        {
            return NotFound();
        }
        _unitOfWork.Departamentos.Update(departamento);
        await _unitOfWork.SaveAsync();
        return departamento;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<Departamento>> Delete(int id)
    {
        var departamento = await _unitOfWork.Departamentos.GetByIdAsync(id);
        if(departamento == null)
        {
            return NotFound();
        }
        _unitOfWork.Departamentos.Remove(departamento);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
}