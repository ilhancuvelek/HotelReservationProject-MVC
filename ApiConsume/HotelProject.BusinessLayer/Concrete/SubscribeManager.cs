using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class SubscribeManager : ISubscribeService
    {
        private readonly ISubscribeDal _subscribe;
        public SubscribeManager(ISubscribeDal subscribe)
        {
            _subscribe = subscribe;
        }
        public void TAdd(Subscribe entity)
        {
            _subscribe.Add(entity);
        }

        public void TDelete(Subscribe entity)
        {
            _subscribe.Delete(entity);
        }

        public List<Subscribe> TGetAll()
        {
            return _subscribe.GetAll();
        }

        public Subscribe TGetById(int id)
        {
            return _subscribe.GetById(id);
        }

        public void TUpdate(Subscribe entity)
        {
            _subscribe.Update(entity);
        }
    }
}
