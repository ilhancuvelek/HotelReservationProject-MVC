using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.EntityFramework;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonial;
        public TestimonialManager(ITestimonialDal testimonial)
        {
            _testimonial = testimonial;
        }
        public void TAdd(Testimonial entity)
        {
            _testimonial.Add(entity);
        }

        public void TDelete(Testimonial entity)
        {
            _testimonial.Delete(entity);
        }

        public List<Testimonial> TGetAll()
        {
            return _testimonial.GetAll();
        }

        public Testimonial TGetById(int id)
        {
            return _testimonial.GetById(id);
        }

        public void TUpdate(Testimonial entity)
        {
            _testimonial.Update(entity);
        }
    }
}
