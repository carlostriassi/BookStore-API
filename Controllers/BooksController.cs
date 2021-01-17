using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookStore_API.Contracts;
using BookStore_API.Data;
using BookStore_API.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;
        private readonly ILoggerService _loggerService;

        public BooksController(IBookRepository bookRepository,
            IMapper _mapper,
            ILoggerService loggerService)
        {
            _bookRepository = bookRepository;
            this._mapper = _mapper;
            _loggerService = loggerService;
        }

        /// <summary>
        /// Gets the books.
        /// </summary>
        /// <returns>A List of Books</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetBooks()
        {
            var location = GetControllerActionNames();
            try
            {
                _loggerService.LogInfo($"{location}: Attempted call ");
                var books = await _bookRepository.FindAll();
                var response = _mapper.Map<IList<BookDTO>>(books);
                _loggerService.LogInfo($"{location}: Successfully called ");
                return Ok(response);
            }
            catch (Exception e)
            {
                return InternalError($"{location}: {e.Message} - {e.InnerException}");
            }

        }

        private string GetControllerActionNames()
        {
            var controller = ControllerContext.ActionDescriptor.ControllerName;
            var action
                = ControllerContext.ActionDescriptor.ActionName;
            return $"{controller}  - {action}";
        }
        /// <summary>
        /// Gets the book.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetBook(int id)
        {
            var location = GetControllerActionNames();
            try
            {
                _loggerService.LogInfo($"{location}: Attempted call with id: {id}");
                var book = await _bookRepository.FindById(id);
                if (book == null)
                {
                    _loggerService.LogWarn($"{location}:  with id: {id} was not found");
                    return NotFound();
                }
                var response = _mapper.Map<BookDTO>(book);
                _loggerService.LogInfo($"{location}: Successfully called with id: {id}");
                return Ok(response);
            }
            catch (Exception e)
            {
                return InternalError($"{location}: {e.Message} - {e.InnerException}");
            }

        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Create([FromBody] BookCreateDTO bookDTO)
        {
            var location = GetControllerActionNames();
            try
            {
                _loggerService.LogInfo($"{location}: submission attempted");
                if (bookDTO == null)
                {
                    _loggerService.LogWarn($"{location}: Empty request was submitted");
                    return BadRequest(ModelState);
                }

                if (!ModelState.IsValid)
                {
                    _loggerService.LogWarn($"{location}: data was incomplete");
                    return BadRequest(ModelState);
                }

                var book = _mapper.Map<Book>(bookDTO);
                var isSuccess = await _bookRepository.Create(book);
                if (!isSuccess)
                {
                    return InternalError($"{location}: Created failed");
                }
                _loggerService.LogInfo($"{location}: created");
                return Created("Create", new { book });
            }
            catch (Exception e)
            {
                return InternalError($"{location}: {e.Message} - {e.InnerException}");
            }
        }

        /// <summary>
        /// Updates the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="bookDTO">The book dto.</param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Update(int id, [FromBody] BookUpdateDTO bookDTO)
        {
            var location = GetControllerActionNames();
            try
            {
                _loggerService.LogInfo($"{location}: updated attempted - id: {id}");
                if (id < 1 || bookDTO == null || id != bookDTO.Id)
                {
                    _loggerService.LogWarn($"{location}: Empty request was submitted");
                    return BadRequest();
                }

                var isExist = await _bookRepository.isExists(id);
                if (!isExist)
                {
                    _loggerService.LogWarn($"{location}: not found - id: {id}");
                    return NotFound();
                }

                if (!ModelState.IsValid)
                {
                    _loggerService.LogWarn($"{location}: data was incomplete");
                    return BadRequest(ModelState);
                }


                var book = _mapper.Map<Book>(bookDTO);
                var isSuccess = await _bookRepository.Update(book);
                if (!isSuccess)
                {
                    return InternalError($"{location}: Update failed");
                }
                _loggerService.LogInfo($"{location}: updated");
                return NoContent();
            }
            catch (Exception e)
            {
                return InternalError($"{location}: {e.Message} - {e.InnerException}");
            }
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete(int id)
        {
            var location = GetControllerActionNames();
            try
            {
                _loggerService.LogInfo($"{location}: Delete attempted - id: {id}");

                if (id < 1)
                {
                    _loggerService.LogWarn($"{location}: Delete failed - id: {id}");
                    return BadRequest();
                }

                var isExist = await _bookRepository.isExists(id);
                if (!isExist)
                {
                    _loggerService.LogWarn($"{location}: not found - id: {id}");
                    return NotFound();
                }

                var book = await _bookRepository.FindById(id);
                if (book == null)
                {
                    _loggerService.LogWarn($"{location}: not found - id: {id}");
                    return NotFound();
                }

                var isSuccess = await _bookRepository.Delete(book);
                if (!isSuccess)
                {
                    return InternalError($"{location}: Delete failed");
                }

                _loggerService.LogInfo($"{location}: with id: {id} successfully deleted");

                return NoContent();
            }
            catch (Exception e)
            {
                return InternalError($"{location}: {e.Message} - {e.InnerException}");
            }
        }

        private ObjectResult InternalError(string message)
        {
            _loggerService.LogError(message);

            return StatusCode(500, "Something went wrong. Please contact the Administrator");

        }
    }
}
