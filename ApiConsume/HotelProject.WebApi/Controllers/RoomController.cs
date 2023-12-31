﻿using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        public IActionResult RoomList()
        {
            var values = _roomService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddRoom(Room Room)
        {
            _roomService.TAdd(Room);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateRoom(Room Room)
        {
            _roomService.TUpdate(Room);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteRoom(int id)
        {
            var value = _roomService.TGetById(id);
            _roomService.TDelete(value);
            return Ok(value);
        }
        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
            var value = _roomService.TGetById(id);
            return Ok(value);
        }
    }
}
