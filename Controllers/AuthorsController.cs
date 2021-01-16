using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using AutoMapper;
using BookStore_API.Contracts;
using BookStore_API.Data;
using BookStore_API.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;

namespace BookStore_API.Controllers
{
    /// <summary>
    /// Endpoint used to interact with the Authors in the book store's database
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]

    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;
        private readonly ILoggerService _loggerService;

        public AuthorsController(IAuthorRepository authorRepository, 
            IMapper _mapper,
            ILoggerService loggerService)
        {
            _authorRepository = authorRepository;
            this._mapper = _mapper;
            _loggerService = loggerService;
        }

        /// <summary>
        /// Gets all authors.
        /// </summary>
        /// <returns>List of Authors</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAuthors()
        {
            try
            {
                _loggerService.LogInfo("Attempted Get All Authors");
                var authors = await _authorRepository.FindAll();
                var response = _mapper.Map<IList<AuthorDTO>>(authors);
                _loggerService.LogInfo("Successfully got all Authors");
                return Ok(response);
            }
            catch (Exception e)
            {
                return InternalError($"{e.Message} - {e.InnerException}");
            }
           
        }
        /// <summary> 
        /// Gets the author by Id
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Author's record</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAuthor(int id)
        {
            try
            {
                _loggerService.LogInfo($"Attempted Get an Author with id: {id}");
                var author = await _authorRepository.FindById(id);
                if (author == null)
                {
                    _loggerService.LogWarn($"Author with id: {id} was not found");
                    return NotFound();
                }
                var response = _mapper.Map<AuthorDTO>(author);
                _loggerService.LogInfo($"Successfully got an Author with id: {id}");
                return Ok(response);
            }
            catch (Exception e)
            {
                return InternalError($"{e.Message} - {e.InnerException}");
            }

        }

        /// <summary>
        /// Creates the specified author dto.
        /// </summary>
        /// <param name="authorDTO">The author dto.</param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Create([FromBody] AuthorCreateDTO authorDTO) 
        {
            try
            {
                _loggerService.LogInfo($"Author submission attempted");
                if (authorDTO == null)
                {
                    _loggerService.LogWarn($"Empty request was submitted");
                    return BadRequest(ModelState);
                }

                if (!ModelState.IsValid)
                {
                    _loggerService.LogWarn($"Author data was incomplete");
                    return BadRequest(ModelState);
                }

                var author = _mapper.Map<Author>(authorDTO);
                var isSuccess = await _authorRepository.Create(author);
                if (!isSuccess)
                {
                    return InternalError($"Author creation failed");
                }
                _loggerService.LogInfo($"Author created");
                return Created("Create", new { author });
            }
            catch (Exception e)
            {
                return InternalError($"{e.Message} - {e.InnerException}");
            }
        }

        /// <summary>
        /// Update the specified author dto.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="authorDTO"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Update(int id, [FromBody] AuthorUpdateDTO authorDTO)
        {
            try
            {
                _loggerService.LogInfo($"Author updated attempted - id: {id}");
                if (id < 1 || authorDTO == null || id != authorDTO.Id)
                {
                    _loggerService.LogWarn($"Empty request was submitted");
                    return BadRequest();
                }

                var isExist = await _authorRepository.isExists(id);
                if (!isExist)
                {
                    _loggerService.LogWarn($"Author not found - id: {id}");
                    return NotFound();
                }

                if (!ModelState.IsValid)
                {
                    _loggerService.LogWarn($"Author data was incomplete");
                    return BadRequest(ModelState);
                }


                var author = _mapper.Map<Author>(authorDTO);
                var isSuccess = await _authorRepository.Update(author);
                if (!isSuccess)
                {
                    return InternalError($"Author update failed");
                }
                _loggerService.LogInfo($"Author updated");
                return NoContent();
            }
            catch (Exception e)
            {
                return InternalError($"{e.Message} - {e.InnerException}");
            }
        }

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                _loggerService.LogInfo($"Author deleted attempted - id: {id}");

                if (id < 1)
                {
                    _loggerService.LogWarn($"Author deleted failed - id: {id}");
                    return BadRequest();
                }

                var isExist = await _authorRepository.isExists(id);
                if (!isExist)
                {
                    _loggerService.LogWarn($"Author not found - id: {id}");
                    return NotFound();
                }

                var author = await _authorRepository.FindById(id);
                if (author == null)
                {
                    _loggerService.LogWarn($"Author deleted not found - id: {id}");
                    return NotFound();
                }

                var isSuccess = await _authorRepository.Delete(author);
                if (!isSuccess)
                {
                    return InternalError($"Author delete failed");
                }

                _loggerService.LogInfo($"Author with id: {id} successfully deleted");

                return NoContent();
            }
            catch (Exception e)
            {
                return InternalError($"{e.Message} - {e.InnerException}");
            }
        }

        private ObjectResult InternalError(string  message)
        {
            _loggerService.LogError(message);

            return StatusCode(500, "Something went wrong. Please contact the Administrator");

        }

    }
}
