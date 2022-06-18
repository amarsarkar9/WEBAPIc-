using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEBAPI.Models;

namespace WEBAPI.Controllers
{
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();

        PeopleController()
        {
            people.Add(new Person { FirstName="amar",Lastname="sarkar",Id=1});
            people.Add(new Person { FirstName="Eshani",Lastname="Ball",Id=2});
            people.Add(new Person { FirstName="amartya",Lastname="mandal",Id=3});
        }

        [Route("api/People/GetFirstName")]
        [HttpGet]
        public List<String> GetFirstName()
        {
            List<String> fstName = new List<string>();
            foreach (var p in people){
                fstName.Add(p.FirstName);
            }

            return fstName;
        }


        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
                
                
                }

        // POST: api/People
        public void Post(Person val)
        {
            people.Add(val);
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
